using UnityEngine;

/// <summary>
/// The small amount of state the carnival keeps between shows: how many masks the
/// collection holds, which bill the player picked and whether the handset buzzes.
/// Applause itself lives in the template's own store (SETTINGS.PlayerSYSTEM.Coins).
/// </summary>
public static class _0xad4fe07f
{
    public static void ClearCollection()
    {
        _0x65c2f277 = 0;
    }

    public static void Unlock(int _0xdac70cab)
    {
        if (_0xdac70cab + 1 > _0x65c2f277)
            _0x65c2f277 = _0xdac70cab + 1;
    }

    public static void Buzz()
    {
        if (!_0x35db16e9)
            return;
#if UNITY_ANDROID && !UNITY_EDITOR
        Handheld.Vibrate();
#endif
    }

    public static bool _0x35db16e9
    {
        get
        {
            return PlayerPrefs.GetInt(VibrationKey, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(VibrationKey, value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

    public static int _0x65c2f277
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(CollectedKey, 0), 0, _0x2861135b.PerformanceGoal);
        }

        set
        {
            PlayerPrefs.SetInt(CollectedKey, Mathf.Clamp(value, 0, _0x2861135b.PerformanceGoal));
            PlayerPrefs.Save();
        }
    }

    private static readonly string CollectedKey = _0xe8a166d6._0xac71778e(new byte[13] { 160, 140, 158, 134, 174, 130, 129, 129, 136, 142, 153, 136, 137 }, 237);
    public static bool _0x85d27dab
    {
        get
        {
            return PlayerPrefs.GetInt(MidnightKey, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(MidnightKey, value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

    private static readonly string VibrationKey = _0xe8a166d6._0xac71778e(new byte[13] { 164, 136, 154, 130, 191, 128, 139, 155, 136, 157, 128, 134, 135 }, 233);
    private static readonly string MidnightKey = _0xe8a166d6._0xac71778e(new byte[12] { 204, 224, 242, 234, 204, 232, 229, 239, 232, 230, 233, 245 }, 129);
}

internal static class _0xe8a166d6
{
    internal static string _0xac71778e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}