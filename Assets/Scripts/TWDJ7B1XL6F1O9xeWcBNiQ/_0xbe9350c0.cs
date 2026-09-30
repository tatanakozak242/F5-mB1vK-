using DG.Tweening;
using UnityEngine;

/// <summary>
/// The stage itself: velvet backdrop, floor strip, pedestal and the two spotlight cones
/// that go out when the mask has to be remembered rather than looked at. Every size is
/// derived from the camera half-extents, never from the sprite's native pixels.
/// </summary>
public sealed class _0xbe9350c0 : MonoBehaviour
{
    private float _0xa916d67e = 0.55f;
    /// <summary>The house lights breathe once when a mask is locked in.</summary>
    public void _0x4c6a35d1(Color _0xd8c98fc2)
    {
        if (this._0x2ad8e36a == null)
            return;
        DOTween.Kill(this._0x2ad8e36a);
        this._0x2ad8e36a.color = _0x2861135b.Fade(_0xd8c98fc2, 0.34f);
        this._0x2ad8e36a.DOColor(_0x2861135b.Fade(_0x2861135b.BgPanel, 0.96f), 0.45f);
    }

    private SpriteRenderer _0x2ad8e36a;
    private SpriteRenderer _0x6b16b46d;
    private SpriteRenderer _0xbe41f4e5;
    private void OnDestroy()
    {
        DOTween.Kill(this._0x1cb8356d);
        DOTween.Kill(this._0x6b16b46d);
        DOTween.Kill(this._0x2ad8e36a);
    }

    private SpriteRenderer _0x1cb8356d;
    public void _0xad2aa149(bool _0x26fbf334)
    {
        float _0x0ddb8756 = _0x26fbf334 ? this._0xa916d67e : this._0xd852059b;
        this._0x10bf9d3e(this._0x1cb8356d, _0x0ddb8756);
        this._0x10bf9d3e(this._0x6b16b46d, _0x26fbf334 ? _0x0ddb8756 * 0.82f : this._0xd852059b);
        if (this._0xbe41f4e5 != null)
            this._0xbe41f4e5.color = _0x26fbf334 ? _0x2861135b.BgPlate : _0x2861135b.Fade(_0x2861135b.BgDeep, 0.95f);
    }

    private SpriteRenderer _0x0353b04b;
    public void _0x0a539800(_0x9109e422 _0x03468c29, _0xbd2ae5a9 _0x22c5aca2, float _0xed6bb167, float _0xb71ddd27)
    {
        float _0xc9b38d69 = _0xed6bb167 * 2f;
        GameObject _0x5abcd10e = _0x22c5aca2 == null ? null : _0x22c5aca2.Cone;
        GameObject _0x9c04cff9 = _0x22c5aca2 == null ? null : _0x22c5aca2.Plate;
        this._0x2ad8e36a = _0x1bfd6668.Quad(this.transform, _0x56e94cf3._0x0e8dd32f(new byte[10] { 75, 108, 121, 127, 125, 92, 106, 121, 104, 125 }, 24), _0x03468c29.StageDrape, new Vector2(_0xc9b38d69, _0xb71ddd27 * 0.84f), new Vector2(0f, _0xb71ddd27 * 0.52f), _0x2861135b.DrapeOrder, _0x2861135b.Fade(_0x2861135b.BgPanel, 0.96f));
        this._0x0353b04b = _0x1bfd6668.Quad(this.transform, _0x56e94cf3._0x0e8dd32f(new byte[10] { 17, 54, 35, 37, 39, 4, 46, 45, 45, 48 }, 66), _0x03468c29.StageFloor, new Vector2(_0xc9b38d69, _0xb71ddd27 * 0.28f), new Vector2(0f, -_0xb71ddd27 * 0.86f), _0x2861135b.FloorOrder, _0x2861135b.Fade(_0x2861135b.BgPlate, 0.98f));
        Vector2 _0x775a4d5e = new Vector2(_0xed6bb167 * 0.80f, _0xb71ddd27 * 1.24f);
        this._0x1cb8356d = _0x1bfd6668.Spawn(_0x5abcd10e, this.transform, _0x56e94cf3._0x0e8dd32f(new byte[13] { 47, 12, 19, 8, 16, 21, 27, 20, 8, 48, 25, 26, 8 }, 124), _0x03468c29.SpotlightCone, _0x775a4d5e, new Vector2(-_0xed6bb167 * 0.50f, _0xb71ddd27 * 0.52f), _0x2861135b.SpotlightOrder, _0x2861135b.Fade(_0x2861135b.Primary, this._0xa916d67e));
        this._0x1cb8356d.transform.localRotation = Quaternion.Euler(0f, 0f, 14f);
        this._0x6b16b46d = _0x1bfd6668.Spawn(_0x5abcd10e, this.transform, _0x56e94cf3._0x0e8dd32f(new byte[14] { 236, 207, 208, 203, 211, 214, 216, 215, 203, 237, 214, 216, 215, 203 }, 191), _0x03468c29.SpotlightCone, _0x775a4d5e, new Vector2(_0xed6bb167 * 0.50f, _0xb71ddd27 * 0.52f), _0x2861135b.SpotlightOrder, _0x2861135b.Fade(_0x2861135b.Gold, this._0xa916d67e * 0.82f));
        this._0x6b16b46d.transform.localRotation = Quaternion.Euler(0f, 0f, -14f);
        this._0xbe41f4e5 = _0x1bfd6668.Spawn(_0x9c04cff9, this.transform, _0x56e94cf3._0x0e8dd32f(new byte[13] { 24, 63, 42, 44, 46, 27, 46, 47, 46, 56, 63, 42, 39 }, 75), _0x03468c29.PlatePanel, new Vector2(_0xc9b38d69 * 0.70f, _0xb71ddd27 * 0.11f), new Vector2(0f, _0x2861135b.PedestalY), _0x2861135b.PedestalOrder, _0x2861135b.BgPlate);
    }

    private float _0xd852059b = 0.08f;
    private void _0x10bf9d3e(SpriteRenderer _0xda3093de, float _0x35085307)
    {
        if (_0xda3093de == null)
            return;
        DOTween.Kill(_0xda3093de);
        _0xda3093de.DOFade(_0x35085307, 0.25f);
    }
}

internal static class _0x56e94cf3
{
    internal static string _0x0e8dd32f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}