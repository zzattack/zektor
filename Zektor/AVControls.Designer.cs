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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nudSwitchingDelay = new System.Windows.Forms.NumericUpDown();
            this.lblDelay = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTreble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwitchingDelay)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nudSwitchingDelay);
            this.groupBox1.Controls.Add(this.lblDelay);
            this.groupBox1.Location = new System.Drawing.Point(6, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 140);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Switch delays";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(204, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Set";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(78, 111);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Digital audio";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(78, 82);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Analog audio";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(78, 56);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Video";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nudSwitchingDelay
            // 
            this.nudSwitchingDelay.Location = new System.Drawing.Point(78, 27);
            this.nudSwitchingDelay.Name = "nudSwitchingDelay";
            this.nudSwitchingDelay.Size = new System.Drawing.Size(120, 20);
            this.nudSwitchingDelay.TabIndex = 11;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(8, 29);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(64, 13);
            this.lblDelay.TabIndex = 12;
            this.lblDelay.Text = "All channels";
            // 
            // AVControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "AVControls";
            this.Size = new System.Drawing.Size(477, 476);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTreble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwitchingDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.TrackBar tbBass;
        private System.Windows.Forms.TrackBar tbTreble;
        private System.Windows.Forms.TrackBar Gain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudSwitchingDelay;
        private System.Windows.Forms.Label lblDelay;
    }
}
