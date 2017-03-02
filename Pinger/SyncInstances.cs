using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Pinger
{
    class SyncInstances
    {
        private MessageQueue queue;
        public bool SyncEnabled;
        private Action doSync;
        private string _queueLabel;


        public SyncInstances(Action doSync)
        {
            this.doSync = doSync;

            try
            {
                _queueLabel = (@"Private$\" + Application.ProductName + "-").ToLower();

                var queueName = @".\" + _queueLabel + Process.GetCurrentProcess().Id;

                if (MessageQueue.Exists(queueName))
                    queue = new MessageQueue(queueName);
                else
                    queue = MessageQueue.Create(queueName, false);

                queue.ReceiveCompleted += ReceiveSync;
                queue.BeginReceive();

                SyncEnabled = true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                SyncEnabled = false;
                throw;
            }

        }

        private void ReceiveSync(object sender, ReceiveCompletedEventArgs e)
        {
            try
            {
                if (!SyncEnabled) return;

                doSync();

                queue.BeginReceive();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        public void SendSync()
        {
            try
            {
                if (!SyncEnabled) return;
                foreach (var remoteQueue in  MessageQueue.GetPrivateQueuesByMachine(".").Where(q => q.Path.Contains(_queueLabel)))
                {
                    remoteQueue.Send(null);
                    System.Diagnostics.Debug.WriteLine(remoteQueue.QueueName);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

    }
}
