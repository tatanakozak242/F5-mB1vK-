using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xab68611e;

public class _0x35837dc7 : MonoBehaviour
{
    public static _0x35837dc7 Instance;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x35837dc7>();
    }

    public List<int> LastPopIndexes = new();
    public void _0x028b3e26(int _0x055735b8)
    {
        this.CurrentPopIndex = _0x055735b8;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x308df281(true);
        this._0xd728b47e();
        this.Pops[_0x055735b8].Show();
        foreach (GameObject _0x2ed92ea0 in this.GameObjectsToHide)
            _0x2ed92ea0.SetActive(false);
    }

    public List<_0xfd5d95d0> Pops;
    public _0xfd5d95d0 _0x52763680(int _0x39533e99)
    {
        return this.Pops[_0x39533e99];
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xfd5d95d0 _0xdd9dd191 in this.Pops)
            if (_0xdd9dd191 != null)
                _0xdd9dd191.gameObject.SetActive(true);
    }

    public GameObject BlurBackground;
    private void _0x21f083a2()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public List<GameObject> GameObjectsToHide;
    public void _0x1058bdff()
    {
        this.LastPopIndexes.Clear();
        this._0x308df281();
        foreach (GameObject _0x5659f28d in this.GameObjectsToHide)
            if (_0x5659f28d != null)
                _0x5659f28d.SetActive(true);
        this._0x21f083a2();
    }

    private void _0x308df281(bool _0x3b5cdda2 = false)
    {
        for (int _0x406ac04f = 0; _0x406ac04f < this.Pops.Count; ++_0x406ac04f)
            if (this.Pops[_0x406ac04f] != null && !(_0x406ac04f == this.CurrentPopIndex && _0x3b5cdda2))
                this.Pops[_0x406ac04f]._0x3322cec0();
    }

    public float ScaleDuration = 0.4f;
    public int CurrentPopIndex;
    public void _0x5cd857ce()
    {
        this.LastPopIndexes.RemoveAll(_0x693263f9 => _0x693263f9 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x1058bdff();
        else
            this._0x028b3e26(this.LastPopIndexes.Last());
    }

    private void _0xd728b47e()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }
}