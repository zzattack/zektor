using System.Windows.Forms;
using Zektor.Shared.DataSources;

namespace Zektor {
    public partial class ConnectionSetupForm : Form {
        private ConnectionSetupForm() {
            InitializeComponent();
        }

        public ConnectionSetupForm(DataSource ds) : this() { }

        public DataSource DataSource {
            get; set;
        }
    }
}
