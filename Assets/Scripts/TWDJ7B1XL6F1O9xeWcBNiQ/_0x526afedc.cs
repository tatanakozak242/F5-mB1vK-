using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The rail of eight mask silhouettes in the menu. A matched mask lights gold with the
/// game's hard offset shadow; the rest stay flat and dim. When nothing is matched yet
/// the rail says so rather than reading as a blank strip.
/// </summary>
public sealed class _0x526afedc : MonoBehaviour
{
    public void Build(Transform _0xddcd1aeb, _0x9109e422 _0xdc84cdbb, TMP_FontAsset _0xd52114c7, Vector2 _0x095eb596, Vector2 _0x40f7c324)
    {
        RectTransform _0xf45ed4a1 = _0x9dac4d45.Node(_0xddcd1aeb, _0x2ac898e1._0x7a4c9982(new byte[9] { 90, 82, 89, 66, 72, 69, 86, 94, 91 }, 23), _0x095eb596, _0x40f7c324, new Vector2(960f, 420f));
        for (int _0xe0ee78d3 = 0; _0xe0ee78d3 < _0x2861135b.PerformanceGoal; _0xe0ee78d3++)
        {
            int _0xcf82daa3 = _0xe0ee78d3 / Columns;
            int _0xeb969e94 = _0xe0ee78d3 % Columns;
            float _0xe7c78926 = (_0xeb969e94 - (Columns - 1) * 0.5f) * SlotPitchX;
            float _0x8da42596 = 92f - _0xcf82daa3 * SlotPitchY;
            Image _0xb5565a0d = _0x9dac4d45.Block(_0xf45ed4a1, _0x2ac898e1._0x7a4c9982(new byte[11] { 118, 101, 109, 104, 123, 119, 108, 101, 96, 107, 115 }, 36), new Vector2(0.5f, 0.5f), new Vector2(_0xe7c78926 + 7f, _0x8da42596 - 7f), new Vector2(SlotWidth, SlotHeight), _0xdc84cdbb.Silhouette, _0x2861135b.Fade(_0x2861135b.Stroke, 0.9f));
            _0xb5565a0d.type = Image.Type.Simple;
            Image _0x3c9c5d1a = _0x9dac4d45.Block(_0xf45ed4a1, _0x2ac898e1._0x7a4c9982(new byte[9] { 175, 188, 180, 177, 162, 174, 177, 178, 169 }, 253), new Vector2(0.5f, 0.5f), new Vector2(_0xe7c78926, _0x8da42596), new Vector2(SlotWidth, SlotHeight), _0xdc84cdbb.Silhouette, _0x2861135b.Dimmed);
            _0x3c9c5d1a.type = Image.Type.Simple;
            this._0x0a1b719c.Add(_0xb5565a0d);
            this._0x4da729d9.Add(_0x3c9c5d1a);
        }

        this._0x2d7e3bcb = _0x9dac4d45.Label(_0xf45ed4a1, _0x2ac898e1._0x7a4c9982(new byte[12] { 88, 75, 67, 70, 85, 73, 75, 90, 94, 67, 69, 68 }, 10), _0x2ac898e1._0x7a4c9982(new byte[15] { 28, 16, 19, 19, 26, 28, 11, 26, 27, 127, 111, 127, 112, 127, 103 }, 95), new Vector2(0.5f, 0f), new Vector2(0f, 46f), new Vector2(900f, 72f), 38f, 32f, _0x2861135b.TextSecondary, _0xd52114c7, TextAlignmentOptions.Center);
        this._0xce4e1c9e();
    }

    private const float SlotHeight = 134f;
    private const float SlotWidth = 118f;
    private const float SlotPitchY = 172f;
    private readonly System.Collections.Generic.List<Image> _0x4da729d9 = new System.Collections.Generic.List<Image>();
    private readonly System.Collections.Generic.List<Image> _0x0a1b719c = new System.Collections.Generic.List<Image>();
    private void OnDestroy()
    {
        for (int _0x0111ddcb = 0; _0x0111ddcb < this._0x4da729d9.Count; _0x0111ddcb++)
            if (this._0x4da729d9[_0x0111ddcb] != null)
                DOTween.Kill(this._0x4da729d9[_0x0111ddcb].transform);
    }

