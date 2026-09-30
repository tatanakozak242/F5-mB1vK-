using TMPro;
using UnityEngine;
using static _0xab68611e;

public class _0x1b0eacd7 : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    public void _0xc3f24760()
    {
        this.MoneyCountText.text = _0x651c7180._0x022bcc30.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x014d061f;
            if (this.gameObject.TryGetComponent(out _0x014d061f))
                this.MoneyCountText = _0x014d061f;
        }

        this._0xc3f24760();
    }
}