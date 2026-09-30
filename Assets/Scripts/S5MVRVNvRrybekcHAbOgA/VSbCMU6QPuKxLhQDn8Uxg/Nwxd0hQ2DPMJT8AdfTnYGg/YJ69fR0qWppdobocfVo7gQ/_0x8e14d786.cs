using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8e14d786 : MonoBehaviour
{
    public TMP_Text HeaderText;
    private void _0xedd6c948()
    {
        if (this.OuterBackground != null)
        {
            Image _0x9d79463d = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x9d79463d, true);
            _0x9d79463d.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public GameObject Content;
    public bool IsScaledDownOnAwake = true;
    public void _0x953a29a0()
    {
        this._0x38a89961();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public TMP_Text MainText;
    public float ScaleDuration = 0.4f;
    public GameObject OuterBackground;
    public Ease Ease = Ease.OutSine;
    public void _0xba524d68()
    {
        this._0xd9d64322();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x086e6439.Instance._0x669a1d3f(_0x086e6439.Instance.CurrentPanelIndex);
    }

    private bool _0x7e592d55 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public void Show()
    {
        this._0x25764147();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x086e6439.Instance._0x669a1d3f(_0x086e6439.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0xd9d64322()
    {
        if (this.OuterBackground != null)
        {
            Image _0x27f4c17e = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x27f4c17e, true);
            _0x27f4c17e.DOFade(1f, 0f);
        }
    }

    private void _0x25764147()
    {
        if (this.OuterBackground != null)
        {
            Image _0xf7107443 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xf7107443, true);
            _0xf7107443.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xedd6c948();
    }

    private void _0x38a89961()
    {
        if (this.OuterBackground != null)
        {
            Image _0x34d1029d = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x34d1029d, true);
            _0x34d1029d.DOFade(0f, this.ScaleDuration);
        }
    }
}