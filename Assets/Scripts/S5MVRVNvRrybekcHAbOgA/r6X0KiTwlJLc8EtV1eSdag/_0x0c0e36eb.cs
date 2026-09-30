using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x0c0e36eb : MonoBehaviour
{
    private Touch? _0xa6374531()
    {
        if (!_0x279ca21b.Instance._0xfd2919c1)
            return null;
        foreach (Touch _0xde0e9ecb in Touch.activeTouches)
            if (_0xde0e9ecb.ended)
                if (this._0xcc57e625(_0xde0e9ecb))
                    return _0xde0e9ecb;
        return null;
    }

    private bool _0xcc57e625(Touch? _0x0eb27484)
    {
        if (!_0x0eb27484.HasValue)
            return false;
        Vector3 _0x842d5def = Camera.main.ScreenToWorldPoint(_0x0eb27484.Value.screenPosition);
        Vector3 _0x624114e6 = _0x842d5def;
        _0x624114e6.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x624114e6))
            return true;
        _0x0eb27484 = null;
        return false;
    }

    private bool _0xf9c0c2f0(Touch? _0xdcde323d, Bounds _0x83dea7e4, TouchPhase _0xbdc78109)
    {
        if (!_0x279ca21b.Instance._0xfd2919c1)
        {
            _0xdcde323d = null;
            return false;
        }

        if (_0xdcde323d != null)
            if (_0xdcde323d.Value.phase == _0xbdc78109)
            {
                Vector3 _0xd556ac3d = Camera.main.ScreenToWorldPoint(_0xdcde323d.Value.screenPosition);
                Vector3 _0xc01d34c9 = new(_0xd556ac3d.x, _0xd556ac3d.y, _0x83dea7e4.center.z);
                if (_0x83dea7e4.Contains(_0xc01d34c9) && this._0xcc57e625(_0xdcde323d.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x012fa099(Bounds _0x7b12407b)
    {
        if (!_0x279ca21b.Instance._0xfd2919c1)
            return null;
        foreach (Touch _0xfcb74461 in Touch.activeTouches)
            if (_0xfcb74461.ended)
            {
                Vector3 _0xe8450ce9 = Camera.main.ScreenToWorldPoint(_0xfcb74461.screenPosition);
                Vector3 _0x5888e44f = new(_0xe8450ce9.x, _0xe8450ce9.y, _0x7b12407b.center.z);
                if (_0x7b12407b.Contains(_0x5888e44f) && this._0xcc57e625(_0xfcb74461))
                    return _0xfcb74461;
            }

        return null;
    }

    private void _0xcad402f2(Touch? _0x51f80117)
    {
        if (!_0x279ca21b.Instance._0xfd2919c1)
        {
            _0x51f80117 = null;
            return;
        }

        int _0x6f9767d5 = _0x51f80117.Value.touchId;
        _0x51f80117 = Touch.activeTouches.FirstOrDefault(_0xa9b4f8b1 => _0xa9b4f8b1.touchId == _0x6f9767d5);
        if (!this._0xcc57e625(_0x51f80117.Value))
            _0x51f80117 = null;
    }

    private Touch? _0x7ff12689()
    {
        if (!_0x279ca21b.Instance._0xfd2919c1)
            return null;
        foreach (Touch _0x88272016 in Touch.activeTouches)
            if (!_0x88272016.ended)
                if (this._0xcc57e625(_0x88272016))
                    return _0x88272016;
        return null;
    }

    private Touch? _0x21fb5735(Bounds _0x39954d35)
    {
        if (!_0x279ca21b.Instance._0xfd2919c1)
            return null;
        foreach (Touch _0x4abb5e35 in Touch.activeTouches)
            if (!_0x4abb5e35.ended)
            {
                Vector3 _0x71761875 = Camera.main.ScreenToWorldPoint(_0x4abb5e35.screenPosition);
                Vector3 _0x26fcd46f = new(_0x71761875.x, _0x71761875.y, _0x39954d35.center.z);
                if (_0x39954d35.Contains(_0x26fcd46f) && this._0xcc57e625(_0x4abb5e35))
                    return _0x4abb5e35;
            }

        return null;
    }

    private Touch? _0xffee065e(Bounds _0x6f77fb79, TouchPhase _0x54c6c01b)
    {
        if (!_0x279ca21b.Instance._0xfd2919c1)
            return null;
        foreach (Touch _0x67cd0594 in Touch.activeTouches)
            if (_0x67cd0594.phase == _0x54c6c01b)
            {
                Vector3 _0x511eee0e = Camera.main.ScreenToWorldPoint(_0x67cd0594.screenPosition);
                Vector3 _0xb0af76ce = new(_0x511eee0e.x, _0x511eee0e.y, _0x6f77fb79.center.z);
                if (_0x6f77fb79.Contains(_0xb0af76ce) && this._0xcc57e625(_0x67cd0594))
                    return _0x67cd0594;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xfca8a016 = this.gameObject.GetComponent<_0x0c0e36eb>();
    }

    private static _0x0c0e36eb _0xfca8a016;
    public BoxCollider2D CameraTouchBounds;
}