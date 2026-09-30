using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using ETouch = UnityEngine.InputSystem.EnhancedTouch.Touch;

/// <summary>
/// Runs one evening at the carnival: the spotlights come up on a finished mask, the
/// stage goes dark, and the player rebuilds that mask from the fragment tray before the
/// memory bar runs out. Eight performances, three misses.
///
/// The whole stage is built here from serialized art and camera-derived sizes, so the
/// scene template is never asked to carry this game's content (rule C.2), and the three
/// result cards are fetched by index and dressed before they are raised (rule C.3).
/// </summary>
public sealed class _0x0b72c3c7 : MonoBehaviour
{
    [SerializeField]
    private GameObject _platePrefab;
    [SerializeField]
    private GameObject _chipPrefab;
    private void _0x42a24a27(int _0xbd613d21)
    {
        if (_0xbd613d21 < 0 || this._0xbb012171 >= this._0x85d7cfcf.SlotOrder.Length)
            return;
        int _0x13d78b0d = this._0x85d7cfcf.SlotOrder[this._0xbb012171];
        int _0xf9eca670 = this._0x99cfe7e3._0x762caf85(_0xbd613d21);
        int _0x721167a7 = this._0x99cfe7e3._0xc0fdc1ae(_0xbd613d21);
        bool _0x39203eae = _0xf9eca670 == _0x13d78b0d && _0x721167a7 == this._0x85d7cfcf.SampleVariants[_0x13d78b0d];
        if (!_0x39203eae)
        {
            this._0x99cfe7e3._0x7972d7e9(_0xbd613d21);
            this._0x7d27c9e9._0xbfdff817();
            this._0xe39fd4de._0x4c6a35d1(_0x2861135b.Accent);
            this._0xcda92605++;
            this._0x89bf28cb(false);
            return;
        }

        Vector3 _0xb4e9e663 = this._0x99cfe7e3._0x7ff6bc3f(_0xbd613d21);
        this._0x99cfe7e3._0xdd1212e0(_0xbd613d21);
        this._0x7d27c9e9._0xeaed81f0(_0xf9eca670, _0x721167a7, _0xb4e9e663);
        this._0xe39fd4de._0x4c6a35d1(_0x2861135b.Success);
        _0xad4fe07f.Buzz();
        this._0xc43e4121 = Mathf.Min(this._0x445a6475, this._0xc43e4121 + _0x2861135b.RecallBonusSeconds);
        this._0xbb012171++;
        if (this._0xbb012171 >= this._0x85d7cfcf.SlotOrder.Length)
        {
            this._0xc5c4606f();
            return;
        }

        this._0xc66b7137();
    }

    private bool _0xfe48658b;
    private enum _0x95303580
    {
        Waiting,
        Lighting,
        Darkening,
        Rebuilding,
        Settling,
        Curtain,
    }

    private void _0x019b40de()
    {
        if (_0x279ca21b.Instance == null)
            return;
        _0x279ca21b.Instance._0x7afb8f10(true);
        _0x279ca21b.Instance.LoadSceneByIndex(_0xab68611e._0x61bc701f.SCENE_1);
    }

    [SerializeField]
    private Sprite _platePanel;
    private int _0x00a4fa9a;
    private void _0x597eed72()
    {
        int _0xbace4df1 = _0x2861135b.Row(this._0x00a4fa9a);
        float _0xc418fb18 = _0x2861135b.RecallSeconds[_0xbace4df1];
        if (_0xad4fe07f._0x85d27dab)
            _0xc418fb18 *= _0x2861135b.MidnightRecallScale;
        this._0x7d27c9e9._0xae2c4a25();
        this._0x99cfe7e3._0x5877c517(this._0x85d7cfcf);
        this._0x445a6475 = _0xc418fb18;
        this._0xc43e4121 = _0xc418fb18;
        this._0x5fd3083e = _0x95303580.Rebuilding;
        this._0xc66b7137();
    }

