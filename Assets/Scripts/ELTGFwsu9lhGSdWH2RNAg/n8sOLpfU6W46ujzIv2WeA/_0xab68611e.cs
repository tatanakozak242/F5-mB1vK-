using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xab68611e
{
    public static class _0x61bc701f
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x651c7180
    {
        public static int _0x022bcc30
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x00b12c3b._0x77399c93(new byte[5] { 119, 91, 93, 90, 71 }, 52)))
                    PlayerPrefs.SetInt(_0x00b12c3b._0x77399c93(new byte[5] { 205, 225, 231, 224, 253 }, 142), 0);
                return PlayerPrefs.GetInt(_0x00b12c3b._0x77399c93(new byte[5] { 19, 63, 57, 62, 35 }, 80));
            }

            set
            {
                PlayerPrefs.SetInt(_0x00b12c3b._0x77399c93(new byte[5] { 105, 69, 67, 68, 89 }, 42), value);
                _0x279ca21b.Instance._0x35234921();
            }
        }
    }

    public static class _0xb6633f3a
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x74dfb94c
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0x5a7e3d2b
    {
        private static readonly _0x5a7e3d2b _0xebc3221b = new();
        public static readonly _0x5a7e3d2b[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xebc3221b,
            _0xebc3221b,
            _0xebc3221b,
        };
        private int _0xd719f9b8 => 0;
        private int _0x628cfa22 => 10;
        private string _0x0b8ef78a => _0x00b12c3b._0x77399c93(new byte[4] { 127, 87, 92, 71 }, 50);
        private string _0x2ec69655 => _0x00b12c3b._0x77399c93(new byte[8] { 243, 250, 233, 250, 243, 196, 143, 194 }, 191);

        private int _0xc7d97b63
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x00b12c3b._0x77399c93(new byte[25] { 222, 232, 239, 239, 248, 243, 233, 218, 241, 242, 255, 252, 241, 222, 245, 252, 237, 233, 248, 239, 212, 243, 249, 248, 229 }, 157)))
                    PlayerPrefs.SetInt(_0x00b12c3b._0x77399c93(new byte[25] { 213, 227, 228, 228, 243, 248, 226, 209, 250, 249, 244, 247, 250, 213, 254, 247, 230, 226, 243, 228, 223, 248, 242, 243, 238 }, 150), 0);
                return PlayerPrefs.GetInt(_0x00b12c3b._0x77399c93(new byte[25] { 147, 165, 162, 162, 181, 190, 164, 151, 188, 191, 178, 177, 188, 147, 184, 177, 160, 164, 181, 162, 153, 190, 180, 181, 168 }, 208));
            }

            set => PlayerPrefs.SetInt(_0x00b12c3b._0x77399c93(new byte[25] { 44, 26, 29, 29, 10, 1, 27, 40, 3, 0, 13, 14, 3, 44, 7, 14, 31, 27, 10, 29, 38, 1, 11, 10, 23 }, 111), value);
        }

        public int _0x40f97b4f
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x0b8ef78a}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x0b8ef78a}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x0b8ef78a}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x0b8ef78a}CurrentLevelIndex", value);
        }

        public int _0x9a4ad0b0
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x0b8ef78a}BestScore"))
                    this._0x9a4ad0b0 = 0;
                return PlayerPrefs.GetInt($"{this._0x0b8ef78a}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x0b8ef78a}BestScore", value);
        }

        public bool _0x911b7d89
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x0b8ef78a}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x0b8ef78a}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x0b8ef78a}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x0b8ef78a}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }
}

internal static class _0x00b12c3b
{
    internal static string _0x77399c93(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}