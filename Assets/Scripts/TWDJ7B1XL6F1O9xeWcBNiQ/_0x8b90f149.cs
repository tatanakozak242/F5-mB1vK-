using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The menu side of the carnival: an abstract half-violet, half-gold mark on the splash,
/// the hero mask swaying under two cones, the applause count, the collection rail, the
/// two bills and the settings strip. The PLAY target is the scene template's own load
/// button - this view only draws its face over it, so the scene is never double-loaded.
/// </summary>
public sealed class _0x8b90f149 : MonoBehaviour
{
    [SerializeField]
    private Sprite _maskBlank;
    [SerializeField]
    private GameObject _platePrefab;
    private SpriteRenderer _0x06ed7638;
    // -- the hero mask, swaying under the cones -------------------------------
    private void _0x17f4ff32(float _0x2aef5d99)
    {
        float width = _0x2aef5d99 * 2f * _0x2861135b.HeroWidthFraction;
        Vector2 _0x70d2d9af = new Vector2(width, width * _0x2861135b.MaskAspect);
        this._0xc0dc3126 = _0x1bfd6668.Quad(this.transform, _0x14237cf6._0x13c42722(new byte[8] { 82, 122, 113, 106, 87, 122, 109, 112 }, 31), this._0xf0b3dd12.MaskHero, _0x70d2d9af, new Vector2(0f, 2.65f), _0x2861135b.MaskOrder, _0x2861135b.TextPrimary);
        this._0x06ed7638 = _0x1bfd6668.Quad(this.transform, _0x14237cf6._0x13c42722(new byte[13] { 207, 231, 236, 247, 202, 231, 240, 237, 210, 238, 247, 239, 231 }, 130), null, new Vector2(width * 0.42f, width * 0.42f), new Vector2(0f, 2.65f + _0x70d2d9af.y * 0.44f), _0x2861135b.PlumeOrder, _0x2861135b.Gold);
        this._0x06ed7638.gameObject.SetActive(false);
        Transform _0x2bccccd2 = this._0xc0dc3126.transform;
        _0x2bccccd2.localRotation = Quaternion.Euler(0f, 0f, -3f);
        _0x2bccccd2.DORotate(new Vector3(0f, 0f, 3f), 2.4f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    [SerializeField]
    private Sprite[] _plumeSprites = new Sprite[0];
    private _0xbe9350c0 _0xfc499175;
    [SerializeField]
    private Sprite _maskHero;
    [SerializeField]
    private Sprite _spotlightCone;
    [SerializeField]
    private Sprite _platePanel;
    private void OnDestroy()
    {
        if (this._0xc0dc3126 != null)
            DOTween.Kill(this._0xc0dc3126.transform);
        DOTween.Kill(this.transform);
    }

    private Camera _0xe30aa1d4;
    private void Start()
    {
        float _0xed24a264 = _0x1bfd6668.HalfHeight(this._0xe30aa1d4);
        float _0x7a30cdd3 = _0x1bfd6668.HalfWidth(this._0xe30aa1d4);
        GameObject _0xc6c59751 = new GameObject(_0x14237cf6._0x13c42722(new byte[7] { 196, 236, 231, 252, 219, 224, 238 }, 137));
        _0xc6c59751.transform.SetParent(this.transform, false);
        this._0xfc499175 = _0xc6c59751.AddComponent<_0xbe9350c0>();
        this._0xfc499175._0x0a539800(this._0xf0b3dd12, this._0xde286705, _0x7a30cdd3, _0xed24a264);
        this._0xfc499175._0xad2aa149(true);
        _0x9dac4d45.SanitiseTutorials(this._font);
        this._0x17f4ff32(_0x7a30cdd3);
        this._0x0a8ba877();
        this._0x205a4d83();
    }

    private void Awake()
    {
        this._0xe30aa1d4 = Camera.main;
        this._0xf0b3dd12 = new _0x9109e422
        {
            MaskBlank = this._maskBlank,
            MaskHero = this._maskHero,
            Plumes = this._plumeSprites,
            Silhouette = this._silhouette,
            SpotlightCone = this._spotlightCone,
            PlatePanel = this._platePanel,
            StageFloor = this._stageFloor,
            StageDrape = this._stageDrape,
            BrandMark = this._brandMark,
        };
        this._0xde286705 = new _0xbd2ae5a9
        {
            Cone = this._conePrefab,
            Plate = this._platePrefab,
        };
    }

    private void _0x6bd68855()
    {
        _0xad4fe07f.Buzz();
        if (this._0x7b8c8058 != null)
            this._0x7b8c8058._0xc3961cb2();
    }

    private _0x526afedc _0x5194cf6f;
    private void _0x0a8ba877()
    {
        Transform _0x7ef5095c = this._0x81a8ff4e(_0xab68611e._0x74dfb94c.SPLASH);
        if (_0x7ef5095c == null)
            return;
        Image _0x9669abd2 = _0x9dac4d45.Block(_0x7ef5095c, _0x14237cf6._0x13c42722(new byte[12] { 235, 232, 244, 249, 235, 240, 231, 235, 240, 249, 252, 253 }, 184), new Vector2(0.5f, 0.5f), Vector2.zero, Vector2.zero, this._0xf0b3dd12.PlatePanel, _0x2861135b.Fade(_0x2861135b.BgDeep, 0.55f));
        _0x9669abd2.rectTransform.anchorMin = Vector2.zero;
        _0x9669abd2.rectTransform.anchorMax = Vector2.one;
        _0x9669abd2.rectTransform.sizeDelta = Vector2.zero;
        // An abstract mark only - half violet, half gold, thick contour, no lettering.
        _0x9dac4d45.Block(_0x7ef5095c, _0x14237cf6._0x13c42722(new byte[18] { 107, 104, 116, 121, 107, 112, 103, 117, 121, 106, 115, 103, 107, 112, 121, 124, 119, 111 }, 56), new Vector2(0.5f, 0.62f), new Vector2(10f, -10f), new Vector2(460f, 460f), this._0xf0b3dd12.BrandMark, _0x2861135b.Fade(_0x2861135b.Stroke, 0.9f)).type = Image.Type.Simple;
        Image _0xa863b76e = _0x9dac4d45.Block(_0x7ef5095c, _0x14237cf6._0x13c42722(new byte[11] { 54, 53, 41, 36, 54, 45, 58, 40, 36, 55, 46 }, 101), new Vector2(0.5f, 0.62f), Vector2.zero, new Vector2(460f, 460f), this._0xf0b3dd12.BrandMark, _0x2861135b.TextPrimary);
        _0xa863b76e.type = Image.Type.Simple;
        Transform _0x98041638 = _0xa863b76e.transform;
        _0x98041638.localScale = Vector3.one * 0.86f;
        _0x98041638.DOScale(1f, 1.1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private SpriteRenderer _0xc0dc3126;
    // -- reactions ------------------------------------------------------------
    private void _0x1116809b(bool _0xe16b9357)
    {
        Color _0x01d6ae0c = _0xe16b9357 ? _0x2861135b.Primary : _0x2861135b.Gold;
        if (this._0x5194cf6f != null)
            this._0x5194cf6f._0x02a9515c(_0x01d6ae0c);
        if (this._0xc0dc3126 != null)
            this._0xc0dc3126.color = _0xe16b9357 ? _0x2861135b.Fade(_0x2861135b.TextPrimary, 0.82f) : _0x2861135b.TextPrimary;
        if (this._0xfc499175 != null)
            this._0xfc499175._0x4c6a35d1(_0x01d6ae0c);
        // The hero swaps its plume with the bill, so the choice is visible on the mask
        // itself and not only on the chip (rule C.7).
        if (this._0x06ed7638 != null && this._0xf0b3dd12.Plumes.Length > 0)
        {
            int _0x7ab8a5d2 = _0xe16b9357 ? Mathf.Min(1, this._0xf0b3dd12.Plumes.Length - 1) : 0;
            this._0x06ed7638.gameObject.SetActive(true);
            this._0x06ed7638.sprite = this._0xf0b3dd12.Plumes[_0x7ab8a5d2];
            this._0x06ed7638.color = _0x01d6ae0c;
        }
    }

    private TextMeshProUGUI _0x7aecbbda;
    /// <summary>
    /// Draw this game's face over the template's own PLAY target. The face carries the
    /// raycast, the template button keeps the click handler - so the scene load stays
    /// exactly where the template put it.
    /// </summary>
    private void _0xd9e18792(Transform _0x10b8a5d9)
    {
        _0x44dc1119 _0xeba0c325 = _0x10b8a5d9.GetComponentInChildren<_0x44dc1119>(true);
        if (_0xeba0c325 == null)
            return;
        RectTransform _0xab933fc3 = _0xeba0c325.GetComponent<RectTransform>();
        if (_0xab933fc3 == null)
            return;
        Vector2 _0xc865e053 = _0xab933fc3.rect.size;
        if (_0xc865e053.x < 200f || _0xc865e053.y < 80f)
            _0xc865e053 = new Vector2(780f, 176f);
        _0x9dac4d45.Block(_0xab933fc3, _0x14237cf6._0x13c42722(new byte[11] { 51, 47, 34, 58, 60, 48, 43, 34, 39, 44, 52 }, 99), new Vector2(0.5f, 0.5f), new Vector2(_0x9dac4d45.ShadowPixels, -_0x9dac4d45.ShadowPixels), _0xc865e053, this._0xf0b3dd12.PlatePanel, _0x2861135b.Fade(_0x2861135b.Stroke, 0.95f));
        Image _0xc03df8d8 = _0x9dac4d45.Block(_0xab933fc3, _0x14237cf6._0x13c42722(new byte[9] { 84, 72, 69, 93, 91, 65, 64, 67, 65 }, 4), new Vector2(0.5f, 0.5f), Vector2.zero, _0xc865e053, this._0xf0b3dd12.PlatePanel, _0x2861135b.Stroke);
        _0xc03df8d8.raycastTarget = true;
        Image _0x14d0f4c5 = _0x9dac4d45.Block(_0xab933fc3, _0x14237cf6._0x13c42722(new byte[9] { 130, 158, 147, 139, 141, 148, 155, 158, 158 }, 210), new Vector2(0.5f, 0.5f), Vector2.zero, _0xc865e053 - new Vector2(_0x9dac4d45.ContourPixels * 2f, _0x9dac4d45.ContourPixels * 2f), this._0xf0b3dd12.PlatePanel, _0x2861135b.Accent);
        _0x14d0f4c5.raycastTarget = true;
        _0x9dac4d45.Label(_0xab933fc3, _0x14237cf6._0x13c42722(new byte[9] { 195, 223, 210, 202, 204, 199, 214, 203, 199 }, 147), _0x14237cf6._0x13c42722(new byte[4] { 148, 136, 133, 157 }, 196), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xc865e053.x - 60f, _0xc865e053.y - 40f), 64f, 52f, _0x2861135b.TextPrimary, this._font, TextAlignmentOptions.Center);
        _0xab933fc3.localScale = Vector3.one;
    }

    private _0x59f3a4bc _0x680c0d42;
    [SerializeField]
    private TMP_FontAsset _font;
    // -- the menu proper ------------------------------------------------------
    private void _0x205a4d83()
    {
        Transform _0xfac0ff1d = this._0x81a8ff4e(_0xab68611e._0x74dfb94c.DEFAULT);
        if (_0xfac0ff1d == null)
            return;
        RectTransform _0x6fbbbd69 = _0x9dac4d45.Plate(_0xfac0ff1d, _0x14237cf6._0x13c42722(new byte[13] { 165, 173, 166, 189, 183, 169, 184, 184, 164, 169, 189, 187, 173 }, 232), new Vector2(0.5f, 1f), new Vector2(0f, -212f), new Vector2(560f, 140f), this._0xf0b3dd12.PlatePanel, _0x2861135b.BgPanel, _0x2861135b.Primary);
        _0x9dac4d45.Label(_0x6fbbbd69, _0x14237cf6._0x13c42722(new byte[19] { 224, 232, 227, 248, 242, 236, 253, 253, 225, 236, 248, 254, 232, 242, 225, 236, 239, 232, 225 }, 173), _0x14237cf6._0x13c42722(new byte[8] { 109, 124, 124, 96, 109, 121, 127, 105 }, 44), new Vector2(0.5f, 1f), new Vector2(0f, -34f), new Vector2(480f, 46f), 32f, 30f, _0x2861135b.TextSecondary, this._font, TextAlignmentOptions.Center);
        this._0x7aecbbda = _0x9dac4d45.Label(_0x6fbbbd69, _0x14237cf6._0x13c42722(new byte[19] { 57, 49, 58, 33, 43, 53, 36, 36, 56, 53, 33, 39, 49, 43, 34, 53, 56, 33, 49 }, 116), _0x14237cf6._0x13c42722(new byte[1] { 74 }, 122), new Vector2(0.5f, 0f), new Vector2(0f, 46f), new Vector2(480f, 74f), 56f, 44f, _0x2861135b.Gold, this._font, TextAlignmentOptions.Center);
        this._0x7aecbbda.text = _0xab68611e._0x651c7180._0x022bcc30.ToString();
        _0x9dac4d45.Label(_0xfac0ff1d, _0x14237cf6._0x13c42722(new byte[14] { 181, 189, 182, 173, 167, 183, 186, 178, 189, 187, 172, 177, 174, 189 }, 248), _0x14237cf6._0x13c42722(new byte[13] { 51, 63, 42, 61, 54, 94, 70, 94, 51, 63, 45, 53, 45 }, 126), new Vector2(0.5f, 0.605f), Vector2.zero, new Vector2(940f, 104f), 64f, 48f, _0x2861135b.TextPrimary, this._font, TextAlignmentOptions.Center);
        GameObject _0x0b612b5e = new GameObject(_0x14237cf6._0x13c42722(new byte[8] { 220, 244, 255, 228, 195, 240, 248, 253 }, 145));
        _0x0b612b5e.transform.SetParent(this.transform, false);
        this._0x5194cf6f = _0x0b612b5e.AddComponent<_0x526afedc>();
        this._0x5194cf6f.Build(_0xfac0ff1d, this._0xf0b3dd12, this._font, new Vector2(0.5f, 0.475f), Vector2.zero);
        GameObject _0xc703fe85 = new GameObject(_0x14237cf6._0x13c42722(new byte[9] { 186, 146, 153, 130, 181, 158, 155, 155, 132 }, 247));
        _0xc703fe85.transform.SetParent(this.transform, false);
        this._0x680c0d42 = _0xc703fe85.AddComponent<_0x59f3a4bc>();
        this._0x680c0d42.Build(_0xfac0ff1d, this._0xf0b3dd12, this._font, new Vector2(0.5f, 0.385f), Vector2.zero, _0xaeeb4084 => this._0x1116809b(_0xaeeb4084));
        this._0xd9e18792(_0xfac0ff1d);
        Button _0x1b8b417d = _0x9dac4d45.Cta(_0xfac0ff1d, _0x14237cf6._0x13c42722(new byte[17] { 137, 129, 138, 145, 155, 151, 129, 144, 144, 141, 138, 131, 151, 155, 134, 144, 138 }, 196), _0x14237cf6._0x13c42722(new byte[14] { 171, 172, 185, 191, 189, 216, 171, 189, 172, 172, 177, 182, 191, 171 }, 248), new Vector2(0.5f, 0.155f), Vector2.zero, new Vector2(560f, 124f), this._0xf0b3dd12.PlatePanel, null, _0x2861135b.BgPlate, _0x2861135b.TextPrimary, this._font, 46f);
        GameObject _0x464220bd = new GameObject(_0x14237cf6._0x13c42722(new byte[9] { 45, 5, 14, 21, 51, 20, 18, 9, 16 }, 96));
        _0x464220bd.transform.SetParent(this.transform, false);
        this._0x7b8c8058 = _0x464220bd.AddComponent<_0xd8778582>();
        this._0x7b8c8058.Build(_0xfac0ff1d, this._0xf0b3dd12, this._font, new Vector2(0.5f, 0.068f), Vector2.zero, () => this._0x01b7be97());
        _0x1b8b417d.onClick.AddListener(() => this._0x6bd68855());
        this._0x5194cf6f._0xb2a23d2d();
        this._0x1116809b(_0xad4fe07f._0x85d27dab);
    }

    [SerializeField]
    private Sprite _silhouette;
    [SerializeField]
    private Sprite _stageDrape;
    [SerializeField]
    private GameObject _conePrefab;
    private _0x9109e422 _0xf0b3dd12;
    [SerializeField]
    private Sprite _stageFloor;
    private Transform _0x81a8ff4e(int _0xbd97dab1)
    {
        _0x086e6439 _0xedd7f981 = _0x086e6439.Instance;
        if (_0xedd7f981 == null || _0xedd7f981.Panels == null)
            return null;
        if (_0xbd97dab1 < 0 || _0xbd97dab1 >= _0xedd7f981.Panels.Count)
            return null;
        _0x8e14d786 _0x63f2c2a4 = _0xedd7f981.Panels[_0xbd97dab1];
        if (_0x63f2c2a4 == null || _0x63f2c2a4.Content == null)
            return null;
        return _0x63f2c2a4.Content.transform;
    }

    private _0xbd2ae5a9 _0xde286705;
    private void _0x01b7be97()
    {
        if (this._0x5194cf6f != null)
            this._0x5194cf6f._0xcae8e06a();
    }

    [SerializeField]
    private Sprite _brandMark;
    private _0xd8778582 _0x7b8c8058;
}

internal static class _0x14237cf6
{
    internal static string _0x13c42722(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}