    private readonly _0x9133d900 _0x1af207be = new _0x9133d900();
    [SerializeField]
    private Sprite _silhouette;
    [SerializeField]
    private Sprite _brandMark;
    [SerializeField]
    private Sprite _burstSpark;
    [SerializeField]
    private Sprite _chipBase;
    private void _0xaa57f062()
    {
        this._0x5fd3083e = _0x95303580.Curtain;
        this._0x99cfe7e3._0x71aa42b5();
        if (_0x279ca21b.Instance != null)
            _0x279ca21b.Instance._0x7afb8f10(false);
        _0xfd5d95d0 _0xd1d9559e = _0x35837dc7.Instance._0x52763680(_0xab68611e._0xb6633f3a.LOSE);
        this._0x6d40f315.Dress(_0xd1d9559e, _0x0568c71b._0x15debffc(new byte[12] { 224, 236, 254, 230, 141, 233, 255, 226, 253, 253, 232, 233 }, 173), _0x2861135b.Accent, _0x0568c71b._0x15debffc(new byte[24] { 41, 53, 47, 56, 56, 93, 48, 52, 46, 46, 56, 46, 93, 52, 51, 93, 50, 51, 56, 93, 46, 53, 50, 42 }, 125), _0x0568c71b._0x15debffc(new byte[14] { 56, 52, 38, 62, 38, 85, 56, 52, 33, 54, 61, 48, 49, 85 }, 117) + this._0x00a4fa9a + _0x0568c71b._0x15debffc(new byte[3] { 143, 128, 143 }, 175) + _0x2861135b.PerformanceGoal, _0x0568c71b._0x15debffc(new byte[5] { 194, 213, 196, 194, 201 }, 144), () => this._0x019b40de(), _0x0568c71b._0x15debffc(new byte[9] { 87, 84, 86, 94, 70, 65, 84, 82, 80 }, 21), () => this._0x3cd1b4c2());
        _0x35837dc7.Instance._0x028b3e26(_0xab68611e._0xb6633f3a.LOSE);
    }

    [SerializeField]
    private Sprite _iconClose;
    private void _0x3cd1b4c2()
    {
        if (_0x279ca21b.Instance == null)
            return;
        _0x279ca21b.Instance._0x7afb8f10(true);
        _0x279ca21b.Instance.LoadSceneByIndex(_0xab68611e._0x61bc701f.SCENE_0);
    }

    private int _0xcda92605;
    [SerializeField]
    private Sprite _spotlightCone;
    private int _0xbb012171;
    private int _0x203833ef;
    private _0x9109e422 _0xd0479f85;
    [SerializeField]
    private Sprite[] _plumeSprites = new Sprite[0];
    [SerializeField]
    private Sprite _stageFloor;
    /// <summary>A missed recall costs a token; the same performance is re-dealt fresh.</summary>
    private void _0x89bf28cb(bool _0x67fa4fae)
    {
        if (_0x67fa4fae)
        {
            this._0x203833ef++;
            if (this._0xd4fde6fa != null)
                this._0xd4fde6fa._0x1d95b6ae(this._0x203833ef);
            _0xad4fe07f.Buzz();
            if (this._0x203833ef >= _0x2861135b.MissesAllowed)
            {
                this._0xaa57f062();
                return;
            }

            this._0x1cc3ea50(this._0x00a4fa9a, this._0x91b7f730 + 1);
            return;
        }

        this._0x203833ef++;
        if (this._0xd4fde6fa != null)
            this._0xd4fde6fa._0x1d95b6ae(this._0x203833ef);
        _0xad4fe07f.Buzz();
        if (this._0x203833ef >= _0x2861135b.MissesAllowed)
            this._0xaa57f062();
    }

    private float _0x445a6475 = 1f;
    [SerializeField]
    private GameObject _conePrefab;
    [SerializeField]
    private Sprite[] _eyeSprites = new Sprite[0];
    [SerializeField]
    private Sprite _maskHero;
    private void _0xdeb32301()
    {
        this._0x7d27c9e9._0x691b5245();
        this._0xe39fd4de._0xad2aa149(false);
        this._0x445a6475 = _0x2861135b.BlackoutSeconds;
        this._0xc43e4121 = _0x2861135b.BlackoutSeconds;
        this._0x5fd3083e = _0x95303580.Darkening;
    }

    private void _0xe4ff1b9f(Transform _0xb2e306db)
    {
        for (int _0xc93b7bef = _0xb2e306db.childCount - 1; _0xc93b7bef >= 0; _0xc93b7bef--)
        {
            Transform _0x9aa1eefc = _0xb2e306db.GetChild(_0xc93b7bef);
            if (_0x9aa1eefc == null)
                continue;
            if (_0x9aa1eefc.GetComponentInChildren<_0xfd5d95d0>(true) != null)
                continue;
            _0x9aa1eefc.gameObject.SetActive(false);
        }
    }

    private _0x8a012195 _0x99cfe7e3;
    private void _0x6ca33e76()
    {
        _0x35837dc7.Instance._0x1058bdff();
        this._0xb8f55e56 = false;
        if (_0x279ca21b.Instance != null)
            _0x279ca21b.Instance._0x7afb8f10(true);
    }

