using System.Windows.Forms;

namespace Zektor {
    public partial class NameMappingForm : Form {
        public NameMappingForm() {
            InitializeComponent();

            // fix ms issue
            dgvVideo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAudio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvZones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            bsZoneMap.DataSource = ConfigManager.NameMapping.ZoneNames;
            bsVideoMap.DataSource = ConfigManager.NameMapping.VideoInputNames;
            bsAudioMap.DataSource = ConfigManager.NameMapping.AudioInputNames;

            this.Load += (sender, args) => {
                this.dgvVideo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dgvAudio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dgvZones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            };
        }

        private void btnRestoreDefaults_Click(object sender, System.EventArgs e) {
            ConfigManager.NameMapping.InitDefaults();
        }

        private void btnDone_Click(object sender, System.EventArgs e) {
            Close();
        }
    }
}
