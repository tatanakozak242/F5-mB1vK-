using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the three result cards the template raises by index - WIN (7), LOSE (8) and
/// PAUSE (6). Everything the template put inside a card is switched off first, so no
/// leftover label and no sprite-less close icon (which Unity draws as a white square)
/// survives; the card the player sees is built here, in this game's palette.
/// </summary>
public sealed class _0x31f7df7e : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    private TMP_FontAsset _0x196ae657;
    private readonly System.Collections.Generic.List<_0xfd5d95d0> _0x96137926 = new System.Collections.Generic.List<_0xfd5d95d0>();
    /// <summary>
    /// Switch off everything the template authored inside this card, and remove the card
    /// this dresser built last time, so re-dressing replaces instead of stacking.
    /// </summary>
    private void _0x82cfe9e0(_0xfd5d95d0 _0x0c2f45a5, Transform _0x258ad3dc)
    {
        for (int _0xef2bfdff = this._0x96137926.Count - 1; _0xef2bfdff >= 0; _0xef2bfdff--)
        {
            if (this._0x96137926[_0xef2bfdff] != _0x0c2f45a5)
                continue;
            if (this._0x5546b0ff[_0xef2bfdff] != null)
                Destroy(this._0x5546b0ff[_0xef2bfdff]);
            this._0x96137926.RemoveAt(_0xef2bfdff);
            this._0x5546b0ff.RemoveAt(_0xef2bfdff);
        }

        for (int _0x589c9754 = _0x258ad3dc.childCount - 1; _0x589c9754 >= 0; _0x589c9754--)
        {
            Transform _0x9c8a219b = _0x258ad3dc.GetChild(_0x589c9754);
            if (_0x9c8a219b != null)
                _0x9c8a219b.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Build a card inside a pop's content. Called with the Pop the caller fetched by
    /// index, immediately before it raises it.
    /// </summary>
    public void Dress(_0xfd5d95d0 _0xf89c333a, string _0xc7d2ad3d, Color _0xddd715ab, string _0xcedf57b0, string _0xab685412, string _0xe91ee5ad, System.Action _0xff568444, string _0x879ffedd, System.Action _0x57291434)
    {
        if (_0xf89c333a == null || _0xf89c333a.Content == null)
            return;
        Transform _0x7642e681 = _0xf89c333a.Content.transform;
        this._0x82cfe9e0(_0xf89c333a, _0x7642e681);
        RectTransform _0xe9afbf1f = _0x9dac4d45.Plate(_0x7642e681, _0x5ebe928d._0xc185554a(new byte[10] { 227, 228, 241, 247, 245, 239, 243, 241, 226, 244 }, 176), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1020f, 1180f), this._0xa82307ec.PlatePanel, _0x2861135b.BgPanel, _0x2861135b.Primary);
        _0x9dac4d45.Label(_0xe9afbf1f, _0x5ebe928d._0xc185554a(new byte[11] { 15, 13, 30, 8, 19, 4, 9, 13, 8, 9, 30 }, 76), _0xc7d2ad3d, new Vector2(0.5f, 1f), new Vector2(0f, -190f), new Vector2(940f, 170f), 104f, 72f, _0xddd715ab, this._0x196ae657, TextAlignmentOptions.Center);
        _0x9dac4d45.Block(_0xe9afbf1f, _0x5ebe928d._0xc185554a(new byte[9] { 110, 108, 127, 105, 114, 127, 120, 97, 104 }, 45), new Vector2(0.5f, 1f), new Vector2(0f, -300f), new Vector2(720f, 10f), this._0xa82307ec.PlatePanel, _0x2861135b.Fade(_0x2861135b.Gold, 0.9f));
        _0x9dac4d45.Label(_0xe9afbf1f, _0x5ebe928d._0xc185554a(new byte[9] { 66, 64, 83, 69, 94, 76, 64, 72, 79 }, 1), _0xcedf57b0, new Vector2(0.5f, 1f), new Vector2(0f, -410f), new Vector2(900f, 150f), 60f, 44f, _0x2861135b.TextPrimary, this._0x196ae657, TextAlignmentOptions.Center);
        _0x9dac4d45.Label(_0xe9afbf1f, _0x5ebe928d._0xc185554a(new byte[10] { 225, 227, 240, 230, 253, 231, 250, 246, 240, 227 }, 162), _0xab685412, new Vector2(0.5f, 1f), new Vector2(0f, -560f), new Vector2(900f, 140f), 48f, 36f, _0x2861135b.TextSecondary, this._0x196ae657, TextAlignmentOptions.Center);
        Button _0x0ca74be9 = _0x9dac4d45.Cta(_0xe9afbf1f, _0x5ebe928d._0xc185554a(new byte[12] { 134, 132, 151, 129, 154, 149, 151, 140, 136, 132, 151, 156 }, 197), _0xe91ee5ad, new Vector2(0.5f, 0f), new Vector2(0f, 300f), new Vector2(700f, 156f), this._0xa82307ec.PlatePanel, null, _0x2861135b.Accent, _0x2861135b.TextPrimary, this._0x196ae657, 52f);
        _0x0ca74be9.onClick.AddListener(() => _0xff568444.Invoke());
        Button _0x4c2fca64 = _0x9dac4d45.Cta(_0xe9afbf1f, _0x5ebe928d._0xc185554a(new byte[14] { 181, 183, 164, 178, 169, 165, 179, 181, 185, 184, 178, 183, 164, 175 }, 246), _0x879ffedd, new Vector2(0.5f, 0f), new Vector2(0f, 128f), new Vector2(700f, 140f), this._0xa82307ec.PlatePanel, null, _0x2861135b.BgPlate, _0x2861135b.TextPrimary, this._0x196ae657, 48f);
        _0x4c2fca64.onClick.AddListener(() => _0x57291434.Invoke());
        // The corner close button carries this game's own X, never the template's
        // missing sprite (rule B.1 / C.3).
        Button _0x6a9cab0b = _0x9dac4d45.Cta(_0xe9afbf1f, _0x5ebe928d._0xc185554a(new byte[10] { 8, 10, 25, 15, 20, 8, 7, 4, 24, 14 }, 75), string.Empty, new Vector2(1f, 1f), new Vector2(-64f, -64f), new Vector2(112f, 112f), this._0xa82307ec.PlatePanel, this._0xa82307ec.IconClose, _0x2861135b.BgPlate, _0x2861135b.TextPrimary, this._0x196ae657, 40f);
        _0x6a9cab0b.onClick.AddListener(() => _0x57291434.Invoke());
        _0xe9afbf1f.localScale = Vector3.one * 0.9f;
        DOTween.Kill(_0xe9afbf1f);
        _0xe9afbf1f.DOScale(1f, 0.28f).SetEase(Ease.OutBack);
        this._0x96137926.Add(_0xf89c333a);
        this._0x5546b0ff.Add(_0xe9afbf1f.parent == null ? _0xe9afbf1f.gameObject : _0xe9afbf1f.parent.gameObject);
    }

    private _0x9109e422 _0xa82307ec;
    public void _0x32eb646b(_0x9109e422 _0xc694b1db, TMP_FontAsset _0x384abe2c)
    {
        this._0xa82307ec = _0xc694b1db;
        this._0x196ae657 = _0x384abe2c;
    }

    private readonly System.Collections.Generic.List<GameObject> _0x5546b0ff = new System.Collections.Generic.List<GameObject>();
}

internal static class _0x5ebe928d
{
    internal static string _0xc185554a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}