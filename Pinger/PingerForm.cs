using System;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Pinger
{
    public partial class PingerForm : Form, INotifyPropertyChanged
    {
        private SyncInstances _syncInstances;

        public PingerForm()
        {
            InitializeComponent();
            var defaultIpAddress = ConfigurationManager.AppSettings["defaultIpAddress"];
            addressComboBox.Text = defaultIpAddress;

            var ipAddresses =
                ConfigurationManager.AppSettings["IPAddresses"].Split(',').Select(addr => (object) addr).ToArray();
            addressComboBox.Items.AddRange(ipAddresses);

            int defaultSizeBytes;
            defaultSizeBytes = int.TryParse(ConfigurationManager.AppSettings["defaultSizeBytes"], out defaultSizeBytes)
                ? defaultSizeBytes
                : 32;
            sizeBytesNumericUpDown.Value = defaultSizeBytes;

            int defaultIntervalSeconds;
            defaultIntervalSeconds = int.TryParse(ConfigurationManager.AppSettings["defaultIntervalSeconds"],
                out defaultIntervalSeconds)
                ? defaultIntervalSeconds
                : 10;
            ;
            intervalSecondsNumericUpDown.Value = defaultIntervalSeconds;

            DataBindings.Add("Text", this, "WindowTitle");

            ResetTimer();

            // MSMQ sync isn't working.
            _syncInstances = new SyncInstances(DoSync);
            this.syncButton.Enabled = _syncInstances.SyncEnabled;
            //this.syncButton.Visible = false;
        }

        public string WindowTitle => $"Pinger {addressComboBox.Text}";

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void pingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                var ping = new Ping();
                var pingSent = DateTime.Now;

                ping.PingCompleted += (o, args) =>
                {
                    if (args.Reply.Status == IPStatus.Success)
                        historyTextBox.AppendText(
                            $"{pingSent} Pinged {args.Reply.Address} in {args.Reply.RoundtripTime}ms." +
                            Environment.NewLine);
                    else
                        historyTextBox.AppendText($"{pingSent} Failed {args.Reply.Status}" + Environment.NewLine);
                };

                ping.SendAsync(
                    IPAddress.Parse(addressComboBox.Text),
                    1000,
                    new byte[(int) sizeBytesNumericUpDown.Value]);
            }
            catch (Exception ex)
            {
                historyTextBox.AppendText($"{DateTime.Now} {ex.GetType().Name}: {ex.Message}" + Environment.NewLine);
            }
        }

        private void intervalSecondsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ResetTimer();
            }
            catch (Exception ex)
            {
                historyTextBox.AppendText($"{DateTime.Now} {ex.GetType().Name}: {ex.Message}" + Environment.NewLine);
                throw;
            }
        }

        private void ResetTimer()
        {
            pingTimer.Stop();
            pingTimer.Interval = (int)intervalSecondsNumericUpDown.Value * 1000;
            pingTimer.Start();
        }

        private void addressComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("WindowTitle"));
                ResetTimer();
            }
            catch (Exception ex)
            {
                historyTextBox.AppendText($"{DateTime.Now} {ex.GetType().Name}: {ex.Message}" + Environment.NewLine);
                throw;
            }
        }

        private void clearHistorybutton_Click(object sender, EventArgs e)
        {
            try
            {
                historyTextBox.Clear();
            }
            catch (Exception ex)
            {
                historyTextBox.AppendText($"{DateTime.Now} {ex.GetType().Name}: {ex.Message}" + Environment.NewLine);
                throw;
            }
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            try
            {
                _syncInstances.SendSync();
            }
            catch (Exception ex)
            {
                historyTextBox.AppendText($"{DateTime.Now} {ex.GetType().Name}: {ex.Message}" + Environment.NewLine);
                throw;
            }
        }

        private void DoSync()
        {
            if (InvokeRequired)
                Invoke((MethodInvoker) delegate
                {
                    historyTextBox.AppendText($"Synchronised at {DateTime.Now}" + Environment.NewLine);

                    ResetTimer();
                    pingTimer_Tick(null, null);
                });
        }
    }
}
