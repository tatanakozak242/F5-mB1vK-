using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The game screen's own HUD, built from this game's objects rather than borrowed from
/// the scene template (rule C.2): the performance counter, the three miss tokens, the
/// memory bar, the line naming the feature the cast is waiting for, and the one-line
/// control hint (rule C.6).
/// </summary>
public sealed class _0x16ed97a7 : MonoBehaviour
{
    public void SetMemory(float _0x935d3cff)
    {
        if (this._0xb3574067 == null)
            return;
        _0x9dac4d45.SetBar(this._0xb3574067, _0x935d3cff, BarWidth - 6f);
        this._0xb3574067.color = _0x935d3cff < 0.25f ? _0x2861135b.Accent : _0x2861135b.Success;
    }

    private readonly List<Image> _0xbe9fb8d2 = new List<Image>();
    private TextMeshProUGUI _0x5cdca7d1;
    private TextMeshProUGUI _0x2e68eeb7;
    public void _0x1d95b6ae(int _0xcc0f9f59)
    {
        for (int _0xe8647399 = 0; _0xe8647399 < this._0xbe9fb8d2.Count; _0xe8647399++)
        {
            if (this._0xbe9fb8d2[_0xe8647399] == null)
                continue;
            bool _0x4e4666ef = _0xe8647399 < _0xcc0f9f59;
            this._0xbe9fb8d2[_0xe8647399].color = _0x4e4666ef ? _0x2861135b.Accent : _0x2861135b.Dimmed;
        }
    }

    public void _0xf9a8bd0f(bool _0x9bf040fb)
    {
        if (this._0x5cdca7d1 != null)
            this._0x5cdca7d1.gameObject.SetActive(_0x9bf040fb);
    }

    public void _0xf9d3b14c(string _0x34923818)
    {
        if (this._0x2e68eeb7 != null)
            this._0x2e68eeb7.text = _0x34923818;
    }

