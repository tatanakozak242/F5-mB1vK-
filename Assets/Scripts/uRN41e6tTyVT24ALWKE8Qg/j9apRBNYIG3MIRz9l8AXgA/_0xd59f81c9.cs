using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xd59f81c9 : MonoBehaviour
{
    private TMP_Text _0x306342d9;
    private Image _0x5da40a8d;
    private void Update()
    {
        this._0xe57b3dce();
    }

    private void _0xe57b3dce()
    {
        if (this._0x5da40a8d.canvasRenderer.GetColor() != this._0x306342d9.canvasRenderer.GetColor())
            this._0x306342d9.canvasRenderer.SetColor(this._0x5da40a8d.canvasRenderer.GetColor());
    }
}