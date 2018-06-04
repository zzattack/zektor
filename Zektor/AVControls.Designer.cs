namespace Zektor.Command {
    partial class AVControls {
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.tbBass = new System.Windows.Forms.TrackBar();
            this.tbTreble = new System.Windows.Forms.TrackBar();
            this.Gain = new System.Windows.Forms.TrackBar();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTreble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbVolume);
            this.groupBox2.Controls.Add(this.tbBass);
            this.groupBox2.Controls.Add(this.tbTreble);
            this.groupBox2.Controls.Add(this.Gain);
            this.groupBox2.Location = new System.Drawing.Point(6, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 139);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equalizer";
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(21, 19);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(45, 104);
            this.tbVolume.TabIndex = 6;
            // 
            // tbBass
            // 
            this.tbBass.Location = new System.Drawing.Point(72, 19);
            this.tbBass.Name = "tbBass";
            this.tbBass.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbBass.Size = new System.Drawing.Size(45, 104);
            this.tbBass.TabIndex = 7;
            // 
            // tbTreble
            // 
            this.tbTreble.Location = new System.Drawing.Point(123, 19);
            this.tbTreble.Name = "tbTreble";
            this.tbTreble.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbTreble.Size = new System.Drawing.Size(45, 104);
            this.tbTreble.TabIndex = 8;
            // 
            // Gain
            // 
            this.Gain.Location = new System.Drawing.Point(174, 19);
            this.Gain.Name = "Gain";
            this.Gain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Gain.Size = new System.Drawing.Size(45, 104);
            this.Gain.TabIndex = 9;
            // 
            // AVControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "AVControls";
            this.Size = new System.Drawing.Size(268, 283);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTreble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.TrackBar tbBass;
        private System.Windows.Forms.TrackBar tbTreble;
        private System.Windows.Forms.TrackBar Gain;
    }
}
