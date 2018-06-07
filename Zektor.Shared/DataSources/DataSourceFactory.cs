using System;
using System.IO;
using System.Xml;

namespace Zektor.Shared.DataSources {
    public class DataSourceFactory {
        public static DataSource Create(DataSourceType type) {
            switch (type) {
                case DataSourceType.NullSource:
                    return new NullDataSource();
                case DataSourceType.SerialPort:
                    return new SerialPortDataSource();
                case DataSourceType.TcpClient:
                    return new TcpClientDataSource();
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }

        public static DataSource CreateFrom(XmlNode node) {
            if (node == null) return null;
            if (node.Attributes["Type"] == null) return null;

            try {
                var type = (DataSourceType)Enum.Parse(typeof(DataSourceType), node.Attributes["Type"].InnerText);
                var src = Create(type);
                src.LoadFrom(node);
                return src;
            }
            catch (ArgumentException) { }
            catch (FormatException) { }
            catch (IOException) { }

            return null;
        }
    }
}