    [SerializeField]
    private GameObject _slotPrefab;
    private _0x95303580 _0x5fd3083e = _0x95303580.Waiting;
    private _0xbe9350c0 _0xe39fd4de;
    private _0x16ed97a7 _0xd4fde6fa;
    private void Start()
    {
        float _0x6be23d58 = _0x1bfd6668.HalfHeight(this._0xeb4d7d4f);
        float _0x1ee874ab = _0x1bfd6668.HalfWidth(this._0xeb4d7d4f);
        GameObject _0x2c40dd15 = new GameObject(_0x0568c71b._0x15debffc(new byte[8] { 255, 216, 205, 203, 201, 254, 197, 203 }, 172));
        _0x2c40dd15.transform.SetParent(this.transform, false);
        this._0xe39fd4de = _0x2c40dd15.AddComponent<_0xbe9350c0>();
        this._0xe39fd4de._0x0a539800(this._0xd0479f85, this._0x0a2c8865, _0x1ee874ab, _0x6be23d58);
        GameObject _0x01edca3c = new GameObject(_0x0568c71b._0x15debffc(new byte[9] { 125, 90, 79, 73, 75, 109, 79, 93, 90 }, 46));
        _0x01edca3c.transform.SetParent(this.transform, false);
        this._0x7d27c9e9 = _0x01edca3c.AddComponent<_0x03bcc995>();
        this._0x7d27c9e9._0xcfe151f4(this._0xd0479f85, this._0x0a2c8865, _0x1ee874ab, _0x6be23d58);
        GameObject _0xc9f54cac = new GameObject(_0x0568c71b._0x15debffc(new byte[9] { 116, 83, 70, 64, 66, 115, 85, 70, 94 }, 39));
        _0xc9f54cac.transform.SetParent(this.transform, false);
        this._0x99cfe7e3 = _0xc9f54cac.AddComponent<_0x8a012195>();
        this._0x99cfe7e3._0xeb0b9e48(this._0xd0479f85, this._0x0a2c8865, _0x1ee874ab);
        _0x9dac4d45.SanitiseTutorials(this._font);
        this._0x6d40f315 = this.gameObject.AddComponent<_0x31f7df7e>();
        this._0x6d40f315._0x32eb646b(this._0xd0479f85, this._font);
        Transform _0xf9a9fe9d = this._0x3a68df0f();
        if (_0xf9a9fe9d != null)
        {
            this._0xe4ff1b9f(_0xf9a9fe9d);
            GameObject _0x4180b1b2 = new GameObject(_0x0568c71b._0x15debffc(new byte[12] { 127, 88, 77, 75, 73, 100, 89, 72, 100, 67, 95, 88 }, 44), typeof(RectTransform));
            _0x4180b1b2.transform.SetParent(_0xf9a9fe9d, false);
            // A fresh RectTransform is 100x100 at the centre; stretch it over the panel
            // so every HUD anchor below resolves against the real 1242x2688 canvas.
            RectTransform _0x32cbb150 = _0x4180b1b2.GetComponent<RectTransform>();
            _0x32cbb150.anchorMin = Vector2.zero;
            _0x32cbb150.anchorMax = Vector2.one;
            _0x32cbb150.pivot = new Vector2(0.5f, 0.5f);
            _0x32cbb150.anchoredPosition = Vector2.zero;
            _0x32cbb150.sizeDelta = Vector2.zero;
            _0x32cbb150.localScale = Vector3.one;
            this._0xd4fde6fa = _0x4180b1b2.AddComponent<_0x16ed97a7>();
            this._0xd4fde6fa.Build(_0x4180b1b2.transform, this._0xd0479f85, this._font, () => this._0x3cd1b4c2(), () => this._0x1b609129());
        }

        this._0xfe48658b = true;
        this._0x1cc3ea50(0, 0);
    }

