using System.Windows.Forms;

namespace Zektor {
    public partial class NameMappingForm : Form {
        public NameMappingForm() {
            InitializeComponent();

            bsZoneMap.DataSource = ConfigManager.NameMapping.ZoneNames;
            bsVideoMap.DataSource = ConfigManager.NameMapping.VideoInputNames;
            bsAudioMap.DataSource = ConfigManager.NameMapping.AudioInputNames;
        }

        private void btnRestoreDefaults_Click(object sender, System.EventArgs e) {
            ConfigManager.NameMapping.InitDefaults();
        }
    }
}