    /// <summary>The rail falls in step by step when the menu opens.</summary>
    public void _0xb2a23d2d()
    {
        for (int _0x2727e8c1 = 0; _0x2727e8c1 < this._0x4da729d9.Count; _0x2727e8c1++)
        {
            if (this._0x4da729d9[_0x2727e8c1] == null)
                continue;
            Transform _0xb8caba6b = this._0x4da729d9[_0x2727e8c1].transform;
            _0xb8caba6b.localScale = Vector3.zero;
            _0xb8caba6b.DOScale(1f, 0.28f).SetDelay(0.05f * _0x2727e8c1).SetEase(Ease.OutBack);
        }
    }

    private const float SlotPitchX = 224f;
    /// <summary>Recolour the rail when the bill changes - a visible answer to the tap.</summary>
    public void _0x02a9515c(Color _0x7c39afa1)
    {
        this._0x9cbc8476 = _0x7c39afa1;
        this._0xce4e1c9e();
    }

    public void _0xce4e1c9e()
    {
        int _0x17e69fa4 = _0xad4fe07f._0x65c2f277;
        for (int _0x69da5aa4 = 0; _0x69da5aa4 < this._0x4da729d9.Count; _0x69da5aa4++)
        {
            if (this._0x4da729d9[_0x69da5aa4] == null)
                continue;
            bool _0xa39300dd = _0x69da5aa4 < _0x17e69fa4;
            this._0x4da729d9[_0x69da5aa4].color = _0xa39300dd ? this._0x9cbc8476 : _0x2861135b.Dimmed;
            if (this._0x0a1b719c[_0x69da5aa4] != null)
                this._0x0a1b719c[_0x69da5aa4].color = _0x2861135b.Fade(_0x2861135b.Stroke, _0xa39300dd ? 0.9f : 0.35f);
        }

        if (this._0x2d7e3bcb != null)
            this._0x2d7e3bcb.text = _0x17e69fa4 == 0 ? _0x2ac898e1._0x7a4c9982(new byte[30] { 34, 62, 51, 43, 82, 38, 61, 82, 39, 60, 62, 61, 49, 57, 82, 43, 61, 39, 32, 82, 52, 59, 32, 33, 38, 82, 63, 51, 33, 57 }, 114) : _0x2ac898e1._0x7a4c9982(new byte[10] { 109, 97, 98, 98, 107, 109, 122, 107, 106, 14 }, 46) + _0x17e69fa4 + _0x2ac898e1._0x7a4c9982(new byte[3] { 145, 158, 145 }, 177) + _0x2861135b.PerformanceGoal;
    }

    private const int Columns = 4;
    private TextMeshProUGUI _0x2d7e3bcb;
    private Color _0x9cbc8476 = _0x2861135b.Gold;
    public void _0xcae8e06a()
    {
        _0xad4fe07f.ClearCollection();
        this._0xce4e1c9e();
        for (int _0x3941d2b2 = 0; _0x3941d2b2 < this._0x4da729d9.Count; _0x3941d2b2++)
        {
            if (this._0x4da729d9[_0x3941d2b2] == null)
                continue;
            Transform _0x19172e0b = this._0x4da729d9[_0x3941d2b2].transform;
            DOTween.Kill(_0x19172e0b);
            _0x19172e0b.localScale = Vector3.one;
            _0x19172e0b.DOPunchScale(Vector3.one * 0.16f, 0.30f, 5, 0.6f).SetDelay(0.03f * _0x3941d2b2);
        }
    }
}

internal static class _0x2ac898e1
{
    internal static string _0x7a4c9982(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}