using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>
/// The two bills of the evening: GALA is the full house lights, MIDNIGHT gives less
/// light and less time. Picking one repaints the chip, the collection rail and the hero
/// mask in the same frame, so the tap is answered by something visible, not by a label
/// alone (rule C.7).
/// </summary>
public sealed class _0x59f3a4bc : MonoBehaviour
{
    private System.Action<bool> _0x13fce0f3;
    private void OnDestroy()
    {
        if (this._0x8761a66e != null && this._0x8761a66e.Root != null)
            DOTween.Kill(this._0x8761a66e.Root);
        if (this._0xfe05fffa != null && this._0xfe05fffa.Root != null)
            DOTween.Kill(this._0xfe05fffa.Root);
    }

    public void _0xb5eec2a2()
    {
        bool _0xd5095b26 = _0xad4fe07f._0x85d27dab;
        this._0xa8962342(this._0x8761a66e, !_0xd5095b26);
        this._0xa8962342(this._0xfe05fffa, _0xd5095b26);
    }

    public void Build(Transform _0x732b2839, _0x9109e422 _0x4b158d6d, TMP_FontAsset _0x735fc127, Vector2 _0x8f6a8b76, Vector2 _0xd9346a27, System.Action<bool> _0x0098cfe6)
    {
        this._0x13fce0f3 = _0x0098cfe6;
        RectTransform _0x5a1598ff = _0x9dac4d45.Node(_0x732b2839, _0x58b1da73._0x308be6f3(new byte[10] { 56, 48, 59, 32, 42, 55, 60, 57, 57, 38 }, 117), _0x8f6a8b76, _0xd9346a27, new Vector2(760f, 130f));
        this._0x8761a66e = _0x9dac4d45.CtaParts(_0x5a1598ff, _0x58b1da73._0x308be6f3(new byte[9] { 113, 122, 127, 127, 108, 116, 114, 127, 114 }, 51), _0x58b1da73._0x308be6f3(new byte[4] { 61, 59, 54, 59 }, 122), new Vector2(0.5f, 0.5f), new Vector2(-168f, 0f), new Vector2(320f, 104f), _0x4b158d6d.PlatePanel, null, _0x2861135b.BgPlate, _0x2861135b.TextPrimary, _0x735fc127, 42f);
        this._0x8761a66e.Button.onClick.AddListener(() => this._0xf1318ea3(false));
        this._0xfe05fffa = _0x9dac4d45.CtaParts(_0x5a1598ff, _0x58b1da73._0x308be6f3(new byte[13] { 13, 6, 3, 3, 16, 2, 6, 11, 1, 6, 8, 7, 27 }, 79), _0x58b1da73._0x308be6f3(new byte[8] { 228, 224, 237, 231, 224, 238, 225, 253 }, 169), new Vector2(0.5f, 0.5f), new Vector2(168f, 0f), new Vector2(320f, 104f), _0x4b158d6d.PlatePanel, null, _0x2861135b.BgPlate, _0x2861135b.TextPrimary, _0x735fc127, 42f);
        this._0xfe05fffa.Button.onClick.AddListener(() => this._0xf1318ea3(true));
        this._0xb5eec2a2();
    }

    private _0x7e366765 _0xfe05fffa;
    private _0x7e366765 _0x8761a66e;
    private void _0xa8962342(_0x7e366765 _0xcaf84b60, bool _0x3e3a7f57)
    {
        if (_0xcaf84b60 == null)
            return;
        if (_0xcaf84b60.Fill != null)
            _0xcaf84b60.Fill.color = _0x3e3a7f57 ? _0x2861135b.Primary : _0x2861135b.BgPlate;
        if (_0xcaf84b60.Edge != null)
            _0xcaf84b60.Edge.color = _0x3e3a7f57 ? _0x2861135b.Gold : _0x2861135b.Stroke;
        if (_0xcaf84b60.Caption != null)
            _0xcaf84b60.Caption.color = _0x3e3a7f57 ? _0x2861135b.TextPrimary : _0x2861135b.TextSecondary;
    }

    private void _0xf1318ea3(bool _0x144a9371)
    {
        _0xad4fe07f._0x85d27dab = _0x144a9371;
        _0xad4fe07f.Buzz();
        this._0xb5eec2a2();
        if (this._0x13fce0f3 != null)
            this._0x13fce0f3.Invoke(_0x144a9371);
        _0x7e366765 _0xa4abec7e = _0x144a9371 ? this._0xfe05fffa : this._0x8761a66e;
        if (_0xa4abec7e == null || _0xa4abec7e.Root == null)
            return;
        DOTween.Kill(_0xa4abec7e.Root);
        _0xa4abec7e.Root.localScale = Vector3.one;
        _0xa4abec7e.Root.DOPunchScale(Vector3.one * 0.08f, 0.26f, 6, 0.6f);
    }
}

internal static class _0x58b1da73
{
    internal static string _0x308be6f3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}