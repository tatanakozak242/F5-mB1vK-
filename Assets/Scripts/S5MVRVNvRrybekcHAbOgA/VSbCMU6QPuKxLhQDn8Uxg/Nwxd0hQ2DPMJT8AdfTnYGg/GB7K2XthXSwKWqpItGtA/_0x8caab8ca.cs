using UnityEngine;
using UnityEngine.UI;

public class _0x8caab8ca : MonoBehaviour
{
    public bool IsPhysicsRunOnClick;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x279ca21b.Instance._0x7afb8f10(this.IsPhysicsRunOnClick));
    }
}