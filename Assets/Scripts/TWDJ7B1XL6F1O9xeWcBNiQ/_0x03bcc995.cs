using DG.Tweening;
using UnityEngine;

/// <summary>
/// The plaster cast in the middle of the stage: the lit sample during SHOW, the empty
/// cast during RECALL, and the sockets that swallow a fragment when the player gets a
/// feature right. Sizes come from the camera, punches and scales are written against the
/// computed base size, never against a literal (rule C.0 p.3).
/// </summary>
public sealed class _0x03bcc995 : MonoBehaviour
{
    /// <summary>The mask is whole again - it takes its bow.</summary>
    public void _0xa6695ab1()
    {
        if (this._0xc9217671 != null)
        {
            Transform _0xa4447f65 = this._0xc9217671.transform;
            DOTween.Kill(_0xa4447f65);
            _0xa4447f65.localScale = Vector3.one * this._0x02670f04;
            _0xa4447f65.DOPunchScale(Vector3.one * (this._0x02670f04 * 0.22f), 0.45f, 5, 0.5f);
        }

        this._0x1811a127(_0x2861135b.Gold, 0.8f);
    }

    public void _0x691b5245()
    {
        if (this._0xd4d98c22 == null)
            return;
        Transform _0x9063ea96 = this._0xd4d98c22.transform;
        DOTween.Kill(_0x9063ea96);
        _0x9063ea96.DOScale(0f, _0x2861135b.BlackoutSeconds * 0.7f).SetEase(Ease.InBack).OnComplete(() =>
        {
            this._0xd4d98c22.gameObject.SetActive(false);
            this._0x6574aba2.gameObject.SetActive(false);
            this._0xc494737f.gameObject.SetActive(false);
        });
    }

    private SpriteRenderer _0x72e74a69;
    private Vector2 _0x80627c8c;
    private SpriteRenderer _0x4901acd5;
    private SpriteRenderer _0xc494737f;
    private SpriteRenderer _0x6574aba2;
    private Vector3 _0x7a863c0d;
    private void _0x1811a127(Color _0x445886dd, float _0x0cd953fb)
    {
        if (this._0x4901acd5 == null)
            return;
        DOTween.Kill(this._0x4901acd5);
        DOTween.Kill(this._0x4901acd5.transform);
        this._0x4901acd5.color = _0x2861135b.Fade(_0x445886dd, _0x0cd953fb);
        this._0x4901acd5.transform.localScale = Vector3.one * (this._0x02670f04 * 0.4f);
        this._0x4901acd5.transform.DOScale(this._0x02670f04 * 1.15f, 0.35f).SetEase(Ease.OutQuad);
        this._0x4901acd5.DOFade(0f, 0.38f);
    }

    private void Dress(SpriteRenderer _0xb9de91c3, int _0xd8dade2d, int _0xffd4a697)
    {
        if (_0xb9de91c3 == null)
            return;
        if (_0xffd4a697 < 0 || _0xd8dade2d == _0x9133d900.FeatureColour)
        {
            _0xb9de91c3.gameObject.SetActive(false);
            return;
        }

        Sprite _0x30ecc737 = this._0xb422ca7b._0xc5503225(_0xd8dade2d, _0xffd4a697);
        if (_0x30ecc737 == null)
        {
            _0xb9de91c3.gameObject.SetActive(false);
            return;
        }

        _0xb9de91c3.gameObject.SetActive(true);
        _0xb9de91c3.sprite = _0x30ecc737;
        _0x1bfd6668.Resize(_0xb9de91c3, this._0x80627c8c);
        _0xb9de91c3.color = _0x2861135b.TextPrimary;
        _0xb9de91c3.transform.position = this._0x948c75d9(_0xd8dade2d);
    }

