using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x44dc1119 : MonoBehaviour
{
    public bool IsLoadCurrentScene;
    public int LoadSceneId;
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x279ca21b.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x279ca21b.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}