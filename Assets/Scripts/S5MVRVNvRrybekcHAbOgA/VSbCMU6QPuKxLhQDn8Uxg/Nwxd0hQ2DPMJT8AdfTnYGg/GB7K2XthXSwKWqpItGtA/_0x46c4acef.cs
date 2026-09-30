using UnityEngine;
using UnityEngine.UI;

public class _0x46c4acef : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int PopToShowIndex;
    public Button Button;
    public bool IsHideAllPops;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x35837dc7.Instance._0x5cd857ce();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x35837dc7.Instance._0x1058bdff());
        else
            this.Button.onClick.AddListener(() => _0x35837dc7.Instance._0x028b3e26(this.PopToShowIndex));
    }

    public bool IsShowLastPop;
}