    private _0x48681af8 _0x85d7cfcf;
    private void Update()
    {
        if (!this._0xfe48658b || this._0xb8f55e56 || this._0x5fd3083e == _0x95303580.Curtain || this._0x5fd3083e == _0x95303580.Waiting)
            return;
        if (_0x279ca21b.Instance != null && !_0x279ca21b.Instance._0xfd2919c1)
            return;
        float dt = Time.deltaTime;
        if (this._0xa72f9f3f > 0f)
        {
            this._0xa72f9f3f -= dt;
            if (this._0xa72f9f3f <= 0f && this._0xd4fde6fa != null)
                this._0xd4fde6fa._0xf9a8bd0f(false);
        }

        this._0xc43e4121 -= dt;
        if (this._0xd4fde6fa != null && this._0x445a6475 > 0f)
            this._0xd4fde6fa.SetMemory(Mathf.Clamp01(this._0xc43e4121 / this._0x445a6475));
        if (this._0x5fd3083e == _0x95303580.Lighting)
        {
            if (this._0xc43e4121 <= 0f)
                this._0xdeb32301();
            return;
        }

        if (this._0x5fd3083e == _0x95303580.Darkening)
        {
            if (this._0xc43e4121 <= 0f)
                this._0x597eed72();
            return;
        }

        if (this._0x5fd3083e == _0x95303580.Settling)
        {
            if (this._0xc43e4121 <= 0f)
                this._0x003b7b53();
            return;
        }

        if (this._0x5fd3083e != _0x95303580.Rebuilding)
            return;
        if (this._0xc43e4121 <= 0f)
        {
            this._0x89bf28cb(true);
            return;
        }

        Vector2 _0x8417c1c4;
        if (this._0x18b01654(out _0x8417c1c4))
            this._0x42a24a27(this._0x99cfe7e3._0xa46e23f3(_0x8417c1c4));
    }

    private int _0x91b7f730;
    private bool _0xb8f55e56;
    // -- the template's own HUD is not this game's HUD -------------------------
    private Transform _0x3a68df0f()
    {
        _0x086e6439 _0xc2bfe2fc = _0x086e6439.Instance;
        if (_0xc2bfe2fc == null || _0xc2bfe2fc.Panels == null)
            return null;
        int _0x1934ceb5 = _0xab68611e._0x74dfb94c.DEFAULT;
        if (_0x1934ceb5 < 0 || _0x1934ceb5 >= _0xc2bfe2fc.Panels.Count)
            return null;
        _0x8e14d786 _0x77bca9a8 = _0xc2bfe2fc.Panels[_0x1934ceb5];
        if (_0x77bca9a8 == null || _0x77bca9a8.Content == null)
            return null;
        return _0x77bca9a8.Content.transform;
    }

