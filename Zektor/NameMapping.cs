using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Zektor.Protocol;
using Zektor.Protocol.Annotations;

namespace Zektor {
    public class MapEntry<T> : INotifyPropertyChanged {
        public MapEntry(T key) {
            Key = key;
        }
        public T Key { get; private set; }
        private string _name;

        public string Name {
            get => _name;
            set {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class ZoneMapEntry : MapEntry<int> {
        public ZoneMapEntry(int v) : base(v) { }
    }
    public class VideoInputMapEntry : MapEntry<VideoInputChannel> {
        public VideoInputMapEntry(VideoInputChannel v) : base(v) { }
    }
    public class AudioInputMapEntry : MapEntry<InputChannel> {
        public AudioInputMapEntry(InputChannel v) : base(v) { }
    }

    public class NameMapping {
        public readonly BindingList<ZoneMapEntry> ZoneNames = new BindingList<ZoneMapEntry>();
        public readonly BindingList<VideoInputMapEntry> VideoInputNames = new BindingList<VideoInputMapEntry>();
        public readonly BindingList<AudioInputMapEntry> AudioInputNames = new BindingList<AudioInputMapEntry>();

        public NameMapping() {
            InitDefaults();
        }
        public void InitDefaults() {
            ZoneNames.Clear();
            VideoInputNames.Clear();
            AudioInputNames.Clear();

            for (int i = 1; i <= 8; i++)
                ZoneNames.Add(new ZoneMapEntry(i) { Name = $"Zone {i}" });

            VideoInputNames.Add(new VideoInputMapEntry(VideoInputChannel.None) { Name = "No input" });
            for (var v = VideoInputChannel.Component1; v <= VideoInputChannel.Composite3; v++)
                VideoInputNames.Add(new VideoInputMapEntry(v) { Name = v.ToString() });

            AudioInputNames.Add(new AudioInputMapEntry(InputChannel.None) { Name = "No input" });
            for (var v = InputChannel.Input1; v <= InputChannel.Input8; v++)
                AudioInputNames.Add(new AudioInputMapEntry(v) { Name = v.ToString() });
        }

        public void LoadFrom(XmlElement xnode) {
            foreach (XmlNode zm in xnode["zones"].ChildNodes) {
                int key = int.Parse(zm.Attributes["key"].Value);
                var e = ZoneNames.FirstOrDefault(z => Equals(z.Key, key));
                if (e != null) e.Name = zm.InnerText;
            }
            foreach (XmlNode zm in xnode["video"].ChildNodes) {
                VideoInputChannel key = (VideoInputChannel)int.Parse(zm.Attributes["key"].Value);
                var e = VideoInputNames.FirstOrDefault(z => Equals(z.Key, key));
                if (e != null) e.Name = zm.InnerText;
            }
            foreach (XmlNode zm in xnode["audio"].ChildNodes) {
                InputChannel key = (InputChannel)int.Parse(zm.Attributes["key"].Value);
                var e = AudioInputNames.FirstOrDefault(z => Equals(z.Key, key));
                if (e != null) e.Name = zm.InnerText;
            }
        }

        public void WriteTo(XmlTextWriter xw) {
            xw.WriteStartElement("NameMapping");

            xw.WriteStartElement("zones");
            foreach (var entry in ZoneNames) {
                xw.WriteStartElement("map");
                xw.WriteAttributeString("key", ((int)entry.Key).ToString());
                xw.WriteString(entry.Name);
                xw.WriteEndElement();
            }
            xw.WriteEndElement();

            xw.WriteStartElement("video");
            foreach (var entry in VideoInputNames) {
                xw.WriteStartElement("map");
                xw.WriteAttributeString("key", ((int)entry.Key).ToString());
                xw.WriteString(entry.Name);
                xw.WriteEndElement();
            }
            xw.WriteEndElement();

            xw.WriteStartElement("audio");
            foreach (var entry in AudioInputNames) {
                xw.WriteStartElement("map");
                xw.WriteAttributeString("key", ((int)entry.Key).ToString());
                xw.WriteString(entry.Name);
                xw.WriteEndElement();
            }
            xw.WriteEndElement();

            xw.WriteEndElement();
        }

    }
}
