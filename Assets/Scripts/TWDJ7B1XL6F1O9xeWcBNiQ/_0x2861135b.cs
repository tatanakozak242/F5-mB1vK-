using UnityEngine;

/// <summary>
/// One place for the carnival-stage numbers: palette, sorting bands, timings and the
/// per-performance difficulty table. Nothing here is guessed on screen - every world
/// size is expressed as a fraction of the camera half-extents and resolved at runtime
/// (rule C.0), and every sorting order is a named constant inside the -19..-1 band the
/// pops reserve (rules C.0 p.5 / C.21).
/// </summary>
public static class _0x2861135b
{
    public const float MaskAspect = 1.136f; // height / width
    /// <summary>Clamped row of the table - the run never reads past the last stage.</summary>
    public static int Row(int _0x8a0c7854)
    {
        return Mathf.Clamp(_0x8a0c7854, 0, SlotCounts.Length - 1);
    }

    public static readonly Color Primary = Rgb(0.49019608f, 0.25882354f, 0.70980394f);
    public const int CoinsPerMask = 25;
    public static readonly Color TextSecondary = Rgb(0.76470590f, 0.68235296f, 0.83921570f);
    // The five tints a COLOUR feature can take. They double as the mask tint applied
    // to the plaster cast, so no extra art is needed for that feature (design doc).
    public static readonly Color[] MaskTints =
    {
        Rgb(0.49019608f, 0.25882354f, 0.70980394f),
        Rgb(0.85490197f, 0.23921569f, 0.40784314f),
        Rgb(0.92941177f, 0.74901960f, 0.29411766f),
        Rgb(0.21176471f, 0.70980394f, 0.65882355f),
        Rgb(0.96470590f, 0.91372550f, 0.85098040f),
    };
    public const int CoinsPerCleanMask = 100;
    public const int MaskOrder = -12;
    public static readonly int[] RecallSeconds =
    {
        30,
        30,
        28,
        28,
        26,
        26,
        24,
        24
    };
    public const int SlotFrameOrder = -11;
    public const float HintSeconds = 6.0f;
    public const int ChipPieceOrder = -5;
    public const int SampleOrder = -8;
    /// <summary>Midnight raises the stakes: less light, less time to rebuild.</summary>
    public const float MidnightShowScale = 0.78f;
    public const int DrapeOrder = -17;
    public const int PlumeOrder = -9;
    public static Color Fade(Color _0xb6325070, float _0x2262b815)
    {
        return new Color(_0xb6325070.r, _0xb6325070.g, _0xb6325070.b, _0x2262b815);
    }

    // -- palette (ticket colours; the preset name stays RETRO_NEON) -------------
    public static readonly Color BgDeep = Rgb(0.09019608f, 0.07058824f, 0.12156863f);
    public static readonly Color Success = Rgb(0.21176471f, 0.70980394f, 0.65882355f);
    private static Color Rgb(float _0x390c9e78, float _0x9d7b1c64, float _0xd2fc951c)
    {
        return new Color(_0x390c9e78, _0x9d7b1c64, _0xd2fc951c, 1f);
    }

    public const int SpotlightOrder = -16;
    public static readonly Color BgPlate = Rgb(0.18039216f, 0.12941177f, 0.25098040f);
    public static readonly Color Gold = Rgb(0.92941177f, 0.74901960f, 0.29411766f);
    // -- world geometry, as fractions of the camera half-extents ---------------
    public const float BoardWidthFraction = 0.94f;
    public static readonly int[] ShowMilliseconds =
    {
        2600,
        2400,
        2200,
        2200,
        2000,
        1800,
        1700,
        1600
    };
    public static readonly Color Stroke = Rgb(0.05490196f, 0.03921569f, 0.07843138f);
    public const float RecallBonusSeconds = 4.0f;
    public const int PerformanceGoal = 8;
    // -- timings ---------------------------------------------------------------
    public const float BlackoutSeconds = 0.35f;
    public const float MidnightRecallScale = 0.80f;
    public const float ChipMaxHeight = 1.34f;
    public const float ResolveSeconds = 1.20f;
    public const float MaskWidthFraction = 0.62f;
    public const int ChipOrder = -6;
    // -- sorting orders: background canvas is -30, the pops are +10 -------------
    public const int FloorOrder = -18;
    public static readonly int[] ChipCounts =
    {
        4,
        6,
        6,
        6,
        8,
        8,
        8,
        8
    };
    // -- difficulty table: slots, tray plaques, show time, recall seconds ------
    // Tray plaque counts stay at 4/6/8 so the tray is never deeper than two rows
    // (three rows would push the bottom row off a 10-unit-tall camera).
    public static readonly int[] SlotCounts =
    {
        2,
        2,
        2,
        3,
        3,
        3,
        3,
        3
    };
    public const int PedestalOrder = -14;
    public static readonly Color BgPanel = Rgb(0.14117648f, 0.10196079f, 0.19215687f);
    public const float PedestalY = -1.15f;
    public static readonly Color Pressed = Rgb(0.36078432f, 0.18039216f, 0.53333336f);
    public const float TrayTopY = -1.60f;
    public static readonly Color Accent = Rgb(0.85490197f, 0.23921569f, 0.40784314f);
    public const float MaskCentreY = 0.55f;
    public const float PopReleaseSeconds = 6.0f;
    public static readonly string[] TintNames =
    {
        _0x00bdc44a._0xd25cc789(new byte[6] { 38, 57, 63, 60, 53, 36 }, 112),
        _0x00bdc44a._0xd25cc789(new byte[7] { 255, 238, 245, 241, 239, 243, 242 }, 188),
        _0x00bdc44a._0xd25cc789(new byte[4] { 165, 173, 174, 166 }, 226),
        _0x00bdc44a._0xd25cc789(new byte[4] { 48, 59, 62, 63 }, 122),
        _0x00bdc44a._0xd25cc789(new byte[4] { 181, 184, 185, 178 }, 247)
    };
    public const int MissesAllowed = 3;
    public static readonly Color Dimmed = Rgb(0.22745098f, 0.17254902f, 0.29019610f);
    public const int SparkOrder = -3;
    public const float ChipGap = 0.13f;
    public static readonly Color TextPrimary = Rgb(0.96470590f, 0.91372550f, 0.85098040f);
    public const int SlotPieceOrder = -10;
    public const float HeroWidthFraction = 0.44f;
}

internal static class _0x00bdc44a
{
    internal static string _0xd25cc789(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}