    [SerializeField]
    private GameObject _sparkPrefab;
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        this._0xeb4d7d4f = Camera.main;
        this._0xd0479f85 = new _0x9109e422
        {
            MaskBlank = this._maskBlank,
            MaskHero = this._maskHero,
            Eyes = this._eyeSprites,
            Plumes = this._plumeSprites,
            Silhouette = this._silhouette,
            SpotlightCone = this._spotlightCone,
            ChipBase = this._chipBase,
            PlatePanel = this._platePanel,
            BurstSpark = this._burstSpark,
            StageFloor = this._stageFloor,
            StageDrape = this._stageDrape,
            BrandMark = this._brandMark,
            DotToken = this._dotToken,
            IconBack = this._iconBack,
            IconPause = this._iconPause,
            IconClose = this._iconClose,
        };
        this._0x0a2c8865 = new _0xbd2ae5a9
        {
            Chip = this._chipPrefab,
            Slot = this._slotPrefab,
            Cone = this._conePrefab,
            Spark = this._sparkPrefab,
            Plate = this._platePrefab,
        };
    }

    private Camera _0xeb4d7d4f;
    private _0xbd2ae5a9 _0x0a2c8865;
    private _0x03bcc995 _0x7d27c9e9;
    private void _0x003b7b53()
    {
        int _0x31d8395c = this._0x00a4fa9a + 1;
        if (_0x31d8395c >= _0x2861135b.PerformanceGoal)
        {
            this._0xcc9e390a();
            return;
        }

        this._0x1cc3ea50(_0x31d8395c, 0);
    }

    [SerializeField]
    private Sprite _iconPause;
    private _0x31f7df7e _0x6d40f315;
    // -- result cards ---------------------------------------------------------
    private void _0xcc9e390a()
    {
        this._0x5fd3083e = _0x95303580.Curtain;
        this._0x99cfe7e3._0x71aa42b5();
        if (_0x279ca21b.Instance != null)
            _0x279ca21b.Instance._0x7afb8f10(false);
        _0xfd5d95d0 _0x830527ac = _0x35837dc7.Instance._0x52763680(_0xab68611e._0xb6633f3a.WIN);
        this._0x6d40f315.Dress(_0x830527ac, _0x0568c71b._0x15debffc(new byte[12] { 128, 150, 145, 151, 130, 138, 141, 227, 128, 130, 143, 143 }, 195), _0x2861135b.Gold, _0x2861135b.PerformanceGoal + _0x0568c71b._0x15debffc(new byte[14] { 178, 223, 211, 193, 217, 193, 178, 223, 211, 198, 209, 218, 215, 214 }, 146), _0x0568c71b._0x15debffc(new byte[9] { 32, 49, 49, 45, 32, 52, 50, 36, 65 }, 97) + _0xab68611e._0x651c7180._0x022bcc30 + _0x0568c71b._0x15debffc(new byte[8] { 172, 235, 239, 245, 245, 227, 245, 134 }, 166) + this._0x203833ef + _0x0568c71b._0x15debffc(new byte[3] { 165, 170, 165 }, 133) + _0x2861135b.MissesAllowed, _0x0568c71b._0x15debffc(new byte[6] { 220, 215, 218, 214, 203, 220 }, 153), () => this._0x019b40de(), _0x0568c71b._0x15debffc(new byte[9] { 7, 4, 6, 14, 22, 17, 4, 2, 0 }, 69), () => this._0x3cd1b4c2());
        _0x35837dc7.Instance._0x028b3e26(_0xab68611e._0xb6633f3a.WIN);
    }

    private float _0xc43e4121;
    [SerializeField]
    private Sprite _iconBack;
    private void _0x1b609129()
    {
        if (this._0x5fd3083e == _0x95303580.Curtain || this._0xb8f55e56)
            return;
        this._0xb8f55e56 = true;
        if (_0x279ca21b.Instance != null)
            _0x279ca21b.Instance._0x7afb8f10(false);
        _0xfd5d95d0 _0x3a182039 = _0x35837dc7.Instance._0x52763680(_0xab68611e._0xb6633f3a.PAUSE);
        this._0x6d40f315.Dress(_0x3a182039, _0x0568c71b._0x15debffc(new byte[12] { 27, 28, 6, 23, 0, 31, 27, 1, 1, 27, 29, 28 }, 82), _0x2861135b.TextPrimary, _0x0568c71b._0x15debffc(new byte[20] { 170, 182, 187, 222, 173, 170, 191, 185, 187, 222, 183, 173, 222, 169, 191, 183, 170, 183, 176, 185 }, 254), _0x0568c71b._0x15debffc(new byte[12] { 232, 253, 234, 254, 247, 234, 245, 249, 246, 251, 253, 152 }, 184) + Mathf.Min(this._0x00a4fa9a + 1, _0x2861135b.PerformanceGoal) + _0x0568c71b._0x15debffc(new byte[3] { 116, 123, 116 }, 84) + _0x2861135b.PerformanceGoal + _0x0568c71b._0x15debffc(new byte[8] { 108, 43, 47, 53, 53, 35, 53, 70 }, 102) + this._0x203833ef + _0x0568c71b._0x15debffc(new byte[3] { 36, 43, 36 }, 4) + _0x2861135b.MissesAllowed, _0x0568c71b._0x15debffc(new byte[6] { 153, 142, 152, 158, 134, 142 }, 203), () => this._0x6ca33e76(), _0x0568c71b._0x15debffc(new byte[9] { 112, 115, 113, 121, 97, 102, 115, 117, 119 }, 50), () => this._0x3cd1b4c2());
        _0x35837dc7.Instance._0x028b3e26(_0xab68611e._0xb6633f3a.PAUSE);
    }

    private float _0xa72f9f3f;
    private void _0xc66b7137()
    {
        if (this._0xbb012171 >= this._0x85d7cfcf.SlotOrder.Length)
            return;
        int _0x384b4748 = this._0x85d7cfcf.SlotOrder[this._0xbb012171];
        this._0x99cfe7e3._0x153306e7(_0x384b4748);
        if (this._0xd4fde6fa != null)
            this._0xd4fde6fa._0xf9d3b14c(_0x0568c71b._0x15debffc(new byte[7] { 167, 171, 190, 169, 162, 208, 202 }, 234) + _0x9109e422.FeatureName(_0x384b4748));
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    [SerializeField]
    private Sprite _maskBlank;
    private void _0xc5c4606f()
    {
        this._0x7d27c9e9._0xa6695ab1();
        this._0xe39fd4de._0xad2aa149(true);
        _0xad4fe07f.Unlock(this._0x00a4fa9a);
        _0xab68611e._0x651c7180._0x022bcc30 += this._0xcda92605 == 0 ? _0x2861135b.CoinsPerMask + _0x2861135b.CoinsPerCleanMask : _0x2861135b.CoinsPerMask;
        if (this._0xd4fde6fa != null)
            this._0xd4fde6fa._0xf9d3b14c(this._0xcda92605 == 0 ? _0x0568c71b._0x15debffc(new byte[8] { 148, 158, 147, 133, 158, 151, 129, 129 }, 210) : _0x0568c71b._0x15debffc(new byte[13] { 158, 146, 128, 152, 243, 144, 156, 158, 131, 159, 150, 135, 150 }, 211));
        this._0x445a6475 = _0x2861135b.ResolveSeconds;
        this._0xc43e4121 = _0x2861135b.ResolveSeconds;
        this._0x5fd3083e = _0x95303580.Settling;
    }

    // -- performance cycle ----------------------------------------------------
    private void _0x1cc3ea50(int _0x9e2491fb, int _0x3a9af9bc)
    {
        this._0x00a4fa9a = _0x9e2491fb;
        this._0x91b7f730 = _0x3a9af9bc;
        this._0xbb012171 = 0;
        this._0xcda92605 = 0;
        this._0x85d7cfcf = this._0x1af207be.Build(_0x9e2491fb, _0x3a9af9bc, _0xad4fe07f._0x85d27dab);
        int _0x09f0a2b8 = _0x2861135b.Row(_0x9e2491fb);
        float _0xebce447c = _0x2861135b.ShowMilliseconds[_0x09f0a2b8] / 1000f;
        if (_0xad4fe07f._0x85d27dab)
            _0xebce447c *= _0x2861135b.MidnightShowScale;
        this._0x99cfe7e3._0x71aa42b5();
        this._0x7d27c9e9._0x26a5b1b2();
        this._0x7d27c9e9._0xf3a3a0ee(this._0x85d7cfcf);
        this._0xe39fd4de._0xad2aa149(true);
        if (this._0xd4fde6fa != null)
        {
            this._0xd4fde6fa._0x537c3371(_0x9e2491fb, _0x2861135b.PerformanceGoal);
            this._0xd4fde6fa._0x1d95b6ae(this._0x203833ef);
            this._0xd4fde6fa._0xf9d3b14c(_0x0568c71b._0x15debffc(new byte[17] { 38, 49, 57, 49, 57, 54, 49, 38, 84, 32, 60, 49, 84, 57, 53, 39, 63 }, 116));
            this._0xd4fde6fa._0xf9a8bd0f(true);
            this._0xd4fde6fa.SetMemory(1f);
        }

        this._0xa72f9f3f = _0x2861135b.HintSeconds;
        this._0x445a6475 = _0xebce447c;
        this._0xc43e4121 = _0xebce447c;
        this._0x5fd3083e = _0x95303580.Lighting;
    }

    [SerializeField]
    private TMP_FontAsset _font;
    // -- input: raw enhanced touches, filtered to the tray by rectangle --------
    private bool _0x18b01654(out Vector2 _0x0f463e6d)
    {
        _0x0f463e6d = Vector2.zero;
        if (this._0xeb4d7d4f == null)
            return false;
        int _0xa2559701 = ETouch.activeTouches.Count;
        for (int _0xd7eca54c = 0; _0xd7eca54c < _0xa2559701; _0xd7eca54c++)
        {
            ETouch _0x5a366e00 = ETouch.activeTouches[_0xd7eca54c];
            if (_0x5a366e00.phase != UnityEngine.InputSystem.TouchPhase.Began)
                continue;
            Vector3 _0x81ec96f4 = this._0xeb4d7d4f.ScreenToWorldPoint(_0x5a366e00.screenPosition);
            _0x0f463e6d = new Vector2(_0x81ec96f4.x, _0x81ec96f4.y);
            return true;
        }

        if (_0xa2559701 > 0)
            return false;
        Pointer _0x7c735044 = Pointer.current;
        if (_0x7c735044 != null && _0x7c735044.press.wasPressedThisFrame)
        {
            Vector3 _0x23c42244 = this._0xeb4d7d4f.ScreenToWorldPoint(_0x7c735044.position.ReadValue());
            _0x0f463e6d = new Vector2(_0x23c42244.x, _0x23c42244.y);
            return true;
        }

        return false;
    }

    [SerializeField]
    private Sprite _dotToken;
    [SerializeField]
    private Sprite _stageDrape;
}

internal static class _0x0568c71b
{
    internal static string _0x15debffc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}