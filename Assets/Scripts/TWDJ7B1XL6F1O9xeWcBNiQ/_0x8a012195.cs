using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// The tray of fragment plaques along the bottom of the stage. Plaques are spawned from
/// a pre-configured prefab, then sized and placed from the camera half-extents, so the
/// tray fills the same slice of the screen on every aspect. Taps are resolved against
/// the plaque rectangles - no colliders, no name lookups.
/// </summary>
public sealed class _0x8a012195 : MonoBehaviour
{
    /// <summary>A plaque the player took - it leaves the tray with a small pop.</summary>
    public void _0xdd1212e0(int _0x6d9d75c0)
    {
        if (!this._0x1ba3d328(_0x6d9d75c0) || this._0x7b5fd432[_0x6d9d75c0] == null)
            return;
        this._0xb424cfd9[_0x6d9d75c0] = false;
        Transform _0x306d30c9 = this._0x7b5fd432[_0x6d9d75c0].transform;
        DOTween.Kill(_0x306d30c9);
        _0x306d30c9.DOScale(0f, 0.20f).SetEase(Ease.InBack);
    }

    private readonly List<SpriteRenderer> _0x7b5fd432 = new List<SpriteRenderer>();
    public int _0x03067320
    {
        get
        {
            return this._0x7b5fd432.Count;
        }
    }

    private void OnDestroy()
    {
        for (int _0xf8fd8668 = 0; _0xf8fd8668 < this._0x7b5fd432.Count; _0xf8fd8668++)
            if (this._0x7b5fd432[_0xf8fd8668] != null)
                DOTween.Kill(this._0x7b5fd432[_0xf8fd8668].transform);
    }

    /// <summary>Index of the live plaque under a world point, or -1.</summary>
    public int _0xa46e23f3(Vector2 _0x5ff45475)
    {
        for (int _0x61239660 = 0; _0x61239660 < this._0x7b5fd432.Count; _0x61239660++)
        {
            if (!this._0xb424cfd9[_0x61239660] || this._0x7b5fd432[_0x61239660] == null)
                continue;
            if (_0x1bfd6668.BoundsOf(this._0x7b5fd432[_0x61239660]).Contains(_0x5ff45475))
                return _0x61239660;
        }

        return -1;
    }

    private float _0xcd260622 = 1f;
    public int _0xc0fdc1ae(int _0xc62e3b9e)
    {
        return this._0x1ba3d328(_0xc62e3b9e) ? this._0x14422895.ChipVariants[_0xc62e3b9e] : -1;
    }

    public Vector3 _0x7ff6bc3f(int _0x04ccaeb6)
    {
        if (!this._0x1ba3d328(_0x04ccaeb6) || this._0x7b5fd432[_0x04ccaeb6] == null)
            return Vector3.zero;
        return this._0x7b5fd432[_0x04ccaeb6].transform.position;
    }

    private readonly List<SpriteRenderer> _0x1cfb80fe = new List<SpriteRenderer>();
    private readonly List<bool> _0xb424cfd9 = new List<bool>();
    private _0x48681af8 _0x14422895;
    public void _0x5877c517(_0x48681af8 _0xacb2685c)
    {
        this._0x71aa42b5();
        this._0x14422895 = _0xacb2685c;
        int _0x3fa01613 = _0xacb2685c.ChipFeatures.Length;
        int _0x1e2345bf = Mathf.Max(1, _0xacb2685c.Columns);
        int _0x30e28475 = Mathf.CeilToInt(_0x3fa01613 / (float)_0x1e2345bf);
        float _0x3ccb1b04 = this._0x14804064 * 2f * _0x2861135b.BoardWidthFraction;
        float _0x40f13429 = (_0x3ccb1b04 - (_0x1e2345bf - 1) * _0x2861135b.ChipGap) / _0x1e2345bf;
        this._0xcd260622 = Mathf.Min(_0x2861135b.ChipMaxHeight, _0x40f13429);
        float _0x1ef9e8ed = this._0xcd260622 + _0x2861135b.ChipGap;
        float _0xa6804ee9 = this._0xcd260622 + _0x2861135b.ChipGap * 1.5f;
        float _0x2f7f3fb0 = _0x2861135b.TrayTopY - this._0xcd260622 * 0.5f;
        for (int _0x678e0368 = 0; _0x678e0368 < _0x3fa01613; _0x678e0368++)
        {
            int _0x7db4d814 = _0x678e0368 / _0x1e2345bf;
            int _0x88b5eaa1 = _0x678e0368 % _0x1e2345bf;
            int _0xc09e7cfb = Mathf.Min(_0x1e2345bf, _0x3fa01613 - _0x7db4d814 * _0x1e2345bf);
            float _0xc9efaa70 = _0xc09e7cfb * this._0xcd260622 + (_0xc09e7cfb - 1) * _0x2861135b.ChipGap;
            float _0x9920c343 = -_0xc9efaa70 * 0.5f + this._0xcd260622 * 0.5f + _0x88b5eaa1 * _0x1ef9e8ed;
            float _0x7c15d0c5 = _0x2f7f3fb0 - _0x7db4d814 * _0xa6804ee9;
            this.Spawn(_0x678e0368, new Vector2(_0x9920c343, _0x7c15d0c5));
        }
    }

    private _0x9109e422 _0xc8808bb6;
    public void _0x71aa42b5()
    {
        for (int _0x892d5b48 = 0; _0x892d5b48 < this._0x7b5fd432.Count; _0x892d5b48++)
            if (this._0x7b5fd432[_0x892d5b48] != null)
            {
                DOTween.Kill(this._0x7b5fd432[_0x892d5b48].transform);
                Destroy(this._0x7b5fd432[_0x892d5b48].gameObject);
            }

        this._0x7b5fd432.Clear();
        this._0x1cfb80fe.Clear();
        this._0xb424cfd9.Clear();
    }

