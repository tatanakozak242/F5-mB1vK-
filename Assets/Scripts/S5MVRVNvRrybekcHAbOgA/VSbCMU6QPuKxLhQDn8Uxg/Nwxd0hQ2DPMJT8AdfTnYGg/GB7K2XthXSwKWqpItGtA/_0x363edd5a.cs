using UnityEngine;
using UnityEngine.UI;

public class _0x363edd5a : MonoBehaviour
{
    private Button _0x4889d30d;
    private void Start()
    {
        if (this._0xf75cf763)
            this._0x4889d30d.onClick.AddListener(() => _0x086e6439.Instance._0x562aaa05());
        else
            this._0x4889d30d.onClick.AddListener(() => _0x086e6439.Instance._0x96213810(this._0x754bf900));
    }

    private int _0x754bf900;
    private void Awake()
    {
        if (this._0x4889d30d == null)
            if (!this.TryGetComponent(out this._0x4889d30d))
                this._0x4889d30d = this.GetComponentInChildren<Button>();
    }

    private bool _0xf75cf763;
}