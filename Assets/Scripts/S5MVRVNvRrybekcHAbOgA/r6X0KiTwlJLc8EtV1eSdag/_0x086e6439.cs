using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xab68611e;

public class _0x086e6439 : MonoBehaviour
{
    public void _0x669a1d3f(int _0xa47e07d6)
    {
        if (_0xa47e07d6 == _0x74dfb94c.SPLASH && _0x279ca21b.Instance._0x6ea1624f != _0x61bc701f.SCENE_0)
            _0xe7cafbca.Instance._0xcc545af3();
        if (_0x279ca21b.Instance._0x6ea1624f != _0x61bc701f.SCENE_0)
        {
            if (_0xa47e07d6 == _0x74dfb94c.SPLASH || _0xa47e07d6 == _0x74dfb94c.TUTORIAL0)
                _0x279ca21b.Instance._0x7afb8f10(false);
            else if (_0xa47e07d6 == _0x74dfb94c.DEFAULT)
                _0x279ca21b.Instance._0x7afb8f10(true);
        }
    }

    private void _0x7aa85c52(int _0x816a025b)
    {
        this._0xa212632a(_0x816a025b);
        this._0x3db53e5f(_0x816a025b);
        this.CurrentPanelIndex = _0x816a025b;
        this.Panels[_0x816a025b]._0xba524d68();
    }

    public static _0x086e6439 Instance;
    public List<_0x8e14d786> Panels;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public float StaticBlurMaterialInitialValue;
    public float ScaleDuration = 0.4f;
    private void _0x6e136580()
    {
        this._0x7aa85c52(_0x74dfb94c.SPLASH);
        if (_0x279ca21b.Instance._0x6ea1624f == _0x61bc701f.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xe7cafbca.Instance.DefaultAnimationTime);
        }
    }

    private void SwitchSplash()
    {
        if (_0x22ba7dd5.Instance.IsTutorialEnabled && !_0x279ca21b._0x57a0446f._0x911b7d89)
            this._0x96213810(_0x74dfb94c.TUTORIAL0);
        else
            this._0x96213810(_0x74dfb94c.DEFAULT);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x086e6439>();
    }

    private void _0xa212632a(int _0x4e0b9104)
    {
        this.LastPanelIndexes.Add(_0x4e0b9104);
        this.CurrentPanelIndex = _0x4e0b9104;
        for (int _0xc8d02975 = 0; _0xc8d02975 < this.Panels.Count; _0xc8d02975++)
            if (_0xc8d02975 != _0x4e0b9104 && this.Panels[_0xc8d02975] != null)
                this.Panels[_0xc8d02975]._0x953a29a0();
    }

    private void _0x3db53e5f(int _0xc7c29ec5)
    {
        if (_0xc7c29ec5 == _0x74dfb94c.SPLASH)
            _0xe7cafbca.Instance._0x8a3c5d2f();
        if (_0x279ca21b.Instance._0x6ea1624f == _0x61bc701f.SCENE_0)
        {
        }
    }

    public void _0x562aaa05()
    {
        this.LastPanelIndexes.RemoveAll(_0x693263f9 => _0x693263f9 == this.CurrentPanelIndex);
        int _0x782289a6 = this.LastPanelIndexes.Last();
        this._0x3db53e5f(_0x782289a6);
        this._0xb0550657(_0x782289a6);
        this.CurrentPanelIndex = _0x782289a6;
        this.Panels[_0x782289a6].Show();
    }

    private _0x8e14d786 _0xaa3cc199(int _0x43c14ad6)
    {
        return this.Panels[_0x43c14ad6];
    }

    public void _0x96213810(int _0x1047debf)
    {
        this._0xa212632a(_0x1047debf);
        this._0x3db53e5f(_0x1047debf);
        this.CurrentPanelIndex = _0x1047debf;
        this.Panels[_0x1047debf].Show();
    }

    public int CurrentPanelIndex;
    private void Start()
    {
        this._0x6e136580();
    }

    private void _0xb0550657(int _0x90b4cbd5)
    {
        this.LastPanelIndexes.Add(_0x90b4cbd5);
        this.CurrentPanelIndex = _0x90b4cbd5;
        for (int _0xadb9848d = 0; _0xadb9848d < this.Panels.Count; _0xadb9848d++)
            if (_0xadb9848d != _0x90b4cbd5 && this.Panels[_0xadb9848d] != null)
                this.Panels[_0xadb9848d]._0x953a29a0();
    }

    public bool IsShowSplashOnStart = true;
}