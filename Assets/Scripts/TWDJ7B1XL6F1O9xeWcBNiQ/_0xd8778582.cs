using TMPro;
using UnityEngine;

/// <summary>
/// The strip STAGE SETTINGS unfolds: a handset-buzz switch and a collection reset. There
/// is no sound in this game, so there is nothing to mute and no audio row here (rule
/// C.20). Both controls answer a tap with a visible change in the same frame (rule C.7).
/// </summary>
public sealed class _0xd8778582 : MonoBehaviour
{
    public void _0xc3961cb2()
    {
        this._0x7f7d8862(!this._0x0d7c5f06);
    }

    private bool _0x0d7c5f06;
    private void _0x1c7d6d5a()
    {
        _0xad4fe07f.Buzz();
        if (this._0x4e0408e0 != null)
            this._0x4e0408e0.Invoke();
        if (this._0xacdfbd9a != null && this._0xacdfbd9a.Fill != null)
            this._0xacdfbd9a.Fill.color = _0x2861135b.Accent;
    }

    public void Build(Transform _0xa10c8194, _0x9109e422 _0xeb7b4f91, TMP_FontAsset _0xf075714b, Vector2 _0xd33b75ce, Vector2 _0xbb576127, System.Action _0x8e46868f)
    {
        this._0x4e0408e0 = _0x8e46868f;
        this._0xae4ae1c4 = _0x9dac4d45.Node(_0xa10c8194, _0xeba3d2e7._0xb90dd9cd(new byte[13] { 245, 253, 246, 237, 231, 235, 253, 236, 236, 241, 246, 255, 235 }, 184), _0xd33b75ce, _0xbb576127, new Vector2(1000f, 130f));
        this._0x322be742 = _0x9dac4d45.CtaParts(this._0xae4ae1c4, _0xeba3d2e7._0xb90dd9cd(new byte[8] { 63, 41, 56, 51, 46, 57, 54, 54 }, 108), _0xeba3d2e7._0xb90dd9cd(new byte[12] { 63, 32, 43, 59, 40, 61, 32, 38, 39, 73, 38, 39 }, 105), new Vector2(0.5f, 0.5f), new Vector2(-250f, 0f), new Vector2(470f, 104f), _0xeb7b4f91.PlatePanel, null, _0x2861135b.BgPlate, _0x2861135b.TextPrimary, _0xf075714b, 40f);
        this._0x322be742.Button.onClick.AddListener(() => this._0x7a6477c2());
        this._0xacdfbd9a = _0x9dac4d45.CtaParts(this._0xae4ae1c4, _0xeba3d2e7._0xb90dd9cd(new byte[9] { 130, 148, 133, 142, 131, 148, 130, 148, 133 }, 209), _0xeba3d2e7._0xb90dd9cd(new byte[16] { 119, 96, 118, 96, 113, 5, 102, 106, 105, 105, 96, 102, 113, 108, 106, 107 }, 37), new Vector2(0.5f, 0.5f), new Vector2(250f, 0f), new Vector2(470f, 104f), _0xeb7b4f91.PlatePanel, null, _0x2861135b.BgPlate, _0x2861135b.TextPrimary, _0xf075714b, 40f);
        this._0xacdfbd9a.Button.onClick.AddListener(() => this._0x1c7d6d5a());
        this._0x5e8d5f69();
        this._0x7f7d8862(false);
    }

    private RectTransform _0xae4ae1c4;
    public void _0x7f7d8862(bool _0x93933c57)
    {
        this._0x0d7c5f06 = _0x93933c57;
        if (this._0xae4ae1c4 != null)
            this._0xae4ae1c4.gameObject.SetActive(_0x93933c57);
    }

    private void _0x5e8d5f69()
    {
        if (this._0x322be742 == null)
            return;
        bool _0xaea03d89 = _0xad4fe07f._0x35db16e9;
        if (this._0x322be742.Caption != null)
            this._0x322be742.Caption.text = _0xaea03d89 ? _0xeba3d2e7._0xb90dd9cd(new byte[12] { 109, 114, 121, 105, 122, 111, 114, 116, 117, 27, 116, 117 }, 59) : _0xeba3d2e7._0xb90dd9cd(new byte[13] { 192, 223, 212, 196, 215, 194, 223, 217, 216, 182, 217, 208, 208 }, 150);
        if (this._0x322be742.Fill != null)
            this._0x322be742.Fill.color = _0xaea03d89 ? _0x2861135b.Primary : _0x2861135b.BgPlate;
        if (this._0x322be742.Edge != null)
            this._0x322be742.Edge.color = _0xaea03d89 ? _0x2861135b.Gold : _0x2861135b.Stroke;
    }

    private void _0x7a6477c2()
    {
        _0xad4fe07f._0x35db16e9 = !_0xad4fe07f._0x35db16e9;
        _0xad4fe07f.Buzz();
        this._0x5e8d5f69();
    }

    private System.Action _0x4e0408e0;
    private _0x7e366765 _0xacdfbd9a;
    private _0x7e366765 _0x322be742;
}

internal static class _0xeba3d2e7
{
    internal static string _0xb90dd9cd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}