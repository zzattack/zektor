namespace Zektor {
    partial class ZoneMapControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblZone = new System.Windows.Forms.Label();
            this.ckbBreakaway = new System.Windows.Forms.CheckBox();
            this.cbVideoInput = new System.Windows.Forms.ComboBox();
            this.bsVideoMap = new System.Windows.Forms.BindingSource(this.components);
            this.cbAnalogAudioInput = new System.Windows.Forms.ComboBox();
            this.bsAnalogAudioMap = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnalogAudio = new System.Windows.Forms.Label();
            this.ckbMuteDigitalAudio = new System.Windows.Forms.CheckBox();
            this.ckbMuteAnalogAudio = new System.Windows.Forms.CheckBox();
            this.ckbMuteVideo = new System.Windows.Forms.CheckBox();
            this.lblDigitalAudio = new System.Windows.Forms.Label();
            this.cbDigitalAudioInput = new System.Windows.Forms.ComboBox();
            this.bsDigitalAudioMap = new System.Windows.Forms.BindingSource(this.components);
            this.gbIOs = new System.Windows.Forms.GroupBox();
            this.nudDigitalAudioDelay = new System.Windows.Forms.NumericUpDown();
            this.nudAnalogAudioDelay = new System.Windows.Forms.NumericUpDown();
            this.nudVideoDelay = new System.Windows.Forms.NumericUpDown();
            this.lblSwitchDelay = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblUnknownAudioMode = new System.Windows.Forms.Label();
            this.lblZoneName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVideoMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnalogAudioMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDigitalAudioMap)).BeginInit();
            this.gbIOs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDigitalAudioDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnalogAudioDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZone.Location = new System.Drawing.Point(18, 3);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(19, 20);
            this.lblZone.TabIndex = 0;
            this.lblZone.Text = "#";
            // 
            // ckbBreakaway
            // 
            this.ckbBreakaway.AutoSize = true;
            this.ckbBreakaway.Checked = true;
            this.ckbBreakaway.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ckbBreakaway.Enabled = false;
            this.ckbBreakaway.Location = new System.Drawing.Point(181, 31);
            this.ckbBreakaway.Name = "ckbBreakaway";
            this.ckbBreakaway.Size = new System.Drawing.Size(100, 17);
            this.ckbBreakaway.TabIndex = 2;
            this.ckbBreakaway.Text = "A/V breakaway";
            this.ckbBreakaway.UseVisualStyleBackColor = true;
            // 
            // cbVideoInput
            // 
            this.cbVideoInput.DataSource = this.bsVideoMap;
            this.cbVideoInput.DisplayMember = "Name";
            this.cbVideoInput.FormattingEnabled = true;
            this.cbVideoInput.Location = new System.Drawing.Point(114, 56);
            this.cbVideoInput.Name = "cbVideoInput";
            this.cbVideoInput.Size = new System.Drawing.Size(121, 21);
            this.cbVideoInput.TabIndex = 5;
            this.cbVideoInput.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // bsVideoMap
            // 
            this.bsVideoMap.DataSource = typeof(Zektor.VideoInputMapEntry);
            // 
            // cbAnalogAudioInput
            // 
            this.cbAnalogAudioInput.DataSource = this.bsAnalogAudioMap;
            this.cbAnalogAudioInput.DisplayMember = "Name";
            this.cbAnalogAudioInput.FormattingEnabled = true;
            this.cbAnalogAudioInput.Location = new System.Drawing.Point(114, 83);
            this.cbAnalogAudioInput.Name = "cbAnalogAudioInput";
            this.cbAnalogAudioInput.Size = new System.Drawing.Size(121, 21);
            this.cbAnalogAudioInput.TabIndex = 9;
            this.cbAnalogAudioInput.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // bsAnalogAudioMap
            // 
            this.bsAnalogAudioMap.DataSource = typeof(Zektor.AudioInputMapEntry);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Video input";
            // 
            // lblAnalogAudio
            // 
            this.lblAnalogAudio.AutoSize = true;
            this.lblAnalogAudio.Location = new System.Drawing.Point(13, 86);
            this.lblAnalogAudio.Name = "lblAnalogAudio";
            this.lblAnalogAudio.Size = new System.Drawing.Size(95, 13);
            this.lblAnalogAudio.TabIndex = 8;
            this.lblAnalogAudio.Text = "Analog audio input";
            // 
            // ckbMuteDigitalAudio
            // 
            this.ckbMuteDigitalAudio.AutoSize = true;
            this.ckbMuteDigitalAudio.Location = new System.Drawing.Point(241, 112);
            this.ckbMuteDigitalAudio.Name = "ckbMuteDigitalAudio";
            this.ckbMuteDigitalAudio.Size = new System.Drawing.Size(50, 17);
            this.ckbMuteDigitalAudio.TabIndex = 14;
            this.ckbMuteDigitalAudio.Text = "Mute";
            this.ckbMuteDigitalAudio.UseVisualStyleBackColor = true;
            // 
            // ckbMuteAnalogAudio
            // 
            this.ckbMuteAnalogAudio.AutoSize = true;
            this.ckbMuteAnalogAudio.Location = new System.Drawing.Point(241, 86);
            this.ckbMuteAnalogAudio.Name = "ckbMuteAnalogAudio";
            this.ckbMuteAnalogAudio.Size = new System.Drawing.Size(50, 17);
            this.ckbMuteAnalogAudio.TabIndex = 10;
            this.ckbMuteAnalogAudio.Text = "Mute";
            this.ckbMuteAnalogAudio.UseVisualStyleBackColor = true;
            // 
            // ckbMuteVideo
            // 
            this.ckbMuteVideo.AutoSize = true;
            this.ckbMuteVideo.Location = new System.Drawing.Point(241, 58);
            this.ckbMuteVideo.Name = "ckbMuteVideo";
            this.ckbMuteVideo.Size = new System.Drawing.Size(50, 17);
            this.ckbMuteVideo.TabIndex = 6;
            this.ckbMuteVideo.Text = "Mute";
            this.ckbMuteVideo.UseVisualStyleBackColor = true;
            // 
            // lblDigitalAudio
            // 
            this.lblDigitalAudio.AutoSize = true;
            this.lblDigitalAudio.Location = new System.Drawing.Point(13, 113);
            this.lblDigitalAudio.Name = "lblDigitalAudio";
            this.lblDigitalAudio.Size = new System.Drawing.Size(91, 13);
            this.lblDigitalAudio.TabIndex = 12;
            this.lblDigitalAudio.Text = "Digital audio input";
            // 
            // cbDigitalAudioInput
            // 
            this.cbDigitalAudioInput.DataSource = this.bsDigitalAudioMap;
            this.cbDigitalAudioInput.DisplayMember = "Name";
            this.cbDigitalAudioInput.FormattingEnabled = true;
            this.cbDigitalAudioInput.Location = new System.Drawing.Point(114, 110);
            this.cbDigitalAudioInput.Name = "cbDigitalAudioInput";
            this.cbDigitalAudioInput.Size = new System.Drawing.Size(121, 21);
            this.cbDigitalAudioInput.TabIndex = 13;
            this.cbDigitalAudioInput.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // bsDigitalAudioMap
            // 
            this.bsDigitalAudioMap.DataSource = typeof(Zektor.AudioInputMapEntry);
            // 
            // gbIOs
            // 
            this.gbIOs.Controls.Add(this.nudDigitalAudioDelay);
            this.gbIOs.Controls.Add(this.nudAnalogAudioDelay);
            this.gbIOs.Controls.Add(this.nudVideoDelay);
            this.gbIOs.Controls.Add(this.lblSwitchDelay);
            this.gbIOs.Controls.Add(this.btnChange);
            this.gbIOs.Controls.Add(this.btnRead);
            this.gbIOs.Controls.Add(this.ckbMuteDigitalAudio);
            this.gbIOs.Controls.Add(this.lblDigitalAudio);
            this.gbIOs.Controls.Add(this.ckbMuteAnalogAudio);
            this.gbIOs.Controls.Add(this.ckbBreakaway);
            this.gbIOs.Controls.Add(this.ckbMuteVideo);
            this.gbIOs.Controls.Add(this.cbDigitalAudioInput);
            this.gbIOs.Controls.Add(this.cbVideoInput);
            this.gbIOs.Controls.Add(this.cbAnalogAudioInput);
            this.gbIOs.Controls.Add(this.label1);
            this.gbIOs.Controls.Add(this.lblAnalogAudio);
            this.gbIOs.Enabled = false;
            this.gbIOs.Location = new System.Drawing.Point(6, 26);
            this.gbIOs.Name = "gbIOs";
            this.gbIOs.Size = new System.Drawing.Size(364, 145);
            this.gbIOs.TabIndex = 2;
            this.gbIOs.TabStop = false;
            this.gbIOs.Text = "I/O selection";
            this.gbIOs.Visible = false;
            // 
            // nudDigitalAudioDelay
            // 
            this.nudDigitalAudioDelay.Location = new System.Drawing.Point(297, 111);
            this.nudDigitalAudioDelay.Maximum = new decimal(new int[] {
            35000,
            0,
            0,
            0});
            this.nudDigitalAudioDelay.Name = "nudDigitalAudioDelay";
            this.nudDigitalAudioDelay.Size = new System.Drawing.Size(60, 20);
            this.nudDigitalAudioDelay.TabIndex = 15;
            this.nudDigitalAudioDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudAnalogAudioDelay
            // 
            this.nudAnalogAudioDelay.Location = new System.Drawing.Point(297, 85);
            this.nudAnalogAudioDelay.Maximum = new decimal(new int[] {
            35000,
            0,
            0,
            0});
            this.nudAnalogAudioDelay.Name = "nudAnalogAudioDelay";
            this.nudAnalogAudioDelay.Size = new System.Drawing.Size(60, 20);
            this.nudAnalogAudioDelay.TabIndex = 11;
            this.nudAnalogAudioDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudVideoDelay
            // 
            this.nudVideoDelay.Location = new System.Drawing.Point(297, 57);
            this.nudVideoDelay.Maximum = new decimal(new int[] {
            35000,
            0,
            0,
            0});
            this.nudVideoDelay.Name = "nudVideoDelay";
            this.nudVideoDelay.Size = new System.Drawing.Size(60, 20);
            this.nudVideoDelay.TabIndex = 7;
            this.nudVideoDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSwitchDelay
            // 
            this.lblSwitchDelay.AutoSize = true;
            this.lblSwitchDelay.Location = new System.Drawing.Point(291, 27);
            this.lblSwitchDelay.Name = "lblSwitchDelay";
            this.lblSwitchDelay.Size = new System.Drawing.Size(69, 26);
            this.lblSwitchDelay.TabIndex = 3;
            this.lblSwitchDelay.Text = "Switch delay\r\n(milliseconds)";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(97, 27);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(16, 27);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblUnknownAudioMode
            // 
            this.lblUnknownAudioMode.AutoSize = true;
            this.lblUnknownAudioMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnknownAudioMode.Location = new System.Drawing.Point(62, 66);
            this.lblUnknownAudioMode.Name = "lblUnknownAudioMode";
            this.lblUnknownAudioMode.Size = new System.Drawing.Size(200, 40);
            this.lblUnknownAudioMode.TabIndex = 28;
            this.lblUnknownAudioMode.Text = "Unknown audio mode\r\nRead extended settings";
            this.lblUnknownAudioMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblZoneName
            // 
            this.lblZoneName.AutoSize = true;
            this.lblZoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoneName.Location = new System.Drawing.Point(56, 3);
            this.lblZoneName.Name = "lblZoneName";
            this.lblZoneName.Size = new System.Drawing.Size(50, 20);
            this.lblZoneName.TabIndex = 1;
            this.lblZoneName.Text = "Zone";
            // 
            // ZoneMapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblZoneName);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.gbIOs);
            this.Controls.Add(this.lblUnknownAudioMode);
            this.Name = "ZoneMapControl";
            this.Size = new System.Drawing.Size(375, 174);
            ((System.ComponentModel.ISupportInitialize)(this.bsVideoMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnalogAudioMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDigitalAudioMap)).EndInit();
            this.gbIOs.ResumeLayout(false);
            this.gbIOs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDigitalAudioDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnalogAudioDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.CheckBox ckbBreakaway;
        private System.Windows.Forms.ComboBox cbVideoInput;
        private System.Windows.Forms.ComboBox cbAnalogAudioInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnalogAudio;
        private System.Windows.Forms.CheckBox ckbMuteDigitalAudio;
        private System.Windows.Forms.CheckBox ckbMuteAnalogAudio;
        private System.Windows.Forms.CheckBox ckbMuteVideo;
        private System.Windows.Forms.Label lblDigitalAudio;
        private System.Windows.Forms.ComboBox cbDigitalAudioInput;
        private System.Windows.Forms.GroupBox gbIOs;
        private System.Windows.Forms.Label lblUnknownAudioMode;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.NumericUpDown nudDigitalAudioDelay;
        private System.Windows.Forms.NumericUpDown nudAnalogAudioDelay;
        private System.Windows.Forms.NumericUpDown nudVideoDelay;
        private System.Windows.Forms.Label lblSwitchDelay;
        private System.Windows.Forms.BindingSource bsVideoMap;
        private System.Windows.Forms.BindingSource bsAnalogAudioMap;
        private System.Windows.Forms.BindingSource bsDigitalAudioMap;
        private System.Windows.Forms.Label lblZoneName;
    }
}
