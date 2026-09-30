using UnityEngine;
using UnityEngine.UI;

public class _0x13b93af8 : MonoBehaviour
{
    public Button TutorialEndButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x086e6439.Instance._0x96213810(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x279ca21b.Instance._0x036a4840());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x086e6439.Instance._0x96213810(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x086e6439.Instance._0x96213810(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x279ca21b.Instance._0x036a4840());
        }
    }

    public bool IsTutorialEndPanel;
    public int EndTutorialPanelIndex = 1;
    public int NextTutorialPanelIndex;
    public Button NextTutorialButton;
}