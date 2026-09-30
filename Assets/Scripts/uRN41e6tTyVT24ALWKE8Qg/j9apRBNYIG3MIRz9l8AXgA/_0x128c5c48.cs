using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x128c5c48 : MonoBehaviour
{
    private float _0x936e0a02 = 0.6f;
    private TMP_Text _0xd7b8a629;
    private float _0x07f8e463 = 4;
    private float _0x428f9e74;
    private List<string> _0xdf76525d = new();
    private float _0x6e424590 = 1.5f;
    private void Update()
    {
        int _0x50e5072b = 1;
        if (this._0xdf76525d.Count > 0)
        {
            string _0xb2ddad1e = this._0xd7b8a629.text;
            foreach (string _0xc5aeb6a4 in this._0xdf76525d)
                while (_0xb2ddad1e.Contains(_0xc5aeb6a4))
                    _0xb2ddad1e = _0xb2ddad1e.Replace(_0xc5aeb6a4, "");
            _0x50e5072b = _0xb2ddad1e.Length;
        }
        else
        {
            _0x50e5072b = this._0xd7b8a629.text.Length;
        }

        float _0xa08d558c = Mathf.Clamp(this._0x428f9e74 + this._0x936e0a02 * _0x50e5072b, this._0x6e424590, this._0x07f8e463);
        if (!Mathf.Approximately(this._0xb1e157cd.aspectRatio, _0xa08d558c))
            this._0xb1e157cd.aspectRatio = _0xa08d558c;
    }

    private AspectRatioFitter _0xb1e157cd;
}