using System.Windows.Forms;

namespace Zektor {
    public partial class ZoneMapControl : UserControl {
        private ZoneMapControl() {
            InitializeComponent();
        }

        public ZoneMapControl(int i) : this() {
            this.Zone = i;
        }

        public int Zone {
            get;
            set;
        }
    }
}
