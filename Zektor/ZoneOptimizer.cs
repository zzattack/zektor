using System.Collections.Generic;
using Zektor.Protocol;

namespace Zektor {
    public static class ZoneOptimizer<T,U> where T : MultiZoneCommand<U>, new() {

        public static List<T> OptimizeChannelBasedParameter(int zoneIndex, bool splitAudio, U video, U analogAudio, U digitalAudio) {
            var mz = new List<T>();

            // first make zone for video channel
            var videoZone = new T();
            T audioZone = null;

            videoZone.Channels = ChannelBitmap.YPbPrVideo;
            (HashSet<int>, U) tup = (new HashSet<int> { zoneIndex }, video);
            videoZone.Zones.Add(tup);
            mz.Add(videoZone);

            if (video.Equals(analogAudio)) {
                // audio and video index is similar, so just update bitmap
                videoZone.Channels |= ChannelBitmap.AnalogAudio;
            }
            else {
                audioZone = new T();
                // analog audio will require unique line
                audioZone.Channels = ChannelBitmap.AnalogAudio;
                tup = (new HashSet<int> { zoneIndex }, analogAudio);
                audioZone.Zones.Add(tup);
                mz.Add(audioZone);
            }

            // only if using classic mode, it may be possible to specify another digital audio source
            if (splitAudio) {
                // see if digital audio matches video channel
                if (digitalAudio.Equals(video))
                    videoZone.Channels |= ChannelBitmap.DigitalAudio;

                else if (audioZone != null && digitalAudio.Equals(analogAudio))
                    audioZone.Channels |= ChannelBitmap.DigitalAudio;

                else {
                    // also need unique command for digital audio
                    var digiZone = new T();
                    digiZone.Channels = ChannelBitmap.DigitalAudio;
                    tup = (new HashSet<int> { zoneIndex }, digitalAudio);
                    digiZone.Zones.Add(tup);
                    mz.Add(digiZone);
                }
            }
            return mz;
        }

    }
}