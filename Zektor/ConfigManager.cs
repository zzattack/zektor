using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Zektor.Shared.DataSources;

namespace Zektor {
    public static class ConfigManager {
        private static readonly string SettingsDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Zektor");
        private static readonly string SettingsFile = Path.Combine(SettingsDir, "zektor_controller_settings.xml");
        public static string Email { get; set; } = "nobody@nothing.net";
        public static Size WindowSize { get; set; }
        public static DataSource DataSource { get; set; }
        public static bool ReadConfigAfterConnect { get; set; } = true;
        public static bool LogPanelExpanded { get; set; }
        public static readonly NameMapping NameMapping = new NameMapping();

        #region Xml serialization
        public static void Load() {
            try {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(SettingsFile);
                XmlElement xroot = xdoc["settings"] ?? xdoc["root"];

                // first load the simplest properties
                if (xroot["Email"] != null)
                    Email = xroot["Email"].InnerText;

                if (xroot["DataSource"] != null)
                    DataSource = DataSourceFactory.CreateFrom(xroot["DataSource"]);

                if (xroot["ReadConfigAfterConnect"] != null)
                    ReadConfigAfterConnect = bool.Parse(xroot["ReadConfigAfterConnect"].InnerText);

                if (xroot["LogPanelExpanded"] != null)
                    LogPanelExpanded = bool.Parse(xroot["LogPanelExpanded"].InnerText);

                if (xroot["WindowSize"] != null) {
                    string size = xroot["WindowSize"].InnerText;
                    WindowSize = new Size(int.Parse(size.Substring(0, size.IndexOf("x"))), int.Parse(size.Substring(size.IndexOf("x") + 1)));
                }

                if (xroot["NameMapping"] != null)
                    NameMapping.LoadFrom(xroot["NameMapping"]);
            }
            catch { }

            Sanitize();
        }

        public static void Save() {
            try {
                Directory.CreateDirectory(SettingsDir);
                var ms = new MemoryStream();
                var xw = new XmlTextWriter(ms, Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                xw.WriteStartDocument();
                xw.WriteStartElement("settings");

                DataSource?.WriteTo(xw);
                NameMapping.WriteTo(xw);
                xw.WriteElementString("ReadConfigAfterConnect", ReadConfigAfterConnect.ToString());
                xw.WriteElementString("LogPanelExpanded", LogPanelExpanded.ToString());
                xw.WriteElementString("WindowSize", $"{WindowSize.Width}x{WindowSize.Height}");

                xw.WriteEndElement(); // settings
                xw.WriteEndDocument();
                xw.Flush();
                xw.Close();

                File.WriteAllBytes(SettingsFile, ms.ToArray());
                ms.Dispose();
            }
            catch (IOException exc) {
                MessageBox.Show("IO Error while saving: " + exc);
            }
            catch (XmlException exc) {
                MessageBox.Show("XML Error while saving: " + exc);
            }
            catch (Exception exc) {
                MessageBox.Show("Unknown Error while saving: " + exc);
            }
        }
        private static void Sanitize() {

        }

        #endregion

    }

}
