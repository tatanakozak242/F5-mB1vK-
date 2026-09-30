using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xab68611e;

public class _0x279ca21b : MonoBehaviour
{
    private static void ExitGame()
    {
        Application.Quit();
    }

    private void _0x77ebb708()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x61bc701f.SCENE_0);
    }

    public Button DeleteProgressDataButton;
    public Transform Environment;
    private void _0xe5b5f19e(Transform _0xd05d5867)
    {
        Transform[] _0xf10280ec = _0xd05d5867.GetComponentsInChildren<Transform>();
        foreach (Transform _0x030c8f99 in _0xf10280ec)
            if (_0x030c8f99 != null && DOTween.IsTweening(_0x030c8f99))
            {
                if (this._0xfd2919c1)
                    DOTween.Play(_0x030c8f99);
                else
                    DOTween.Pause(_0x030c8f99);
            }
    }

    public Canvas MainCanvas;
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public Transform EnvironmentWithTweensToToggle;
    public void _0x7afb8f10(bool _0x574bb137)
    {
        this._0xfd2919c1 = _0x574bb137;
        this._0xa96879b0(!this._0xfd2919c1);
        Physics2D.simulationMode = this._0xfd2919c1 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xe5b5f19e(this.EnvironmentWithTweensToToggle);
    }

    private void _0xa96879b0(bool _0xac713e47)
    {
        Rigidbody2D[] _0xb764ba87 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x18d5a6f8 in _0xb764ba87)
            if (_0xac713e47)
                _0x18d5a6f8.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x18d5a6f8.constraints = RigidbodyConstraints2D.None;
    }

    public void LoadSceneByIndex(int _0xf916252e)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xfb505dfa(_0xf916252e));
    }

    public Button ShowResetTutorialButton;
    private static _0x5a7e3d2b _0x2669b506 => _0x5a7e3d2b.ALL_SCENES_SETTING_SINGLETONS[0];

    public static bool IsAfterLevelComplete;
    private static void MakeGrid(List<RectTransform> _0x6d2fb5a5, AspectRatioFitter _0x6438bd99, float _0x87242af3, int _0x42a5349e, int _0x81d6da68)
    {
        _0x6438bd99.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x6438bd99.aspectRatio = _0x87242af3;
        foreach (RectTransform _0x4769f40f in _0x6d2fb5a5)
        {
            int _0xaa6dbee6 = _0x4769f40f.transform.GetSiblingIndex();
            _0x4769f40f.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xaa6dbee6 % _0x42a5349e) * (1f / _0x42a5349e), (_0x81d6da68 - (Mathf.FloorToInt((float)_0xaa6dbee6 / _0x42a5349e) % _0x81d6da68 + 1f)) * (1f / _0x81d6da68));
            _0x4769f40f.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xaa6dbee6 % _0x42a5349e + 1f) * (1f / _0x42a5349e), (_0x81d6da68 - Mathf.FloorToInt((float)_0xaa6dbee6 / _0x42a5349e) % _0x81d6da68) * (1f / _0x81d6da68));
            _0x4769f40f.offsetMin = Vector2.zero;
            _0x4769f40f.offsetMax = Vector2.zero;
        }
    }

    public void _0x05d6b79f()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public void _0x036a4840()
    {
        _0x57a0446f._0x911b7d89 = true;
    }

    [HideInInspector]
    public List<_0x1b0eacd7> MoneyCountContainers = new();
    public int _0x6ea1624f => SceneManager.GetActiveScene().buildIndex;

    private void Start()
    {
        if (this._0x6ea1624f != _0x61bc701f.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x61bc701f.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x57a0446f._0x911b7d89 = false;
            _0x35837dc7.Instance._0x1058bdff();
            _0x086e6439.Instance._0x96213810(_0x74dfb94c.TUTORIAL0);
        });
    }

    public static _0x5a7e3d2b _0x57a0446f => _0x5a7e3d2b.ALL_SCENES_SETTING_SINGLETONS[Instance._0x6ea1624f];
    public bool _0xfd2919c1 { get; private set; }

    public static _0x279ca21b Instance;
    public static bool IsAfterLevelFailed = false;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x279ca21b>();
        this.RootGameObject = GameObject.FindWithTag(_0xb4f631e1._0x406d9e1e(new byte[4] { 132, 185, 185, 162 }, 214));
        if (this._0x6ea1624f == _0x61bc701f.SCENE_0)
            this._0x7afb8f10(true);
        else
            this._0x7afb8f10(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x1b0eacd7>(true).ToList();
    }

    private static _0x5a7e3d2b GAME_INDEX_SETTINGS(int _0x93ba2f89)
    {
        return _0x5a7e3d2b.ALL_SCENES_SETTING_SINGLETONS[_0x93ba2f89];
    }

    public void _0x35234921()
    {
        foreach (_0x1b0eacd7 _0x39a4b386 in this.MoneyCountContainers)
            _0x39a4b386._0xc3f24760();
    }

    private IEnumerator _0xfb505dfa(int _0x7d6cfb49)
    {
        _0x086e6439.Instance._0x96213810(_0x74dfb94c.SPLASH);
        AsyncOperation _0x3ea344db = SceneManager.LoadSceneAsync(_0x7d6cfb49);
        while (!_0x3ea344db.isDone)
            yield return null;
    }

    private IEnumerator _0xa9184f0d(string _0x68a7876d)
    {
        _0x086e6439.Instance._0x96213810(_0x74dfb94c.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x71db3bf5 = SceneManager.LoadSceneAsync(_0x68a7876d);
        while (!_0x71db3bf5.isDone)
            yield return null;
    }
}

internal static class _0xb4f631e1
{
    internal static string _0x406d9e1e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}