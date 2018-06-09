namespace Zektor {
    partial class LipSyncZoneControl {
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
            this.lblDelayVal = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.tkbDelay = new System.Windows.Forms.TrackBar();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.lblZoneIdx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDelayVal
            // 
            this.lblDelayVal.AutoSize = true;
            this.lblDelayVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelayVal.Location = new System.Drawing.Point(143, 13);
            this.lblDelayVal.Name = "lblDelayVal";
            this.lblDelayVal.Size = new System.Drawing.Size(58, 13);
            this.lblDelayVal.TabIndex = 3;
            this.lblDelayVal.Text = "unknown";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(4, 25);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(4, 50);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tkbDelay
            // 
            this.tkbDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbDelay.Location = new System.Drawing.Point(85, 32);
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
            this.lblDelay.Location = new System.Drawing.Point(100, 13);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(37, 13);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay:";
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZone.Location = new System.Drawing.Point(3, 2);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(50, 20);
            this.lblZone.TabIndex = 0;
            this.lblZone.Text = "Zone";
            // 
            // lblZoneIdx
            // 
            this.lblZoneIdx.AutoSize = true;
            this.lblZoneIdx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoneIdx.Location = new System.Drawing.Point(59, 2);
            this.lblZoneIdx.Name = "lblZoneIdx";
            this.lblZoneIdx.Size = new System.Drawing.Size(19, 20);
            this.lblZoneIdx.TabIndex = 1;
            this.lblZoneIdx.Text = "?";
            // 
            // LipSyncZoneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDelayVal);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tkbDelay);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.lblZoneIdx);
            this.Name = "LipSyncZoneControl";
            this.Size = new System.Drawing.Size(240, 78);
            ((System.ComponentModel.ISupportInitialize)(this.tkbDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelayVal;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TrackBar tkbDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.Label lblZoneIdx;
    }
}
