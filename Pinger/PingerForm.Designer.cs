namespace Pinger
{
    partial class PingerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingerForm));
            this.addressLabel = new System.Windows.Forms.Label();
            this.sizeBytesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeBytesLabel = new System.Windows.Forms.Label();
            this.intervalSecondsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.intervalSecLabel = new System.Windows.Forms.Label();
            this.pingTimer = new System.Windows.Forms.Timer(this.components);
            this.historyTextBox = new System.Windows.Forms.TextBox();
            this.historyLabel = new System.Windows.Forms.Label();
            this.addressComboBox = new System.Windows.Forms.ComboBox();
            this.clearHistorybutton = new System.Windows.Forms.Button();
            this.syncButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBytesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSecondsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(83, 15);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sizeBytesNumericUpDown
            // 
            this.sizeBytesNumericUpDown.Location = new System.Drawing.Point(137, 38);
            this.sizeBytesNumericUpDown.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.sizeBytesNumericUpDown.Name = "sizeBytesNumericUpDown";
            this.sizeBytesNumericUpDown.Size = new System.Drawing.Size(140, 20);
            this.sizeBytesNumericUpDown.TabIndex = 3;
            // 
            // sizeBytesLabel
            // 
            this.sizeBytesLabel.AutoSize = true;
            this.sizeBytesLabel.Location = new System.Drawing.Point(67, 40);
            this.sizeBytesLabel.Name = "sizeBytesLabel";
            this.sizeBytesLabel.Size = new System.Drawing.Size(64, 13);
            this.sizeBytesLabel.TabIndex = 4;
            this.sizeBytesLabel.Text = "Size (bytes):";
            this.sizeBytesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // intervalSecondsNumericUpDown
            // 
            this.intervalSecondsNumericUpDown.Location = new System.Drawing.Point(137, 64);
            this.intervalSecondsNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.intervalSecondsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalSecondsNumericUpDown.Name = "intervalSecondsNumericUpDown";
            this.intervalSecondsNumericUpDown.Size = new System.Drawing.Size(140, 20);
            this.intervalSecondsNumericUpDown.TabIndex = 3;
            this.intervalSecondsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalSecondsNumericUpDown.ValueChanged += new System.EventHandler(this.intervalSecondsNumericUpDown_ValueChanged);
            // 
            // intervalSecLabel
            // 
            this.intervalSecLabel.AutoSize = true;
            this.intervalSecLabel.Location = new System.Drawing.Point(37, 66);
            this.intervalSecLabel.Name = "intervalSecLabel";
            this.intervalSecLabel.Size = new System.Drawing.Size(94, 13);
            this.intervalSecLabel.TabIndex = 4;
            this.intervalSecLabel.Text = "Interval (seconds):";
            this.intervalSecLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pingTimer
            // 
            this.pingTimer.Tick += new System.EventHandler(this.pingTimer_Tick);
            // 
            // historyTextBox
            // 
            this.historyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyTextBox.Location = new System.Drawing.Point(12, 109);
            this.historyTextBox.Multiline = true;
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyTextBox.Size = new System.Drawing.Size(317, 217);
            this.historyTextBox.TabIndex = 5;
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(12, 93);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(42, 13);
            this.historyLabel.TabIndex = 6;
            this.historyLabel.Text = "History:";
            // 
            // addressComboBox
            // 
            this.addressComboBox.FormattingEnabled = true;
            this.addressComboBox.Location = new System.Drawing.Point(137, 12);
            this.addressComboBox.Name = "addressComboBox";
            this.addressComboBox.Size = new System.Drawing.Size(140, 21);
            this.addressComboBox.TabIndex = 7;
            this.addressComboBox.TextChanged += new System.EventHandler(this.addressComboBox_TextChanged);
            // 
            // clearHistorybutton
            // 
            this.clearHistorybutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearHistorybutton.Location = new System.Drawing.Point(15, 332);
            this.clearHistorybutton.Name = "clearHistorybutton";
            this.clearHistorybutton.Size = new System.Drawing.Size(100, 25);
            this.clearHistorybutton.TabIndex = 8;
            this.clearHistorybutton.Text = "Clear History";
            this.clearHistorybutton.UseVisualStyleBackColor = true;
            this.clearHistorybutton.Click += new System.EventHandler(this.clearHistorybutton_Click);
            // 
            // syncButton
            // 
            this.syncButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.syncButton.Location = new System.Drawing.Point(254, 333);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(75, 23);
            this.syncButton.TabIndex = 9;
            this.syncButton.Text = "Sync";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // PingerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 364);
            this.Controls.Add(this.syncButton);
            this.Controls.Add(this.clearHistorybutton);
            this.Controls.Add(this.addressComboBox);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.historyTextBox);
            this.Controls.Add(this.intervalSecLabel);
            this.Controls.Add(this.sizeBytesLabel);
            this.Controls.Add(this.intervalSecondsNumericUpDown);
            this.Controls.Add(this.sizeBytesNumericUpDown);
            this.Controls.Add(this.addressLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PingerForm";
            this.Text = "Pinger";
            ((System.ComponentModel.ISupportInitialize)(this.sizeBytesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSecondsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.NumericUpDown sizeBytesNumericUpDown;
        private System.Windows.Forms.Label sizeBytesLabel;
        private System.Windows.Forms.NumericUpDown intervalSecondsNumericUpDown;
        private System.Windows.Forms.Label intervalSecLabel;
        private System.Windows.Forms.Timer pingTimer;
        private System.Windows.Forms.TextBox historyTextBox;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.ComboBox addressComboBox;
        private System.Windows.Forms.Button clearHistorybutton;
        private System.Windows.Forms.Button syncButton;
    }
}

