using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xfd5d95d0 : MonoBehaviour
{
    private bool _0x2e1b620f => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Start()
    {
    // Content.SetActive(false);
    }

    public Image ContentImage;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public static void HideAllPops()
    {
        _0x35837dc7.Instance._0x1058bdff();
    }

    public TMP_Text ContentMainText;
    public float scaleDuration = 0.4f;
    public bool IsScaledDownOnAwake = true;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xc60cece1();
    }

    public Ease ease = Ease.OutSine;
    public TMP_Text ContentHeaderText;
    private void _0xc60cece1()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public bool IsOnlyYScale;
    public void _0x3322cec0()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public TMP_Text ContentAdditionalText;
    public GameObject Content;
}