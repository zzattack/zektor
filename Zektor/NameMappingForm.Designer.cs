namespace Zektor {
    partial class NameMappingForm {
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
            this.components = new System.ComponentModel.Container();
            this.dgvVideo = new System.Windows.Forms.DataGridView();
            this.tables = new System.Windows.Forms.TableLayoutPanel();
            this.pnlZoneMap = new System.Windows.Forms.Panel();
            this.lblZoneNames = new System.Windows.Forms.Label();
            this.dgvZones = new System.Windows.Forms.DataGridView();
            this.pnlVideoMap = new System.Windows.Forms.Panel();
            this.lblVideoInputs = new System.Windows.Forms.Label();
            this.pnlAudioMap = new System.Windows.Forms.Panel();
            this.lblAudioZones = new System.Windows.Forms.Label();
            this.dgvAudio = new System.Windows.Forms.DataGridView();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnRestoreDefaults = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsZoneMap = new System.Windows.Forms.BindingSource(this.components);
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVideoMap = new System.Windows.Forms.BindingSource(this.components);
            this.keyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAudioMap = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideo)).BeginInit();
            this.tables.SuspendLayout();
            this.pnlZoneMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZones)).BeginInit();
            this.pnlVideoMap.SuspendLayout();
            this.pnlAudioMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZoneMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVideoMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAudioMap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVideo
            // 
            this.dgvVideo.AllowUserToAddRows = false;
            this.dgvVideo.AllowUserToDeleteRows = false;
            this.dgvVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVideo.AutoGenerateColumns = false;
            this.dgvVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvVideo.DataSource = this.bsVideoMap;
            this.dgvVideo.Location = new System.Drawing.Point(3, 31);
            this.dgvVideo.Name = "dgvVideo";
            this.dgvVideo.Size = new System.Drawing.Size(272, 317);
            this.dgvVideo.TabIndex = 1;
            // 
            // tables
            // 
            this.tables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tables.ColumnCount = 3;
            this.tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tables.Controls.Add(this.pnlZoneMap, 0, 0);
            this.tables.Controls.Add(this.pnlVideoMap, 1, 0);
            this.tables.Controls.Add(this.pnlAudioMap, 2, 0);
            this.tables.Location = new System.Drawing.Point(12, 12);
            this.tables.Name = "tables";
            this.tables.RowCount = 1;
            this.tables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.tables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.tables.Size = new System.Drawing.Size(855, 357);
            this.tables.TabIndex = 0;
            // 
            // pnlZoneMap
            // 
            this.pnlZoneMap.Controls.Add(this.lblZoneNames);
            this.pnlZoneMap.Controls.Add(this.dgvZones);
            this.pnlZoneMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlZoneMap.Location = new System.Drawing.Point(3, 3);
            this.pnlZoneMap.Name = "pnlZoneMap";
            this.pnlZoneMap.Size = new System.Drawing.Size(278, 351);
            this.pnlZoneMap.TabIndex = 0;
            // 
            // lblZoneNames
            // 
            this.lblZoneNames.AutoSize = true;
            this.lblZoneNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoneNames.Location = new System.Drawing.Point(21, 8);
            this.lblZoneNames.Name = "lblZoneNames";
            this.lblZoneNames.Size = new System.Drawing.Size(98, 20);
            this.lblZoneNames.TabIndex = 0;
            this.lblZoneNames.Text = "Zone names";
            // 
            // dgvZones
            // 
            this.dgvZones.AllowUserToAddRows = false;
            this.dgvZones.AllowUserToDeleteRows = false;
            this.dgvZones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZones.AutoGenerateColumns = false;
            this.dgvZones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvZones.DataSource = this.bsZoneMap;
            this.dgvZones.Location = new System.Drawing.Point(3, 31);
            this.dgvZones.Name = "dgvZones";
            this.dgvZones.Size = new System.Drawing.Size(272, 317);
            this.dgvZones.TabIndex = 1;
            // 
            // pnlVideoMap
            // 
            this.pnlVideoMap.Controls.Add(this.lblVideoInputs);
            this.pnlVideoMap.Controls.Add(this.dgvVideo);
            this.pnlVideoMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVideoMap.Location = new System.Drawing.Point(287, 3);
            this.pnlVideoMap.Name = "pnlVideoMap";
            this.pnlVideoMap.Size = new System.Drawing.Size(279, 351);
            this.pnlVideoMap.TabIndex = 1;
            // 
            // lblVideoInputs
            // 
            this.lblVideoInputs.AutoSize = true;
            this.lblVideoInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoInputs.Location = new System.Drawing.Point(21, 8);
            this.lblVideoInputs.Name = "lblVideoInputs";
            this.lblVideoInputs.Size = new System.Drawing.Size(141, 20);
            this.lblVideoInputs.TabIndex = 0;
            this.lblVideoInputs.Text = "Video input names";
            // 
            // pnlAudioMap
            // 
            this.pnlAudioMap.Controls.Add(this.lblAudioZones);
            this.pnlAudioMap.Controls.Add(this.dgvAudio);
            this.pnlAudioMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAudioMap.Location = new System.Drawing.Point(572, 3);
            this.pnlAudioMap.Name = "pnlAudioMap";
            this.pnlAudioMap.Size = new System.Drawing.Size(280, 351);
            this.pnlAudioMap.TabIndex = 2;
            // 
            // lblAudioZones
            // 
            this.lblAudioZones.AutoSize = true;
            this.lblAudioZones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudioZones.Location = new System.Drawing.Point(21, 8);
            this.lblAudioZones.Name = "lblAudioZones";
            this.lblAudioZones.Size = new System.Drawing.Size(141, 20);
            this.lblAudioZones.TabIndex = 0;
            this.lblAudioZones.Text = "Audio input names";
            // 
            // dgvAudio
            // 
            this.dgvAudio.AllowUserToAddRows = false;
            this.dgvAudio.AllowUserToDeleteRows = false;
            this.dgvAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAudio.AutoGenerateColumns = false;
            this.dgvAudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dgvAudio.DataSource = this.bsAudioMap;
            this.dgvAudio.Location = new System.Drawing.Point(3, 31);
            this.dgvAudio.Name = "dgvAudio";
            this.dgvAudio.Size = new System.Drawing.Size(272, 317);
            this.dgvAudio.TabIndex = 1;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(785, 375);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(76, 26);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnRestoreDefaults
            // 
            this.btnRestoreDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestoreDefaults.Location = new System.Drawing.Point(18, 375);
            this.btnRestoreDefaults.Name = "btnRestoreDefaults";
            this.btnRestoreDefaults.Size = new System.Drawing.Size(116, 26);
            this.btnRestoreDefaults.TabIndex = 1;
            this.btnRestoreDefaults.Text = "Restore defaults";
            this.btnRestoreDefaults.UseVisualStyleBackColor = true;
            this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Key";
            this.dataGridViewTextBoxColumn3.HeaderText = "Key";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bsZoneMap
            // 
            this.bsZoneMap.DataSource = typeof(Zektor.ZoneMapEntry);
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "Key";
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            this.keyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // bsVideoMap
            // 
            this.bsVideoMap.DataSource = typeof(Zektor.VideoInputMapEntry);
            // 
            // keyDataGridViewTextBoxColumn1
            // 
            this.keyDataGridViewTextBoxColumn1.DataPropertyName = "Key";
            this.keyDataGridViewTextBoxColumn1.HeaderText = "Key";
            this.keyDataGridViewTextBoxColumn1.Name = "keyDataGridViewTextBoxColumn1";
            this.keyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // bsAudioMap
            // 
            this.bsAudioMap.DataSource = typeof(Zektor.AudioInputMapEntry);
            // 
            // NameMappingForm
            // 
            this.AcceptButton = this.btnDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 413);
            this.Controls.Add(this.btnRestoreDefaults);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.tables);
            this.Name = "NameMappingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zone/input naming";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideo)).EndInit();
            this.tables.ResumeLayout(false);
            this.pnlZoneMap.ResumeLayout(false);
            this.pnlZoneMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZones)).EndInit();
            this.pnlVideoMap.ResumeLayout(false);
            this.pnlVideoMap.PerformLayout();
            this.pnlAudioMap.ResumeLayout(false);
            this.pnlAudioMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZoneMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVideoMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAudioMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideo;
        private System.Windows.Forms.TableLayoutPanel tables;
        private System.Windows.Forms.Panel pnlZoneMap;
        private System.Windows.Forms.Panel pnlAudioMap;
        private System.Windows.Forms.Panel pnlVideoMap;
        private System.Windows.Forms.BindingSource bsVideoMap;
        private System.Windows.Forms.Label lblZoneNames;
        private System.Windows.Forms.DataGridView dgvZones;
        private System.Windows.Forms.BindingSource bsZoneMap;
        private System.Windows.Forms.Label lblAudioZones;
        private System.Windows.Forms.DataGridView dgvAudio;
        private System.Windows.Forms.BindingSource bsAudioMap;
        private System.Windows.Forms.Label lblVideoInputs;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnRestoreDefaults;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    }
}