    private float _0x14804064;
    /// <summary>A plaque that did not belong - it goes grey and stops answering taps.</summary>
    public void _0x7972d7e9(int _0x558f406f)
    {
        if (!this._0x1ba3d328(_0x558f406f) || this._0x7b5fd432[_0x558f406f] == null)
            return;
        this._0xb424cfd9[_0x558f406f] = false;
        this._0x7b5fd432[_0x558f406f].color = _0x2861135b.Dimmed;
        if (this._0x1cfb80fe[_0x558f406f] != null)
            this._0x1cfb80fe[_0x558f406f].color = _0x2861135b.Fade(_0x2861135b.TextSecondary, 0.35f);
        Transform _0xb897ed25 = this._0x7b5fd432[_0x558f406f].transform;
        DOTween.Kill(_0xb897ed25);
        _0xb897ed25.DOShakePosition(0.22f, 0.06f, 14, 90f);
    }

    private GameObject _0xe4c952b5;
    public int _0x762caf85(int _0x224349ce)
    {
        return this._0x1ba3d328(_0x224349ce) ? this._0x14422895.ChipFeatures[_0x224349ce] : -1;
    }

    private bool _0x1ba3d328(int _0x2bec5f40)
    {
        return this._0x14422895 != null && _0x2bec5f40 >= 0 && _0x2bec5f40 < this._0x7b5fd432.Count;
    }

    private void Spawn(int _0x90994206, Vector2 _0x5c934240)
    {
        GameObject _0x1435331d = this._0xe4c952b5 != null ? Instantiate(this._0xe4c952b5, this.transform) : new GameObject(_0x7cd8f8b8._0x7ab71ca7(new byte[12] { 249, 205, 222, 216, 210, 218, 209, 203, 252, 215, 214, 207 }, 191));
        _0x1435331d.transform.SetParent(this.transform, false);
        _0x1435331d.transform.localPosition = new Vector3(_0x5c934240.x, _0x5c934240.y, 0f);
        _0x1435331d.transform.localScale = Vector3.one;
        SpriteRenderer _0x668f236b = _0x1435331d.GetComponent<SpriteRenderer>();
        if (_0x668f236b == null)
            _0x668f236b = _0x1435331d.AddComponent<SpriteRenderer>();
        _0x668f236b.sprite = this._0xc8808bb6.ChipBase;
        _0x668f236b.drawMode = SpriteDrawMode.Sliced;
        _0x668f236b.size = new Vector2(this._0xcd260622, this._0xcd260622);
        _0x668f236b.sortingOrder = _0x2861135b.ChipOrder;
        _0x668f236b.color = _0x2861135b.BgPlate;
        int _0xef4732da = this._0x14422895.ChipFeatures[_0x90994206];
        int _0x4012fb6d = this._0x14422895.ChipVariants[_0x90994206];
        SpriteRenderer _0x1f6b6ebf = _0x1bfd6668.Quad(_0x1435331d.transform, _0x7cd8f8b8._0x7ab71ca7(new byte[8] { 109, 70, 71, 94, 104, 79, 77, 75 }, 46), this._0xc8808bb6._0xc5503225(_0xef4732da, _0x4012fb6d), new Vector2(this._0xcd260622 * 0.72f, this._0xcd260622 * 0.72f), Vector2.zero, _0x2861135b.ChipPieceOrder, _0x9109e422.FeatureTint(_0xef4732da, _0x4012fb6d));
        if (_0xef4732da == _0x9133d900.FeatureColour)
        {
            _0x1f6b6ebf.sprite = this._0xc8808bb6.MaskBlank;
            _0x1bfd6668.Resize(_0x1f6b6ebf, new Vector2(this._0xcd260622 * 0.62f, this._0xcd260622 * 0.70f));
        }

        this._0x7b5fd432.Add(_0x668f236b);
        this._0x1cfb80fe.Add(_0x1f6b6ebf);
        this._0xb424cfd9.Add(true);
        Transform _0x85e73bec = _0x1435331d.transform;
        _0x85e73bec.localScale = Vector3.zero;
        _0x85e73bec.DOScale(1f, 0.24f).SetDelay(0.03f * _0x90994206).SetEase(Ease.OutBack);
    }

    public void _0xeb0b9e48(_0x9109e422 _0x9509161a, _0xbd2ae5a9 _0x0b9cd33e, float _0x303873ba)
    {
        this._0xc8808bb6 = _0x9509161a;
        this._0xe4c952b5 = _0x0b9cd33e == null ? null : _0x0b9cd33e.Chip;
        this._0x14804064 = _0x303873ba;
    }

    /// <summary>Highlight the plaques that can answer the slot the cast is waiting on.</summary>
    public void _0x153306e7(int _0xb15155b8)
    {
        for (int _0xa92b666e = 0; _0xa92b666e < this._0x7b5fd432.Count; _0xa92b666e++)
        {
            if (this._0x7b5fd432[_0xa92b666e] == null || !this._0xb424cfd9[_0xa92b666e])
                continue;
            bool _0x31c51f62 = this._0x14422895.ChipFeatures[_0xa92b666e] == _0xb15155b8;
            this._0x7b5fd432[_0xa92b666e].color = _0x31c51f62 ? _0x2861135b.Primary : _0x2861135b.BgPlate;
        }
    }
}

internal static class _0x7cd8f8b8
{
    internal static string _0x7ab71ca7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}