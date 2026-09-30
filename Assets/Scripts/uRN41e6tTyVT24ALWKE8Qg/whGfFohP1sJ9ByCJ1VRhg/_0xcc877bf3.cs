using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xcc877bf3 : MonoBehaviour
{
    private static void SafeAreaChanged()
    {
        _0x888da28e = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private void Start()
    {
    }

    private static Rect _0x888da28e = Rect.zero;
    private static Vector2 _0x5dbf1bf4 = Vector2.zero;
    private void Awake()
    {
        if (!_0x819b563e.Contains(this))
            _0x819b563e.Add(this);
        this._0xc1f9eb10 = this.GetComponent<Canvas>();
        this._0xf2f27042 = this.GetComponent<CanvasScaler>();
        if (this._0xf2f27042 != null)
            this._0xe8c95007 = this._0xf2f27042.referenceResolution;
        this._0xa5c7f25b = this.GetComponent<RectTransform>();
        this._0xd40519b2 = this.transform.Find(_0x858031df._0xa70824fa(new byte[8] { 102, 84, 83, 80, 116, 71, 80, 84 }, 53)) as RectTransform;
        if (!_0x300bdf30)
        {
            _0x8e5a785c = Screen.orientation;
            _0x5dbf1bf4.x = Screen.width;
            _0x5dbf1bf4.y = Screen.height;
            _0x888da28e = Screen.safeArea;
            _0x300bdf30 = true;
        }

        this._0x080f5470();
    }

    private static UnityEvent _0x8db9bcbc = new();
    private static void OrientationChanged()
    {
        _0x8e5a785c = Screen.orientation;
        _0x5dbf1bf4.x = Screen.width;
        _0x5dbf1bf4.y = Screen.height;
        _0x888da28e = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x8db9bcbc.Invoke();
    }

    private static bool _0x300bdf30;
    private Vector2 _0xe8c95007;
    private void Update()
    {
        if (_0x819b563e.Count == 0 || _0x819b563e[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x8e5a785c)
            OrientationChanged();
        if (Screen.safeArea != _0x888da28e)
            SafeAreaChanged();
        if (Screen.width != _0x5dbf1bf4.x || Screen.height != _0x5dbf1bf4.y)
            ResolutionChanged();
    }

    private RectTransform _0xa5c7f25b;
    private CanvasScaler _0xf2f27042;
    private static readonly List<_0xcc877bf3> _0x819b563e = new();
    private static ScreenOrientation _0x8e5a785c = ScreenOrientation.LandscapeLeft;
    private void _0x080f5470()
    {
        if (this._0xd40519b2 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x6f7e2a93 = Screen.safeArea;
        Vector2 _0x50b5f9ef = _0x6f7e2a93.position;
        Vector2 _0x59c2e38d = _0x6f7e2a93.position + _0x6f7e2a93.size;
        _0x50b5f9ef.x /= screenWidth;
        _0x50b5f9ef.y /= screenHeight;
        _0x59c2e38d.x /= screenWidth;
        _0x59c2e38d.y /= screenHeight;
        this._0xd40519b2.anchorMin = _0x50b5f9ef;
        this._0xd40519b2.anchorMax = _0x59c2e38d;
        this._0xd40519b2.offsetMin = Vector2.zero;
        this._0xd40519b2.offsetMax = Vector2.zero;
        if (this._0xf2f27042 == null)
            return;
        Vector2 _0xdfd79754 = _0x59c2e38d - _0x50b5f9ef;
        float _0x242f7483 = 2f - _0xdfd79754.x;
        float _0xd8346be3 = 2f - _0xdfd79754.y;
        this._0xf2f27042.referenceResolution = this._0xe8c95007 * new Vector2(_0x242f7483, _0xd8346be3);
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x7668373c = 0; _0x7668373c < _0x819b563e.Count; _0x7668373c++)
            _0x819b563e[_0x7668373c]._0x080f5470();
    }

    private static void ResolutionChanged()
    {
        _0x5dbf1bf4.x = Screen.width;
        _0x5dbf1bf4.y = Screen.height;
        _0x888da28e = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x8db9bcbc.Invoke();
    }

    private Canvas _0xc1f9eb10;
    private RectTransform _0xd40519b2;
    private void OnDestroy()
    {
        if (_0x819b563e != null && _0x819b563e.Contains(this))
            _0x819b563e.Remove(this);
    }
}

internal static class _0x858031df
{
    internal static string _0xa70824fa(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}