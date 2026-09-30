using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xe7cafbca : MonoBehaviour
{
    public static _0xe7cafbca Instance;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xab68611e._0x61bc701f.SCENE_0 && !_0x08c2d206)
        {
            this._0x5172b82c();
        }
        else
        {
            this._0xcc545af3();
        }
    }

    public GameObject Content;
    public void _0xcc545af3()
    {
        this._0x8a3c5d2f();
        bool _0x9f1b4a4d = _0x08c2d206;
        this.AnimSliderSequence = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x01f7b52b => this.AnimationSlider.value = _0x01f7b52b, _0x9f1b4a4d ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x08c2d206 = !_0x08c2d206;
    }

    public GameObject Background;
    public float DefaultAnimationTime = 0.4f;
    public float FirstAnimationTime = 10.0f;
    public float SecondPassSliderValue = 0.5f;
    public Sequence AnimSliderSequence;
    private static bool _0x08c2d206 = false;
    public GameObject Error;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xe7cafbca>();
    }

    public void _0x8a3c5d2f()
    {
        this.AnimSliderSequence?.Kill();
        this.AnimationSlider.value = _0x08c2d206 ? this.SecondPassSliderValue : 0.05f;
    }

    public void _0xce7b02e4()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this.AnimSliderSequence?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x08c2d206 = false;
    }

    private void _0x5172b82c()
    {
        this.AnimationSlider.value = 0.05f;
        _0x08c2d206 = !_0x08c2d206;
        this.AnimSliderSequence = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x01f7b52b => this.AnimationSlider.value = _0x01f7b52b, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            if (!_0xdf35893b._0x20d63bf4._0xacdd5220)
            {
                {
#if B_LOGS
                    {
                        Debug.Log($"[Test] Timer out -> move to scene");
                    }
#endif
                }

                _0xdf35893b._0x20d63bf4._0x70f889de();
            }
        });
    }

    public Slider AnimationSlider;
}