    private Vector2 _0x69793a5a;
    private float _0x02670f04 = 1f;
    /// <summary>A correct fragment flies from the tray into its socket and locks in.</summary>
    public void _0xeaed81f0(int _0xa7075ba5, int _0x0653ac97, Vector3 _0xa2b09e42)
    {
        Vector3 _0xc9936d68 = this._0x948c75d9(_0xa7075ba5);
        if (_0xa7075ba5 == _0x9133d900.FeatureColour)
        {
            if (this._0xc9217671 != null)
            {
                DOTween.Kill(this._0xc9217671);
                this._0xc9217671.DOColor(_0x9109e422.FeatureTint(_0xa7075ba5, _0x0653ac97), 0.30f);
            }
        }
        else
        {
            SpriteRenderer _0x6b185220 = _0xa7075ba5 == _0x9133d900.FeaturePlume ? this._0x5a94872a : this._0x72e74a69;
            this.Dress(_0x6b185220, _0xa7075ba5, _0x0653ac97);
            if (_0x6b185220 != null)
            {
                Transform _0x6ffd612a = _0x6b185220.transform;
                DOTween.Kill(_0x6ffd612a);
                _0x6ffd612a.position = _0xa2b09e42;
                _0x6ffd612a.localScale = Vector3.one * this._0x02670f04;
                _0x6ffd612a.DOMove(_0xc9936d68, 0.22f).SetEase(Ease.OutCubic).OnComplete(() =>
                {
                    _0x6ffd612a.DOPunchScale(Vector3.one * (this._0x02670f04 * 0.18f), 0.25f, 6, 0.6f);
                });
            }
        }

        this._0x1811a127(_0x2861135b.Success, 0.55f);
    }

    private SpriteRenderer _0x5a94872a;
    private void OnDestroy()
    {
        DOTween.Kill(this._0xc9217671);
        DOTween.Kill(this._0xd4d98c22);
        DOTween.Kill(this._0x4901acd5);
    }

    private SpriteRenderer _0xc9217671;
    public void _0x26a5b1b2()
    {
        if (this._0x72e74a69 != null)
            this._0x72e74a69.gameObject.SetActive(false);
        if (this._0x5a94872a != null)
            this._0x5a94872a.gameObject.SetActive(false);
        if (this._0xc9217671 != null)
            this._0xc9217671.color = _0x2861135b.Fade(_0x2861135b.TextPrimary, 0.92f);
    }

    private SpriteRenderer _0xd4d98c22;
    // -- SHOW -----------------------------------------------------------------
    public void _0xf3a3a0ee(_0x48681af8 _0x00581f31)
    {
        if (this._0xd4d98c22 == null)
            return;
        int _0x26275336 = _0x00581f31.SampleVariants[_0x9133d900.FeatureColour];
        Color _0xb75e45a3 = _0x26275336 < 0 ? _0x2861135b.TextPrimary : _0x9109e422.FeatureTint(_0x9133d900.FeatureColour, _0x26275336);
        this._0xd4d98c22.color = _0xb75e45a3;
        this._0xd4d98c22.gameObject.SetActive(true);
        this.Dress(this._0x6574aba2, _0x9133d900.FeatureEyes, _0x00581f31.SampleVariants[_0x9133d900.FeatureEyes]);
        this.Dress(this._0xc494737f, _0x9133d900.FeaturePlume, _0x00581f31.SampleVariants[_0x9133d900.FeaturePlume]);
        Transform _0x0931bdd5 = this._0xd4d98c22.transform;
        DOTween.Kill(_0x0931bdd5);
        _0x0931bdd5.localScale = Vector3.one * (this._0x02670f04 * 0.85f);
        _0x0931bdd5.DOScale(this._0x02670f04, 0.30f).SetEase(Ease.OutBack);
    }

    // -- RECALL ---------------------------------------------------------------
    public void _0xae2c4a25()
    {
        if (this._0xc9217671 == null)
            return;
        this._0xc9217671.gameObject.SetActive(true);
        this._0xc9217671.color = _0x2861135b.Fade(_0x2861135b.TextPrimary, 0.92f);
        Transform _0xfc116c0e = this._0xc9217671.transform;
        DOTween.Kill(_0xfc116c0e);
        _0xfc116c0e.localScale = Vector3.one * (this._0x02670f04 * 0.9f);
        _0xfc116c0e.DOScale(this._0x02670f04, 0.26f).SetEase(Ease.OutBack);
    }

    private _0x9109e422 _0xb422ca7b;
    public Vector3 _0x948c75d9(int _0xed98f003)
    {
        if (_0xed98f003 == _0x9133d900.FeaturePlume)
            return this._0x7a863c0d + new Vector3(0f, this._0x69793a5a.y * 0.44f, 0f);
        if (_0xed98f003 == _0x9133d900.FeatureColour)
            return this._0x7a863c0d + new Vector3(0f, -this._0x69793a5a.y * 0.22f, 0f);
        return this._0x7a863c0d + new Vector3(0f, this._0x69793a5a.y * 0.10f, 0f);
    }

