using System;

namespace Zektor.Protocol {

    public enum PowerState {
        PowerOff = '0',
        PowerOn = '1',
        Toggle = '+',
        None
    }
    public enum MuteOption {
        NonMuted = '0',
        Muted = '1',
        Toggle = '+',
        None
    }

    public enum VolumeAdjust {
        Absolute,
        Offset
    }
    public enum StereoMixDownMode {
        NoChange = 0, // No change to audio.
        SwapLeftRight = 1, // Swap left and right channels.
        AddLeftAndRight = 2, // Mix to mono by adding left and right channels.
        UseLeftForBoth = 3, // Mix to mono by using the left channel for both outputs.
        UseRightForBoth = 4, // Mix to mono by using the right channel for both outputs.
        SubtractRightFromLeft = 5, // Mix to mono by subtracting the right channel from the left.
        SubtractLeftFromRight = 6, // Mix to mono by subtracting the left channel from the right.
    }

    public enum DigitalRouteOption {
        AsIs = 0, // Non-PCM audio is routed, as-is, to the digital output.
        RouteAnalogToDigital = 1, // Converted analog audio is routed to the digital output.
    }

    public enum ErrorCode {
        NoError = 0,
        UnrecognizedCommand = 1,
        ParameterOutOfRange = 2,
        SyntaxError = 3,
        ChecksumError = 4,
        WrongParameterCount = 5,
        DeviceBusy = 6,
        BufferOverflow = 7,
        InvalidState = 8,
    }

    public enum LightingMode {
        Off = 0,
        Dim = 1,
        Bright = 2,
        AutoDim = 3,
    }
    public enum EnableState {
        Disabled = '0',
        Enabled = '1',
        Toggle = '+',
    }
    public enum BitState {
        Disable = '-',
        Enable = '+',
        None
    }

    [Flags]
    public enum QueryFlags {
        PWR = 1, // Power State has changed
        QSZ = 2, // Selection (Source / Zone Mapping) has changed, use the ‘QSZ’ command for more granularity
        QMZ = 4, // Mute settings have changed, use the ‘QMZ’ command for more granularity
        QDZ = 8, // Switching delay settings have changed, use the ‘QDZ’ command for more granularity
        KEY = 16, // One or more keys have been pressed
        IRR = 32, // A new IR code has been received
        LMI = 64, // Light mode and / or intensities have changed
        CTL = 128, // Control settings have changed
        KYE = 256, // Keycode enabled’ mask has changed
    }

    [Flags]
    public enum ZoneBitmap {
        Zone1 = 1,
        Zone2 = 2,
        Zone3 = 4,
        Zone4 = 8,
        Zone5 = 16,
        Zone6 = 32,
        Zone7 = 64,
        Zone8 = 128,
    }

    [Flags]
    public enum ExtendedSettings {
        None = 0,
        ASY = 1, // 0=Polled mode, 1=Asynchronous Mode
        ACK = 2, // acknowledge cmds with ^+$
        ECO = 4, // send response string when a serial command is issued
        CHM = 8, // 0=Only send a “.ch” when needed, 1=Always append a “.ch” channel mask to a zone response cmd
        CRE = 16, // send CRs/LFs at end of responses1
        CSE = 32, // append checksum to commands
        SET = 64, // setup option enabled
        CHS = 128, // 0=Setup mode is read only, 1=Enable changing parameters in the setup mode.
        KYE = 256, // 0=Use ‘KE’ settings for front panels keys, 1=Enable all front panel keys, overrides ‘KE’ settings
        IRE = 512, // 0=Use ‘IRE’ settings for IR control, 1=Enable all IR commands, overrides ‘IRE’ settings.
        IRS = 1024, // IR sensor enabled
        IRJ = 2048, // IR jack enabled
        KYD = 4096, // 0=Disable front panel keys, overrides ‘KYE’, 1=Enable front panel keys (allows ‘KYE’ and ‘KE’ settings).
        AUT = 8192, // 0=Classic Analog/Digital mode, 1=Automatic conversion of Analog/Digital paths
        VMU = 16384, // video muting when a zone is muted
        AMU = 32768, // audio muting when a zone is muted,
        All = 65535
    }

    [Flags]
    public enum TransmitEnableSettings {
        None = 0,
        PWR = 1, // 1=Send update when power state has changed
        QSZ = 2, // 1=Send update when selection (Source / Zone Mapping) has changed
        QMZ = 4, // 1=Send update when mute settings have changed.
        QDZ = 8, // 1=Send update when switching delay settings have changed.
        KEY = 16, // 1=Send update when one or more keys have been pressed.
        IRR = 32, // 1=Send update when a new IR code has been received.
        LMI = 64, // 1=Send update when light mode and / or intensities have changed.
        CTL = 128, // 1=Send update when control settings have changed.
        KYE = 256, // 1=Send update when ‘keycode enabled’ mask has changed.
        All = 511,
    }

    [Flags]
    public enum ChannelBitmap {
        YPbPrVideo = 1,
        AnalogAudio = 2,
        Audio = 2,
        DigitalAudio = 4,
        All = 7
    }


    public enum InputChannel {
        Input1,
        Input2,
        Input3,
        Input4,
        Input5,
        Input6,
        Input7,
        Input8,
        Input9,
        Input10,
        Input11,
        Next, // next channel in sequence
        Prev, // prev channel in sequence
        None,
    }

    public enum VideoInputChannel {
        Component1,
        Component2,
        Component3,
        Component4,
        Component5,
        Component6,
        Component7,
        Component8,
        Composite1,
        Composite2,
        Composite3,
        Next, // next channel in sequence
        Prev, // prev channel in sequence
        None,
    }

}
