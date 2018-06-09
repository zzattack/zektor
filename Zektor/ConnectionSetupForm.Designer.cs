namespace Zektor {
    partial class ConnectionSetupForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.rbSerialPort = new System.Windows.Forms.RadioButton();
            this.rbTcpIp = new System.Windows.Forms.RadioButton();
            this.pnlTcp = new System.Windows.Forms.Panel();
            this.nudTcpPort = new System.Windows.Forms.NumericUpDown();
            this.lblTcpPort = new System.Windows.Forms.Label();
            this.lblHostname = new System.Windows.Forms.Label();
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.pnlSerial = new System.Windows.Forms.Panel();
            this.lblBaudrate = new System.Windows.Forms.Label();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.gbConnection.SuspendLayout();
            this.pnlTcp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTcpPort)).BeginInit();
            this.pnlSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConnection.Controls.Add(this.rbSerialPort);
            this.gbConnection.Controls.Add(this.rbTcpIp);
            this.gbConnection.Controls.Add(this.pnlTcp);
            this.gbConnection.Controls.Add(this.pnlSerial);
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(266, 129);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection details";
            // 
            // rbSerialPort
            // 
            this.rbSerialPort.AutoSize = true;
            this.rbSerialPort.Location = new System.Drawing.Point(142, 29);
            this.rbSerialPort.Name = "rbSerialPort";
            this.rbSerialPort.Size = new System.Drawing.Size(72, 17);
            this.rbSerialPort.TabIndex = 1;
            this.rbSerialPort.TabStop = true;
            this.rbSerialPort.Text = "Serial port";
            this.rbSerialPort.UseVisualStyleBackColor = true;
            this.rbSerialPort.CheckedChanged += new System.EventHandler(this.RbSerialPortCheckedChanged);
            // 
            // rbTcpIp
            // 
            this.rbTcpIp.AutoSize = true;
            this.rbTcpIp.Location = new System.Drawing.Point(19, 29);
            this.rbTcpIp.Name = "rbTcpIp";
            this.rbTcpIp.Size = new System.Drawing.Size(117, 17);
            this.rbTcpIp.TabIndex = 0;
            this.rbTcpIp.TabStop = true;
            this.rbTcpIp.Text = "TCP/IP connection";
            this.rbTcpIp.UseVisualStyleBackColor = true;
            this.rbTcpIp.CheckedChanged += new System.EventHandler(this.RbSerialPortCheckedChanged);
            // 
            // pnlTcp
            // 
            this.pnlTcp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTcp.Controls.Add(this.nudTcpPort);
            this.pnlTcp.Controls.Add(this.lblTcpPort);
            this.pnlTcp.Controls.Add(this.lblHostname);
            this.pnlTcp.Controls.Add(this.tbHostname);
            this.pnlTcp.Location = new System.Drawing.Point(19, 52);
            this.pnlTcp.Name = "pnlTcp";
            this.pnlTcp.Size = new System.Drawing.Size(241, 62);
            this.pnlTcp.TabIndex = 3;
            // 
            // nudTcpPort
            // 
            this.nudTcpPort.Location = new System.Drawing.Point(87, 33);
            this.nudTcpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudTcpPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTcpPort.Name = "nudTcpPort";
            this.nudTcpPort.Size = new System.Drawing.Size(67, 20);
            this.nudTcpPort.TabIndex = 3;
            this.nudTcpPort.Value = new decimal(new int[] {
            50005,
            0,
            0,
            0});
            // 
            // lblTcpPort
            // 
            this.lblTcpPort.AutoSize = true;
            this.lblTcpPort.Location = new System.Drawing.Point(13, 35);
            this.lblTcpPort.Name = "lblTcpPort";
            this.lblTcpPort.Size = new System.Drawing.Size(26, 13);
            this.lblTcpPort.TabIndex = 2;
            this.lblTcpPort.Text = "Port";
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(13, 10);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(68, 13);
            this.lblHostname.TabIndex = 0;
            this.lblHostname.Text = "Hostname/ip";
            // 
            // tbHostname
            // 
            this.tbHostname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHostname.Location = new System.Drawing.Point(87, 7);
            this.tbHostname.Name = "tbHostname";
            this.tbHostname.Size = new System.Drawing.Size(140, 20);
            this.tbHostname.TabIndex = 1;
            // 
            // pnlSerial
            // 
            this.pnlSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSerial.Controls.Add(this.lblBaudrate);
            this.pnlSerial.Controls.Add(this.lblSerialPort);
            this.pnlSerial.Controls.Add(this.cbBaudrate);
            this.pnlSerial.Controls.Add(this.cbSerialPort);
            this.pnlSerial.Location = new System.Drawing.Point(19, 52);
            this.pnlSerial.Name = "pnlSerial";
            this.pnlSerial.Size = new System.Drawing.Size(241, 62);
            this.pnlSerial.TabIndex = 2;
            // 
            // lblBaudrate
            // 
            this.lblBaudrate.AutoSize = true;
            this.lblBaudrate.Location = new System.Drawing.Point(13, 35);
            this.lblBaudrate.Name = "lblBaudrate";
            this.lblBaudrate.Size = new System.Drawing.Size(50, 13);
            this.lblBaudrate.TabIndex = 2;
            this.lblBaudrate.Text = "Baudrate";
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(13, 10);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(54, 13);
            this.lblSerialPort.TabIndex = 0;
            this.lblSerialPort.Text = "Serial port";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200"});
            this.cbBaudrate.Location = new System.Drawing.Point(87, 33);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(140, 21);
            this.cbBaudrate.TabIndex = 3;
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(87, 7);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(140, 21);
            this.cbSerialPort.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(121, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(202, 147);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // ConnectionSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 182);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.gbConnection);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 221);
            this.Name = "ConnectionSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setup connection";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.pnlTcp.ResumeLayout(false);
            this.pnlTcp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTcpPort)).EndInit();
            this.pnlSerial.ResumeLayout(false);
            this.pnlSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Panel pnlSerial;
        private System.Windows.Forms.Panel pnlTcp;
        private System.Windows.Forms.TextBox tbHostname;
        private System.Windows.Forms.RadioButton rbSerialPort;
        private System.Windows.Forms.RadioButton rbTcpIp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.Label lblBaudrate;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.NumericUpDown nudTcpPort;
        private System.Windows.Forms.Label lblTcpPort;
        private System.Windows.Forms.Label lblHostname;
    }
}