    /// <summary>A wrong fragment: the cast shakes and the stage flashes crimson.</summary>
    public void _0xbfdff817()
    {
        if (this._0xc9217671 == null)
            return;
        Transform _0xc746c18c = this._0xc9217671.transform;
        DOTween.Kill(_0xc746c18c);
        _0xc746c18c.localScale = Vector3.one * this._0x02670f04;
        _0xc746c18c.localPosition = this._0x7a863c0d;
        _0xc746c18c.DOShakePosition(0.30f, 0.12f, 18, 90f).OnComplete(() =>
        {
            _0xc746c18c.localPosition = this._0x7a863c0d;
        });
        this._0x1811a127(_0x2861135b.Accent, 0.6f);
    }

    public void _0xcfe151f4(_0x9109e422 _0x274eb9e9, _0xbd2ae5a9 _0x5189cbd4, float _0x30b3782a, float _0xc29652a1)
    {
        this._0xb422ca7b = _0x274eb9e9;
        GameObject _0xdd39ab7d = _0x5189cbd4 == null ? null : _0x5189cbd4.Slot;
        GameObject _0xb9c8100b = _0x5189cbd4 == null ? null : _0x5189cbd4.Spark;
        float width = _0x30b3782a * 2f * _0x2861135b.MaskWidthFraction;
        this._0x69793a5a = new Vector2(width, width * _0x2861135b.MaskAspect);
        this._0x80627c8c = new Vector2(width * 0.38f, width * 0.38f);
        this._0x7a863c0d = new Vector3(0f, _0x2861135b.MaskCentreY, 0f);
        this._0xc9217671 = _0x1bfd6668.Quad(this.transform, _0x7eb32b6d._0xd603c97a(new byte[8] { 175, 131, 145, 137, 161, 131, 145, 150 }, 226), _0x274eb9e9.MaskBlank, this._0x69793a5a, new Vector2(this._0x7a863c0d.x, this._0x7a863c0d.y), _0x2861135b.MaskOrder, _0x2861135b.Fade(_0x2861135b.TextPrimary, 0.92f));
        this._0x72e74a69 = _0x1bfd6668.Spawn(_0xdd39ab7d, this.transform, _0x7eb32b6d._0xd603c97a(new byte[8] { 135, 165, 183, 176, 129, 189, 161, 183 }, 196), null, this._0x80627c8c, new Vector2(0f, 0f), _0x2861135b.SlotPieceOrder, _0x2861135b.TextPrimary);
        this._0x5a94872a = _0x1bfd6668.Spawn(_0xdd39ab7d, this.transform, _0x7eb32b6d._0xd603c97a(new byte[9] { 150, 180, 166, 161, 133, 185, 160, 184, 176 }, 213), null, this._0x80627c8c, new Vector2(0f, 0f), _0x2861135b.PlumeOrder, _0x2861135b.TextPrimary);
        this._0xd4d98c22 = _0x1bfd6668.Quad(this.transform, _0x7eb32b6d._0xd603c97a(new byte[10] { 209, 253, 239, 247, 207, 253, 241, 236, 240, 249 }, 156), _0x274eb9e9.MaskBlank, this._0x69793a5a, new Vector2(this._0x7a863c0d.x, this._0x7a863c0d.y), _0x2861135b.SampleOrder, _0x2861135b.TextPrimary);
        this._0x6574aba2 = _0x1bfd6668.Spawn(_0xdd39ab7d, this.transform, _0x7eb32b6d._0xd603c97a(new byte[10] { 191, 141, 129, 156, 128, 137, 169, 149, 137, 159 }, 236), null, this._0x80627c8c, new Vector2(0f, 0f), _0x2861135b.SampleOrder + 1, _0x2861135b.TextPrimary);
        this._0xc494737f = _0x1bfd6668.Spawn(_0xdd39ab7d, this.transform, _0x7eb32b6d._0xd603c97a(new byte[11] { 76, 126, 114, 111, 115, 122, 79, 115, 106, 114, 122 }, 31), null, this._0x80627c8c, new Vector2(0f, 0f), _0x2861135b.SampleOrder + 2, _0x2861135b.TextPrimary);
        this._0x4901acd5 = _0x1bfd6668.Spawn(_0xb9c8100b, this.transform, _0x7eb32b6d._0xd603c97a(new byte[9] { 138, 166, 180, 172, 148, 183, 166, 181, 172 }, 199), _0x274eb9e9.BurstSpark, new Vector2(width * 1.5f, width * 1.5f), new Vector2(this._0x7a863c0d.x, this._0x7a863c0d.y), _0x2861135b.SparkOrder, _0x2861135b.Fade(_0x2861135b.Success, 0f));
        this._0x691b5245();
        this._0x26a5b1b2();
    }
}

internal static class _0x7eb32b6d
{
    internal static string _0xd603c97a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}