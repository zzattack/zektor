namespace Zektor.Protocol.Audio {
    public abstract class LevelAdjustCommand : MultiZoneCommand<LevelAdjustment> {
        protected override string Command => "VZ";
        protected override string FormatParam(LevelAdjustment param) {
            if (param.AdjustMode == VolumeAdjust.Offset) {
                if (param.Adjustment > 0) return $"+{param.Adjustment}";
                else return $"{param.Adjustment}";
            }
            else return $"{param.Adjustment}";
        }

        protected override LevelAdjustment ParseParam(string str) {
            LevelAdjustment ret = new LevelAdjustment();
            if (str[0] == '+') {
                ret.AdjustMode = VolumeAdjust.Offset;
                ret.Adjustment = int.Parse(str.Substring(1));
            }
            else if (str[0] == '-') {
                ret.AdjustMode = VolumeAdjust.Offset;
                ret.Adjustment = int.Parse(str);
            }
            else {
                ret.Adjustment = int.Parse(str);
            }
            return ret;
        }
    }

    public class LevelAdjustment {
        public VolumeAdjust AdjustMode { get; set; } = VolumeAdjust.Absolute;
        public int Adjustment { get; set; }
    }

    public class ZoneVolumeAdjust : LevelAdjustCommand {
        protected override string Command => "VZ";
    }
    public class BassLevelAdjust : LevelAdjustCommand {
        protected override string Command => "BAZ";
    }
    public class TrebleLevelAdjust : LevelAdjustCommand {
        protected override string Command => "TRZ";
    }
    public class Eq1z : LevelAdjustCommand {
        // 100Hz band
        protected override string Command => "EQ1Z";
    }
    public class Eq2z : LevelAdjustCommand {
        // 330Hz band
        protected override string Command => "EQ2Z";
    }
    public class Eq3z : LevelAdjustCommand {
        // 1kHz band
        protected override string Command => "EQ3Z";
    }
    public class Eq4z : LevelAdjustCommand {
        // 3.3kHz band
        protected override string Command => "EQ4Z";
    }
    public class Eq5z : LevelAdjustCommand {
        // 10kHz band
        protected override string Command => "EQ5Z";
    }

}