using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x88b9ab4c : MonoBehaviour
{
    private static readonly List<_0x88b9ab4c> _0x95183833 = new();
    private Canvas _0x6d98f070;
    private void Awake()
    {
        if (!_0x95183833.Contains(this))
            _0x95183833.Add(this);
        this._0x6d98f070 = this.GetComponent<Canvas>();
        this._0xc304f1e0 = this.GetComponent<RectTransform>();
        this._0x267e7bf2 = this.transform.Find(_0x0440df72._0x69f0fca0(new byte[8] { 207, 253, 250, 249, 221, 238, 249, 253 }, 156)) as RectTransform;
        if (!_0x9b109227)
        {
            _0x193cfdd9 = Screen.orientation;
            _0x65da81ce.x = Screen.width;
            _0x65da81ce.y = Screen.height;
            _0x4844bffc = Screen.safeArea;
            _0x9b109227 = true;
        }

        this._0x61cdfc01();
    }

    private void OnDestroy()
    {
        if (_0x95183833 != null && _0x95183833.Contains(this))
            _0x95183833.Remove(this);
    }

    private static void ResolutionChanged()
    {
        _0x65da81ce.x = Screen.width;
        _0x65da81ce.y = Screen.height;
        _0x47649cbd.Invoke();
    }

    private static bool _0x9b109227;
    private static Rect _0x4844bffc = Rect.zero;
    private void _0x61cdfc01()
    {
        if (this._0x267e7bf2 == null)
            return;
        Rect _0xf68bad2e = Screen.safeArea;
        Vector2 _0x2509f077 = _0xf68bad2e.position;
        Vector2 _0x5aa236d8 = _0xf68bad2e.position + _0xf68bad2e.size;
        _0x2509f077.x /= this._0x6d98f070.pixelRect.width;
        _0x2509f077.y /= this._0x6d98f070.pixelRect.height;
        _0x5aa236d8.x /= this._0x6d98f070.pixelRect.width;
        _0x5aa236d8.y /= this._0x6d98f070.pixelRect.height;
        this._0x267e7bf2.anchorMin = _0x2509f077;
        this._0x267e7bf2.anchorMax = _0x5aa236d8;
    }

    private static Vector2 _0x65da81ce = Vector2.zero;
    private RectTransform _0x267e7bf2;
    private void Update()
    {
        if (_0x95183833[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x193cfdd9)
            OrientationChanged();
        if (Screen.safeArea != _0x4844bffc)
            SafeAreaChanged();
        if (Screen.width != _0x65da81ce.x || Screen.height != _0x65da81ce.y)
            ResolutionChanged();
    }

    private static void OrientationChanged()
    {
        _0x193cfdd9 = Screen.orientation;
        _0x65da81ce.x = Screen.width;
        _0x65da81ce.y = Screen.height;
        _0x47649cbd.Invoke();
    }

    private static UnityEvent _0x47649cbd = new();
    private static ScreenOrientation _0x193cfdd9 = ScreenOrientation.LandscapeLeft;
    private RectTransform _0xc304f1e0;
    private static void SafeAreaChanged()
    {
        _0x4844bffc = Screen.safeArea;
        for (int _0x9205759a = 0; _0x9205759a < _0x95183833.Count; _0x9205759a++)
            _0x95183833[_0x9205759a]._0x61cdfc01();
    }
}

internal static class _0x0440df72
{
    internal static string _0x69f0fca0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}