    public void Build(Transform _0x8fe3404d, _0x9109e422 _0xeaa220fc, TMP_FontAsset _0x6effcc8c, System.Action _0x92c79362, System.Action _0x1cefe43e)
    {
        RectTransform _0x1aeb449a = _0x9dac4d45.Node(_0x8fe3404d, _0x8a2376e0._0x60da359b(new byte[9] { 183, 176, 165, 163, 161, 187, 172, 177, 160 }, 228), new Vector2(0.5f, 0.5f), Vector2.zero, Vector2.zero);
        _0x1aeb449a.anchorMin = Vector2.zero;
        _0x1aeb449a.anchorMax = Vector2.one;
        _0x1aeb449a.sizeDelta = Vector2.zero;
        Button _0x1a262445 = _0x9dac4d45.Cta(_0x1aeb449a, _0x8a2376e0._0x60da359b(new byte[8] { 245, 232, 249, 226, 255, 252, 254, 246 }, 189), string.Empty, new Vector2(0f, 1f), new Vector2(128f, -168f), new Vector2(152f, 152f), _0xeaa220fc.PlatePanel, _0xeaa220fc.IconBack, _0x2861135b.BgPlate, _0x2861135b.TextPrimary, _0x6effcc8c, 40f);
        _0x1a262445.onClick.AddListener(() => _0x92c79362.Invoke());
        Button _0x1a3cd7d4 = _0x9dac4d45.Cta(_0x1aeb449a, _0x8a2376e0._0x60da359b(new byte[9] { 154, 135, 150, 141, 130, 147, 135, 129, 151 }, 210), string.Empty, new Vector2(1f, 1f), new Vector2(-128f, -168f), new Vector2(152f, 152f), _0xeaa220fc.PlatePanel, _0xeaa220fc.IconPause, _0x2861135b.BgPlate, _0x2861135b.TextPrimary, _0x6effcc8c, 40f);
        _0x1a3cd7d4.onClick.AddListener(() => _0x1cefe43e.Invoke());
        RectTransform _0xe1b0e99b = _0x9dac4d45.Plate(_0x1aeb449a, _0x8a2376e0._0x60da359b(new byte[9] { 121, 100, 117, 110, 114, 126, 100, 127, 101 }, 49), new Vector2(0.5f, 1f), new Vector2(0f, -168f), new Vector2(620f, 124f), _0xeaa220fc.PlatePanel, _0x2861135b.BgPanel, _0x2861135b.Stroke);
        this._0xed03cb58 = _0x9dac4d45.Label(_0xe1b0e99b, _0x8a2376e0._0x60da359b(new byte[14] { 230, 251, 234, 241, 237, 225, 251, 224, 250, 241, 250, 235, 246, 250 }, 174), _0x8a2376e0._0x60da359b(new byte[17] { 163, 182, 161, 181, 188, 161, 190, 178, 189, 176, 182, 211, 194, 211, 220, 211, 203 }, 243), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(560f, 92f), 52f, 44f, _0x2861135b.TextPrimary, _0x6effcc8c, TextAlignmentOptions.Center);
        RectTransform _0x3b7c872f = _0x9dac4d45.Node(_0x1aeb449a, _0x8a2376e0._0x60da359b(new byte[10] { 138, 151, 134, 157, 143, 139, 145, 145, 135, 145 }, 194), new Vector2(0.5f, 1f), new Vector2(0f, -308f), new Vector2(460f, 84f));
        _0x9dac4d45.Label(_0x3b7c872f, _0x8a2376e0._0x60da359b(new byte[16] { 25, 4, 21, 14, 28, 24, 2, 2, 20, 2, 14, 29, 16, 19, 20, 29 }, 81), _0x8a2376e0._0x60da359b(new byte[6] { 238, 234, 240, 240, 230, 240 }, 163), new Vector2(0f, 0.5f), new Vector2(112f, 0f), new Vector2(210f, 72f), 40f, 34f, _0x2861135b.TextSecondary, _0x6effcc8c, TextAlignmentOptions.Left);
        for (int _0x2bf8b9a6 = 0; _0x2bf8b9a6 < _0x2861135b.MissesAllowed; _0x2bf8b9a6++)
        {
            Image _0x117eb094 = _0x9dac4d45.Block(_0x3b7c872f, _0x8a2376e0._0x60da359b(new byte[14] { 133, 152, 137, 146, 128, 132, 158, 158, 146, 153, 130, 134, 136, 131 }, 205), new Vector2(1f, 0.5f), new Vector2(-40f - (_0x2861135b.MissesAllowed - 1 - _0x2bf8b9a6) * 62f, 0f), new Vector2(46f, 46f), _0xeaa220fc.DotToken, _0x2861135b.Dimmed);
            _0x117eb094.type = Image.Type.Simple;
            this._0xbe9fb8d2.Add(_0x117eb094);
        }

        this._0xb3574067 = _0x9dac4d45.Bar(_0x1aeb449a, _0x8a2376e0._0x60da359b(new byte[10] { 0, 29, 12, 23, 5, 13, 5, 7, 26, 17 }, 72), new Vector2(0.5f, 1f), new Vector2(0f, -398f), new Vector2(BarWidth, 30f), _0xeaa220fc.PlatePanel, _0x2861135b.BgPlate, _0x2861135b.Success);
        this._0x2e68eeb7 = _0x9dac4d45.Label(_0x1aeb449a, _0x8a2376e0._0x60da359b(new byte[8] { 50, 47, 62, 37, 41, 54, 53, 46 }, 122), _0x8a2376e0._0x60da359b(new byte[11] { 229, 233, 252, 235, 224, 146, 136, 237, 241, 237, 251 }, 168), new Vector2(0.5f, 1f), new Vector2(0f, -484f), new Vector2(900f, 96f), 56f, 46f, _0x2861135b.Gold, _0x6effcc8c, TextAlignmentOptions.Center);
        this._0x5cdca7d1 = _0x9dac4d45.Label(_0x1aeb449a, _0x8a2376e0._0x60da359b(new byte[8] { 54, 43, 58, 33, 54, 55, 48, 42 }, 126), _0x8a2376e0._0x60da359b(new byte[30] { 240, 229, 244, 132, 229, 132, 226, 246, 229, 227, 233, 225, 234, 240, 132, 240, 235, 132, 226, 237, 240, 132, 240, 236, 225, 132, 233, 229, 247, 239 }, 164), new Vector2(0.5f, 1f), new Vector2(0f, -574f), new Vector2(1020f, 78f), 46f, 38f, _0x2861135b.TextSecondary, _0x6effcc8c, TextAlignmentOptions.Center);
    }

    private Image _0xb3574067;
    private const float BarWidth = 954f;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    public void _0x537c3371(int _0xb0c06273, int _0x2d4e103d)
    {
        if (this._0xed03cb58 != null)
            this._0xed03cb58.text = _0x8a2376e0._0x60da359b(new byte[12] { 18, 7, 16, 4, 13, 16, 15, 3, 12, 1, 7, 98 }, 66) + Mathf.Min(_0xb0c06273 + 1, _0x2d4e103d) + _0x8a2376e0._0x60da359b(new byte[3] { 248, 247, 248 }, 216) + _0x2d4e103d;
    }

    private TextMeshProUGUI _0xed03cb58;
}

internal static class _0x8a2376e0
{
    internal static string _0x60da359b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}