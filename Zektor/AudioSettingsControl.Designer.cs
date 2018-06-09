namespace Zektor {
    partial class AudioSettingsControl {
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
            this.gbEqualizer = new System.Windows.Forms.GroupBox();
            this.btnFlatten = new System.Windows.Forms.Button();
            this.lbl10kHz = new System.Windows.Forms.Label();
            this.lbl3kHz = new System.Windows.Forms.Label();
            this.lbl1kHz = new System.Windows.Forms.Label();
            this.lbl330Hz = new System.Windows.Forms.Label();
            this.lbl100Hz = new System.Windows.Forms.Label();
            this.tkbEqBand1 = new System.Windows.Forms.TrackBar();
            this.tkbEqBand2 = new System.Windows.Forms.TrackBar();
            this.tkbEqBand3 = new System.Windows.Forms.TrackBar();
            this.tkbEqBand4 = new System.Windows.Forms.TrackBar();
            this.tkbEqBand5 = new System.Windows.Forms.TrackBar();
            this.tkbZoneVolume = new System.Windows.Forms.TrackBar();
            this.lblVolumeLevelVal = new System.Windows.Forms.Label();
            this.lblVolumeLevel = new System.Windows.Forms.Label();
            this.lblBassLevelVal = new System.Windows.Forms.Label();
            this.lblBass = new System.Windows.Forms.Label();
            this.tkbBassLevel = new System.Windows.Forms.TrackBar();
            this.lblTrebleLevelVal = new System.Windows.Forms.Label();
            this.tkbTrebleLevel = new System.Windows.Forms.TrackBar();
            this.cbStereoMixdownMode = new System.Windows.Forms.ComboBox();
            this.lblStereoMixdownMode = new System.Windows.Forms.Label();
            this.cbDigitalRouteOption = new System.Windows.Forms.ComboBox();
            this.lblDigitalRoute = new System.Windows.Forms.Label();
            this.lblZoneName = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.btnChangeAll = new System.Windows.Forms.Button();
            this.btnReadAll = new System.Windows.Forms.Button();
            this.gb = new System.Windows.Forms.GroupBox();
            this.lblTreble = new System.Windows.Forms.Label();
            this.gbEqualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEqBand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEqBand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEqBand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEqBand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEqBand5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbZoneVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBassLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrebleLevel)).BeginInit();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEqualizer
            // 
            this.gbEqualizer.Controls.Add(this.btnFlatten);
            this.gbEqualizer.Controls.Add(this.lbl10kHz);
            this.gbEqualizer.Controls.Add(this.lbl3kHz);
            this.gbEqualizer.Controls.Add(this.lbl1kHz);
            this.gbEqualizer.Controls.Add(this.lbl330Hz);
            this.gbEqualizer.Controls.Add(this.lbl100Hz);
            this.gbEqualizer.Controls.Add(this.tkbEqBand1);
            this.gbEqualizer.Controls.Add(this.tkbEqBand2);
            this.gbEqualizer.Controls.Add(this.tkbEqBand3);
            this.gbEqualizer.Controls.Add(this.tkbEqBand4);
            this.gbEqualizer.Controls.Add(this.tkbEqBand5);
            this.gbEqualizer.Location = new System.Drawing.Point(3, 212);
            this.gbEqualizer.Name = "gbEqualizer";
            this.gbEqualizer.Size = new System.Drawing.Size(221, 157);
            this.gbEqualizer.TabIndex = 9;
            this.gbEqualizer.TabStop = false;
            this.gbEqualizer.Text = "Equalizer";
            // 
            // btnFlatten
            // 
            this.btnFlatten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlatten.Location = new System.Drawing.Point(35, 134);
            this.btnFlatten.Name = "btnFlatten";
            this.btnFlatten.Size = new System.Drawing.Size(156, 20);
            this.btnFlatten.TabIndex = 10;
            this.btnFlatten.Text = "Flatten";
            this.btnFlatten.UseVisualStyleBackColor = true;
            this.btnFlatten.Click += new System.EventHandler(this.btnFlatten_Click);
            // 
            // lbl10kHz
            // 
            this.lbl10kHz.AutoSize = true;
            this.lbl10kHz.Location = new System.Drawing.Point(178, 118);
            this.lbl10kHz.Name = "lbl10kHz";
            this.lbl10kHz.Size = new System.Drawing.Size(38, 13);
            this.lbl10kHz.TabIndex = 9;
            this.lbl10kHz.Text = "10kHz";
            // 
            // lbl3kHz
            // 
            this.lbl3kHz.AutoSize = true;
            this.lbl3kHz.Location = new System.Drawing.Point(133, 118);
            this.lbl3kHz.Name = "lbl3kHz";
            this.lbl3kHz.Size = new System.Drawing.Size(41, 13);
            this.lbl3kHz.TabIndex = 8;
            this.lbl3kHz.Text = "3.3kHz";
            // 
            // lbl1kHz
            // 
            this.lbl1kHz.AutoSize = true;
            this.lbl1kHz.Location = new System.Drawing.Point(93, 118);
            this.lbl1kHz.Name = "lbl1kHz";
            this.lbl1kHz.Size = new System.Drawing.Size(32, 13);
            this.lbl1kHz.TabIndex = 7;
            this.lbl1kHz.Text = "1kHz";
            // 
            // lbl330Hz
            // 
            this.lbl330Hz.AutoSize = true;
            this.lbl330Hz.Location = new System.Drawing.Point(45, 118);
            this.lbl330Hz.Name = "lbl330Hz";
            this.lbl330Hz.Size = new System.Drawing.Size(38, 13);
            this.lbl330Hz.TabIndex = 6;
            this.lbl330Hz.Text = "330Hz";
            // 
            // lbl100Hz
            // 
            this.lbl100Hz.AutoSize = true;
            this.lbl100Hz.Location = new System.Drawing.Point(4, 118);
            this.lbl100Hz.Name = "lbl100Hz";
            this.lbl100Hz.Size = new System.Drawing.Size(38, 13);
            this.lbl100Hz.TabIndex = 5;
            this.lbl100Hz.Text = "100Hz";
            // 
            // tkbEqBand1
            // 
            this.tkbEqBand1.Location = new System.Drawing.Point(5, 17);
            this.tkbEqBand1.Maximum = 168;
            this.tkbEqBand1.Minimum = 88;
            this.tkbEqBand1.Name = "tkbEqBand1";
            this.tkbEqBand1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkbEqBand1.Size = new System.Drawing.Size(45, 104);
            this.tkbEqBand1.TabIndex = 0;
            this.tkbEqBand1.Value = 128;
            // 
            // tkbEqBand2
            // 
            this.tkbEqBand2.Location = new System.Drawing.Point(47, 17);
            this.tkbEqBand2.Maximum = 168;
            this.tkbEqBand2.Minimum = 88;
            this.tkbEqBand2.Name = "tkbEqBand2";
            this.tkbEqBand2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkbEqBand2.Size = new System.Drawing.Size(45, 104);
            this.tkbEqBand2.TabIndex = 1;
            this.tkbEqBand2.Value = 128;
            // 
            // tkbEqBand3
            // 
            this.tkbEqBand3.Location = new System.Drawing.Point(89, 17);
            this.tkbEqBand3.Maximum = 168;
            this.tkbEqBand3.Minimum = 88;
            this.tkbEqBand3.Name = "tkbEqBand3";
            this.tkbEqBand3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkbEqBand3.Size = new System.Drawing.Size(45, 104);
            this.tkbEqBand3.TabIndex = 2;
            this.tkbEqBand3.Value = 128;
            // 
            // tkbEqBand4
            // 
            this.tkbEqBand4.Location = new System.Drawing.Point(131, 17);
            this.tkbEqBand4.Maximum = 168;
            this.tkbEqBand4.Minimum = 88;
            this.tkbEqBand4.Name = "tkbEqBand4";
            this.tkbEqBand4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkbEqBand4.Size = new System.Drawing.Size(45, 104);
            this.tkbEqBand4.TabIndex = 3;
            this.tkbEqBand4.Value = 128;
            // 
            // tkbEqBand5
            // 
            this.tkbEqBand5.Location = new System.Drawing.Point(173, 17);
            this.tkbEqBand5.Maximum = 168;
            this.tkbEqBand5.Minimum = 88;
            this.tkbEqBand5.Name = "tkbEqBand5";
            this.tkbEqBand5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkbEqBand5.Size = new System.Drawing.Size(45, 104);
            this.tkbEqBand5.TabIndex = 4;
            this.tkbEqBand5.Value = 128;
            // 
            // tkbZoneVolume
            // 
            this.tkbZoneVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbZoneVolume.Location = new System.Drawing.Point(4, 37);
            this.tkbZoneVolume.Maximum = 200;
            this.tkbZoneVolume.Name = "tkbZoneVolume";
            this.tkbZoneVolume.Size = new System.Drawing.Size(220, 45);
            this.tkbZoneVolume.TabIndex = 2;
            this.tkbZoneVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkbZoneVolume.Value = 200;
            this.tkbZoneVolume.Scroll += new System.EventHandler(this.tkbZoneVolume_Scroll);
            // 
            // lblVolumeLevelVal
            // 
            this.lblVolumeLevelVal.AutoSize = true;
            this.lblVolumeLevelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeLevelVal.Location = new System.Drawing.Point(91, 21);
            this.lblVolumeLevelVal.Name = "lblVolumeLevelVal";
            this.lblVolumeLevelVal.Size = new System.Drawing.Size(58, 13);
            this.lblVolumeLevelVal.TabIndex = 1;
            this.lblVolumeLevelVal.Text = "unknown";
            // 
            // lblVolumeLevel
            // 
            this.lblVolumeLevel.AutoSize = true;
            this.lblVolumeLevel.Location = new System.Drawing.Point(13, 21);
            this.lblVolumeLevel.Name = "lblVolumeLevel";
            this.lblVolumeLevel.Size = new System.Drawing.Size(72, 13);
            this.lblVolumeLevel.TabIndex = 0;
            this.lblVolumeLevel.Text = "Zone volume:";
            // 
            // lblBassLevelVal
            // 
            this.lblBassLevelVal.AutoSize = true;
            this.lblBassLevelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBassLevelVal.Location = new System.Drawing.Point(54, 85);
            this.lblBassLevelVal.Name = "lblBassLevelVal";
            this.lblBassLevelVal.Size = new System.Drawing.Size(58, 13);
            this.lblBassLevelVal.TabIndex = 4;
            this.lblBassLevelVal.Text = "unknown";
            // 
            // lblBass
            // 
            this.lblBass.AutoSize = true;
            this.lblBass.Location = new System.Drawing.Point(13, 85);
            this.lblBass.Name = "lblBass";
            this.lblBass.Size = new System.Drawing.Size(33, 13);
            this.lblBass.TabIndex = 3;
            this.lblBass.Text = "Bass:";
            // 
            // tkbBassLevel
            // 
            this.tkbBassLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbBassLevel.Location = new System.Drawing.Point(4, 101);
            this.tkbBassLevel.Maximum = 168;
            this.tkbBassLevel.Minimum = 88;
            this.tkbBassLevel.Name = "tkbBassLevel";
            this.tkbBassLevel.Size = new System.Drawing.Size(220, 45);
            this.tkbBassLevel.TabIndex = 5;
            this.tkbBassLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkbBassLevel.Value = 128;
            this.tkbBassLevel.Scroll += new System.EventHandler(this.tkbBassLevel_Scroll);
            // 
            // lblTrebleLevelVal
            // 
            this.lblTrebleLevelVal.AutoSize = true;
            this.lblTrebleLevelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrebleLevelVal.Location = new System.Drawing.Point(54, 149);
            this.lblTrebleLevelVal.Name = "lblTrebleLevelVal";
            this.lblTrebleLevelVal.Size = new System.Drawing.Size(58, 13);
            this.lblTrebleLevelVal.TabIndex = 7;
            this.lblTrebleLevelVal.Text = "unknown";
            // 
            // tkbTrebleLevel
            // 
            this.tkbTrebleLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbTrebleLevel.Location = new System.Drawing.Point(4, 165);
            this.tkbTrebleLevel.Maximum = 168;
            this.tkbTrebleLevel.Minimum = 88;
            this.tkbTrebleLevel.Name = "tkbTrebleLevel";
            this.tkbTrebleLevel.Size = new System.Drawing.Size(220, 45);
            this.tkbTrebleLevel.TabIndex = 8;
            this.tkbTrebleLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkbTrebleLevel.Value = 128;
            this.tkbTrebleLevel.Scroll += new System.EventHandler(this.tkbTrebleLevel_Scroll);
            // 
            // cbStereoMixdownMode
            // 
            this.cbStereoMixdownMode.FormattingEnabled = true;
            this.cbStereoMixdownMode.Items.AddRange(new object[] {
            "No input",
            "Component 1",
            "Component 2",
            "Component 3",
            "Component 4",
            "Component 5",
            "Component 6",
            "Component 7",
            "Component 8",
            "Composite 1",
            "Composite 2",
            "Composite 3"});
            this.cbStereoMixdownMode.Location = new System.Drawing.Point(95, 376);
            this.cbStereoMixdownMode.Name = "cbStereoMixdownMode";
            this.cbStereoMixdownMode.Size = new System.Drawing.Size(122, 21);
            this.cbStereoMixdownMode.TabIndex = 11;
            // 
            // lblStereoMixdownMode
            // 
            this.lblStereoMixdownMode.AutoSize = true;
            this.lblStereoMixdownMode.Location = new System.Drawing.Point(7, 379);
            this.lblStereoMixdownMode.Name = "lblStereoMixdownMode";
            this.lblStereoMixdownMode.Size = new System.Drawing.Size(82, 13);
            this.lblStereoMixdownMode.TabIndex = 10;
            this.lblStereoMixdownMode.Text = "Stereo mixdown";
            // 
            // cbDigitalRouteOption
            // 
            this.cbDigitalRouteOption.FormattingEnabled = true;
            this.cbDigitalRouteOption.Items.AddRange(new object[] {
            "No input",
            "Component 1",
            "Component 2",
            "Component 3",
            "Component 4",
            "Component 5",
            "Component 6",
            "Component 7",
            "Component 8",
            "Composite 1",
            "Composite 2",
            "Composite 3"});
            this.cbDigitalRouteOption.Location = new System.Drawing.Point(95, 403);
            this.cbDigitalRouteOption.Name = "cbDigitalRouteOption";
            this.cbDigitalRouteOption.Size = new System.Drawing.Size(124, 21);
            this.cbDigitalRouteOption.TabIndex = 13;
            // 
            // lblDigitalRoute
            // 
            this.lblDigitalRoute.AutoSize = true;
            this.lblDigitalRoute.Location = new System.Drawing.Point(7, 406);
            this.lblDigitalRoute.Name = "lblDigitalRoute";
            this.lblDigitalRoute.Size = new System.Drawing.Size(63, 13);
            this.lblDigitalRoute.TabIndex = 12;
            this.lblDigitalRoute.Text = "Digital route";
            // 
            // lblZoneName
            // 
            this.lblZoneName.AutoSize = true;
            this.lblZoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoneName.Location = new System.Drawing.Point(48, 4);
            this.lblZoneName.Name = "lblZoneName";
            this.lblZoneName.Size = new System.Drawing.Size(19, 20);
            this.lblZoneName.TabIndex = 1;
            this.lblZoneName.Text = "?";
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZone.Location = new System.Drawing.Point(2, 4);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(40, 20);
            this.lblZone.TabIndex = 0;
            this.lblZone.Text = "#1 -";
            // 
            // btnChangeAll
            // 
            this.btnChangeAll.Location = new System.Drawing.Point(131, 431);
            this.btnChangeAll.Name = "btnChangeAll";
            this.btnChangeAll.Size = new System.Drawing.Size(75, 23);
            this.btnChangeAll.TabIndex = 15;
            this.btnChangeAll.Text = "Change all";
            this.btnChangeAll.UseVisualStyleBackColor = true;
            this.btnChangeAll.Click += new System.EventHandler(this.btnChangeAll_Click);
            // 
            // btnReadAll
            // 
            this.btnReadAll.Location = new System.Drawing.Point(50, 431);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(75, 23);
            this.btnReadAll.TabIndex = 14;
            this.btnReadAll.Text = "Read all";
            this.btnReadAll.UseVisualStyleBackColor = true;
            this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
            // 
            // gb
            // 
            this.gb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb.Controls.Add(this.gbEqualizer);
            this.gb.Controls.Add(this.btnChangeAll);
            this.gb.Controls.Add(this.lblVolumeLevel);
            this.gb.Controls.Add(this.btnReadAll);
            this.gb.Controls.Add(this.lblVolumeLevelVal);
            this.gb.Controls.Add(this.cbDigitalRouteOption);
            this.gb.Controls.Add(this.lblBassLevelVal);
            this.gb.Controls.Add(this.lblDigitalRoute);
            this.gb.Controls.Add(this.tkbTrebleLevel);
            this.gb.Controls.Add(this.cbStereoMixdownMode);
            this.gb.Controls.Add(this.lblTreble);
            this.gb.Controls.Add(this.lblStereoMixdownMode);
            this.gb.Controls.Add(this.lblTrebleLevelVal);
            this.gb.Controls.Add(this.tkbZoneVolume);
            this.gb.Controls.Add(this.tkbBassLevel);
            this.gb.Controls.Add(this.lblBass);
            this.gb.Location = new System.Drawing.Point(0, 31);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(227, 460);
            this.gb.TabIndex = 2;
            this.gb.TabStop = false;
            this.gb.Text = "Audio controls";
            // 
            // lblTreble
            // 
            this.lblTreble.AutoSize = true;
            this.lblTreble.Location = new System.Drawing.Point(13, 149);
            this.lblTreble.Name = "lblTreble";
            this.lblTreble.Size = new System.Drawing.Size(40, 13);
            this.lblTreble.TabIndex = 6;
            this.lblTreble.Text = "Treble:";
            // 
            // AudioSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.lblZoneName);
            this.Name = "AudioSettingsControl";
            this.Size = new System.Drawing.Size(227, 491);
            this.gbEqualizer.ResumeLayout(false);
            this.gbEqualizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEqBand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEqBand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEqBand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEqBand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEqBand5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbZoneVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBassLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrebleLevel)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEqualizer;
        private System.Windows.Forms.TrackBar tkbEqBand1;
        private System.Windows.Forms.TrackBar tkbEqBand2;
        private System.Windows.Forms.TrackBar tkbEqBand3;
        private System.Windows.Forms.TrackBar tkbEqBand4;
        private System.Windows.Forms.TrackBar tkbZoneVolume;
        private System.Windows.Forms.Label lblVolumeLevelVal;
        private System.Windows.Forms.Label lblVolumeLevel;
        private System.Windows.Forms.Label lblBassLevelVal;
        private System.Windows.Forms.Label lblBass;
        private System.Windows.Forms.TrackBar tkbBassLevel;
        private System.Windows.Forms.Label lblTrebleLevelVal;
        private System.Windows.Forms.TrackBar tkbTrebleLevel;
        private System.Windows.Forms.ComboBox cbStereoMixdownMode;
        private System.Windows.Forms.Label lblStereoMixdownMode;
        private System.Windows.Forms.ComboBox cbDigitalRouteOption;
        private System.Windows.Forms.Label lblDigitalRoute;
        private System.Windows.Forms.Label lblZoneName;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.Button btnChangeAll;
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.TrackBar tkbEqBand5;
        private System.Windows.Forms.Label lbl10kHz;
        private System.Windows.Forms.Label lbl3kHz;
        private System.Windows.Forms.Label lbl1kHz;
        private System.Windows.Forms.Label lbl330Hz;
        private System.Windows.Forms.Label lbl100Hz;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lblTreble;
        private System.Windows.Forms.Button btnFlatten;
    }
}
