using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using SPAA05.Shared.DataSources;
using SPAA05.Shared.Protocol;
using SPAA05.Shared.UI.ColorLoggers;
using SPAA05.Shared.Utility;
using Zektor.Command;
using Zektor.Control;
using Zektor.Control.Audio;
using Zektor.Control.Basic;

namespace Zektor {
    public partial class MainForm : Form {
        private DataSource ds = new TcpClientDataSource("10.31.45.57", 50005);
        private ZektorProtocol proto = new ZektorProtocol();
        private GenericColorLogger<ZektorCommand> logger = new ZektorLogger();

        public MainForm() {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
                flowLayout.Controls.Add(new ZoneMapControl(i+1));

            logger.Window = this.fctbLog;
            logger.Attach(proto);
            logger.ShowBogus = true;
            logger.ForceHEX = true;
            proto.Attach(ds);

            proto.LineReceived += ProtoOnLineReceived;
            ds.ConnectionEstablished += OnConnect;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            ds.Start();
        }

        private void OnConnect(object sender, EventArgs e) {
            // query everthing we want to know
            proto.Write(new PowerControl { IsQueryRequest = true });

            // query zones 1-8
            proto.Write(new SetZone {
                IsQueryRequest = true,
                Channels = ChannelBitmap.All,
                Zones = { (new HashSet<int>(new Range(1, 8).Flatten()), InputChannel.None) },
            });
            proto.Write(new MuteZones {
                IsQueryRequest = true,
                Channels = ChannelBitmap.All,
                Zones = { (new HashSet<int>(new Range(1, 8).Flatten()), MuteOption.None) },
            });
            proto.Write(new MasterVolume {
                IsQueryRequest = true,
            });
            proto.Write(new ZoneVolumeAdjust {
                IsQueryRequest = true,
                Zones = { (new HashSet<int>(new Range(1, 8).Flatten()), null) },
            });
            proto.Write(new MixDownStereo {
                IsQueryRequest = true,
                Zones = { (new HashSet<int>(new Range(1, 8).Flatten()), StereoMixDownMode.NoChange) },
            });
            proto.Write(new DigitalRoute {
                IsQueryRequest = true,
                Zones = { (new HashSet<int>(new Range(1, 8).Flatten()), DigitalRouteOption.AsIs) },
            });


        }

        private void ProtoOnLineReceived(object sender, LineTransmitEventArgs<ZektorCommand> e) {
            Debug.WriteLine("Received line of type " + e.Line.GetType());
        }

        private void tooltip_Popup(object sender, PopupEventArgs e) {
            
        }

        #region ExtendedSettings clicks
        private void pbXS_ASY_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_ACK_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_ECO_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_CHM_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_CRE_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_CSE_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_SET_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_CHS_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_KYE_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_IRE_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_IRS_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_IRJ_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_KYD_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_AUT_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_VMU_Click(object sender, System.EventArgs e) {

        }

        private void pbXS_AMU_Click(object sender, System.EventArgs e) {

        }

        #endregion

    }
}
