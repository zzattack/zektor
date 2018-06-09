namespace Zektor {
    partial class LipSyncInputControl {
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblInputIdx = new System.Windows.Forms.Label();
            this.lblDelayVal = new System.Windows.Forms.Label();
            this.btnReadMasterVolume = new System.Windows.Forms.Button();
            this.btnChangeMasterVolume = new System.Windows.Forms.Button();
            this.tkbDelay = new System.Windows.Forms.TrackBar();
            this.lblDelay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(3, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(50, 20);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Zone";
            // 
            // lblInputIdx
            // 
            this.lblInputIdx.AutoSize = true;
            this.lblInputIdx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputIdx.Location = new System.Drawing.Point(59, 0);
            this.lblInputIdx.Name = "lblInputIdx";
            this.lblInputIdx.Size = new System.Drawing.Size(19, 20);
            this.lblInputIdx.TabIndex = 1;
            this.lblInputIdx.Text = "?";
            // 
            // lblDelayVal
            // 
            this.lblDelayVal.AutoSize = true;
            this.lblDelayVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelayVal.Location = new System.Drawing.Point(143, 11);
            this.lblDelayVal.Name = "lblDelayVal";
            this.lblDelayVal.Size = new System.Drawing.Size(58, 13);
            this.lblDelayVal.TabIndex = 3;
            this.lblDelayVal.Text = "unknown";
            // 
            // btnReadMasterVolume
            // 
            this.btnReadMasterVolume.Location = new System.Drawing.Point(4, 23);
            this.btnReadMasterVolume.Name = "btnReadMasterVolume";
            this.btnReadMasterVolume.Size = new System.Drawing.Size(75, 23);
            this.btnReadMasterVolume.TabIndex = 4;
            this.btnReadMasterVolume.Text = "Read";
            this.btnReadMasterVolume.UseVisualStyleBackColor = true;
            this.btnReadMasterVolume.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnChangeMasterVolume
            // 
            this.btnChangeMasterVolume.Location = new System.Drawing.Point(4, 48);
            this.btnChangeMasterVolume.Name = "btnChangeMasterVolume";
            this.btnChangeMasterVolume.Size = new System.Drawing.Size(75, 23);
            this.btnChangeMasterVolume.TabIndex = 5;
            this.btnChangeMasterVolume.Text = "Change";
            this.btnChangeMasterVolume.UseVisualStyleBackColor = true;
            this.btnChangeMasterVolume.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tkbDelay
            // 
            this.tkbDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbDelay.Location = new System.Drawing.Point(85, 30);
            this.tkbDelay.Maximum = 8191;
            this.tkbDelay.Name = "tkbDelay";
            this.tkbDelay.Size = new System.Drawing.Size(152, 45);
            this.tkbDelay.TabIndex = 6;
            this.tkbDelay.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkbDelay.Scroll += new System.EventHandler(this.tkbDelay_Scroll);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(100, 11);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(37, 13);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay:";
            // 
            // LipSyncInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDelayVal);
            this.Controls.Add(this.btnReadMasterVolume);
            this.Controls.Add(this.btnChangeMasterVolume);
            this.Controls.Add(this.tkbDelay);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblInputIdx);
            this.Name = "LipSyncInputControl";
            this.Size = new System.Drawing.Size(240, 78);
            ((System.ComponentModel.ISupportInitialize)(this.tkbDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblInputIdx;
        private System.Windows.Forms.Label lblDelayVal;
        private System.Windows.Forms.Button btnReadMasterVolume;
        private System.Windows.Forms.Button btnChangeMasterVolume;
        private System.Windows.Forms.TrackBar tkbDelay;
        private System.Windows.Forms.Label lblDelay;
    }
}
