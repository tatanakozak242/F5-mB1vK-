using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Every layer of one generated button, handed back so a caller can restyle it later
/// through a reference instead of a name lookup.
/// </summary>
public sealed class _0x7e366765
{
    public Image Fill;
    public RectTransform Root;
    public Button Button;
    public TextMeshProUGUI Caption;
    public Image Edge;
    public Image Icon;
}

/// <summary>
/// UGUI construction kit for the brutalist carnival chrome: flat colour blocks, a thick
/// dark contour and a hard offset shadow, no blur. Every label it builds has word wrap
/// OFF, autosize ON and a readable floor, so a line breaks only where the string says
/// so and never shrinks below the C.12 minimum.
/// </summary>
public static class _0x9dac4d45
{
    /// <summary>A two-layer progress bar: dark track, flat accent fill, no gradient.</summary>
    public static Image Bar(Transform _0x8359e950, string _0x6af63453, Vector2 _0xc749a4ac, Vector2 _0xdfbf7b97, Vector2 _0xf938ac1a, Sprite _0x756bc558, Color _0x103d658e, Color _0x33577f25)
    {
        RectTransform _0xa104a62a = Node(_0x8359e950, _0x6af63453, _0xc749a4ac, _0xdfbf7b97, _0xf938ac1a);
        Block(_0xa104a62a, _0x1739a319._0xe1de9d7a(new byte[7] { 82, 113, 98, 85, 116, 119, 117 }, 16), new Vector2(0.5f, 0.5f), Vector2.zero, _0xf938ac1a, _0x756bc558, _0x2861135b.Stroke);
        Block(_0xa104a62a, _0x1739a319._0xe1de9d7a(new byte[8] { 58, 25, 10, 44, 10, 25, 27, 19 }, 120), new Vector2(0.5f, 0.5f), Vector2.zero, _0xf938ac1a - new Vector2(6f, 6f), _0x756bc558, _0x103d658e);
        RectTransform _0xf4cd7992 = Node(_0xa104a62a, _0x1739a319._0xe1de9d7a(new byte[11] { 40, 11, 24, 44, 3, 6, 6, 34, 5, 25, 30 }, 106), new Vector2(0f, 0.5f), new Vector2(3f, 0f), _0xf938ac1a - new Vector2(6f, 6f));
        _0xf4cd7992.pivot = new Vector2(0f, 0.5f);
        _0xf4cd7992.anchorMin = new Vector2(0f, 0.5f);
        _0xf4cd7992.anchorMax = new Vector2(0f, 0.5f);
        Image _0x4e7014a3 = _0xf4cd7992.gameObject.AddComponent<Image>();
        _0x4e7014a3.sprite = _0x756bc558;
        _0x4e7014a3.type = _0x756bc558 == null ? Image.Type.Simple : Image.Type.Sliced;
        _0x4e7014a3.color = _0x33577f25;
        _0x4e7014a3.raycastTarget = false;
        return _0x4e7014a3;
    }

    public static void SetBar(Image _0xad48245f, float _0x82df2f32, float _0x6b45edc9)
    {
        if (_0xad48245f == null)
            return;
        float _0x498c96bc = Mathf.Clamp01(_0x82df2f32);
        Vector2 _0x8681dc9f = _0xad48245f.rectTransform.sizeDelta;
        _0xad48245f.rectTransform.sizeDelta = new Vector2(Mathf.Max(6f, _0x6b45edc9 * _0x498c96bc), _0x8681dc9f.y);
    }

    public const float ContourPixels = 5f;
    public const float LabelFloor = 30f;
    public const float ShadowPixels = 8f;
    public static Image Block(Transform _0xe8254e9d, string _0x981d1d6c, Vector2 _0xffc31cc4, Vector2 _0x9f8c568a, Vector2 _0x2d6e05c8, Sprite _0xd1eb0436, Color _0x0825ed5b)
    {
        RectTransform _0x576dd73c = Node(_0xe8254e9d, _0x981d1d6c, _0xffc31cc4, _0x9f8c568a, _0x2d6e05c8);
        Image _0x906c2353 = _0x576dd73c.gameObject.AddComponent<Image>();
        _0x906c2353.sprite = _0xd1eb0436;
        _0x906c2353.type = _0xd1eb0436 == null ? Image.Type.Simple : Image.Type.Sliced;
        _0x906c2353.color = _0x0825ed5b;
        _0x906c2353.raycastTarget = false;
        return _0x906c2353;
    }

    public static void SanitiseTutorials(TMP_FontAsset _0xb0f104c1)
    {
        _0x086e6439 _0xebb5da75 = _0x086e6439.Instance;
        if (_0xebb5da75 == null || _0xebb5da75.Panels == null)
            return;
        int[] _0x739c3304 =
        {
            _0xab68611e._0x74dfb94c.TUTORIAL0,
            _0xab68611e._0x74dfb94c.TUTORIAL1,
            _0xab68611e._0x74dfb94c.TUTORIAL2,
            _0xab68611e._0x74dfb94c.TUTORIAL3,
            _0xab68611e._0x74dfb94c.TUTORIAL4,
            _0xab68611e._0x74dfb94c.TUTORIAL5,
            _0xab68611e._0x74dfb94c.TUTORIAL6,
        };
        for (int _0x3cc41bef = 0; _0x3cc41bef < _0x739c3304.Length; _0x3cc41bef++)
        {
            int _0x06341b34 = _0x739c3304[_0x3cc41bef];
            if (_0x06341b34 < 0 || _0x06341b34 >= _0xebb5da75.Panels.Count)
                continue;
            _0x8e14d786 _0x14b58dd3 = _0xebb5da75.Panels[_0x06341b34];
            if (_0x14b58dd3 == null || _0x14b58dd3.Content == null)
                continue;
            TMP_Text[] _0xfc2858a1 = _0x14b58dd3.Content.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x957d219b = 0; _0x957d219b < _0xfc2858a1.Length; _0x957d219b++)
            {
                if (_0xfc2858a1[_0x957d219b] == null)
                    continue;
                string _0x75d11ed6 = string.Empty;
                if (_0x957d219b == 0 && _0x3cc41bef < _0x75ed053c.Length)
                    _0x75d11ed6 = _0x75ed053c[_0x3cc41bef];
                else if (_0x957d219b == 1 && _0x3cc41bef < _0xb8c95a55.Length)
                    _0x75d11ed6 = _0xb8c95a55[_0x3cc41bef];
                _0xfc2858a1[_0x957d219b].text = _0x75d11ed6;
                _0xfc2858a1[_0x957d219b].color = _0x957d219b == 0 ? _0x2861135b.Gold : _0x2861135b.TextPrimary;
                if (_0xb0f104c1 != null)
                    _0xfc2858a1[_0x957d219b].font = _0xb0f104c1;
                Wrap(_0xfc2858a1[_0x957d219b], _0x957d219b == 0 ? 72f : 48f, _0x957d219b == 0 ? 52f : 38f);
            }
        }
    }

    public static TextMeshProUGUI Label(Transform _0xcbdec3b6, string _0xf7deec7b, string _0x3c539b41, Vector2 _0xb490feee, Vector2 _0xc5ffec72, Vector2 _0xe298b25c, float _0x0f103bea, float _0x16b2450b, Color _0x3ab27280, TMP_FontAsset _0xdcf1b5f3, TextAlignmentOptions _0x869a664b)
    {
        RectTransform _0x1d70bf81 = Node(_0xcbdec3b6, _0xf7deec7b, _0xb490feee, _0xc5ffec72, _0xe298b25c);
        TextMeshProUGUI _0xb7fa0ef8 = _0x1d70bf81.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0xdcf1b5f3 != null)
            _0xb7fa0ef8.font = _0xdcf1b5f3;
        _0xb7fa0ef8.text = _0x3c539b41;
        _0xb7fa0ef8.color = _0x3ab27280;
        _0xb7fa0ef8.alignment = _0x869a664b;
        _0xb7fa0ef8.raycastTarget = false;
        Wrap(_0xb7fa0ef8, _0x0f103bea, _0x16b2450b);
        return _0xb7fa0ef8;
    }

    public static RectTransform Node(Transform _0x01ab4abf, string _0xa38858e7, Vector2 _0xb6cd7edc, Vector2 _0x2808f54a, Vector2 _0x0019b917)
    {
        GameObject _0xbd6c979a = new GameObject(_0xa38858e7, typeof(RectTransform));
        _0xbd6c979a.transform.SetParent(_0x01ab4abf, false);
        RectTransform _0xaca7bf8c = _0xbd6c979a.GetComponent<RectTransform>();
        _0xaca7bf8c.anchorMin = _0xb6cd7edc;
        _0xaca7bf8c.anchorMax = _0xb6cd7edc;
        _0xaca7bf8c.pivot = new Vector2(0.5f, 0.5f);
        _0xaca7bf8c.anchoredPosition = _0x2808f54a;
        _0xaca7bf8c.sizeDelta = _0x0019b917;
        _0xaca7bf8c.localScale = Vector3.one;
        return _0xaca7bf8c;
    }

    /// <summary>
    /// A tappable brutalist button. Order of children is background -> icon -> text, so
    /// the caption always draws over its own plate (rule E.1 / C.13). Returns every layer
    /// so a caller can restyle the button later without looking anything up by name.
    /// </summary>
    public static _0x7e366765 CtaParts(Transform _0x1b354ef4, string _0xfca36b55, string _0x2340c5e9, Vector2 _0x4ec714fb, Vector2 _0xf7f563bc, Vector2 _0x40e216cc, Sprite _0xc3564535, Sprite _0x74a1a2c4, Color _0x78e85988, Color _0x11562518, TMP_FontAsset _0xa9488213, float _0xd38c34bc)
    {
        RectTransform _0xe2532d0e = Node(_0x1b354ef4, _0xfca36b55, _0x4ec714fb, _0xf7f563bc, _0x40e216cc);
        _0x7e366765 _0x47fca6ec = new _0x7e366765();
        _0x47fca6ec.Root = _0xe2532d0e;
        Image _0xcc0a7d5d = _0xe2532d0e.gameObject.AddComponent<Image>();
        _0xcc0a7d5d.sprite = _0xc3564535;
        _0xcc0a7d5d.type = _0xc3564535 == null ? Image.Type.Simple : Image.Type.Sliced;
        _0xcc0a7d5d.color = new Color(1f, 1f, 1f, 0f);
        _0xcc0a7d5d.raycastTarget = true;
        Block(_0xe2532d0e, _0x1739a319._0xe1de9d7a(new byte[9] { 194, 245, 224, 210, 233, 224, 229, 238, 246 }, 129), new Vector2(0.5f, 0.5f), new Vector2(ShadowPixels, -ShadowPixels), _0x40e216cc, _0xc3564535, _0x2861135b.Fade(_0x2861135b.Stroke, 0.9f));
        _0x47fca6ec.Edge = Block(_0xe2532d0e, _0x1739a319._0xe1de9d7a(new byte[7] { 36, 19, 6, 34, 3, 0, 2 }, 103), new Vector2(0.5f, 0.5f), Vector2.zero, _0x40e216cc, _0xc3564535, _0x2861135b.Stroke);
        _0x47fca6ec.Fill = Block(_0xe2532d0e, _0x1739a319._0xe1de9d7a(new byte[7] { 109, 90, 79, 104, 71, 66, 66 }, 46), new Vector2(0.5f, 0.5f), Vector2.zero, _0x40e216cc - new Vector2(ContourPixels * 2f, ContourPixels * 2f), _0xc3564535, _0x78e85988);
        if (_0x74a1a2c4 != null)
        {
            _0x47fca6ec.Icon = Block(_0xe2532d0e, _0x1739a319._0xe1de9d7a(new byte[7] { 100, 83, 70, 110, 68, 72, 73 }, 39), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x40e216cc.y * 0.52f, _0x40e216cc.y * 0.52f), _0x74a1a2c4, _0x11562518);
            _0x47fca6ec.Icon.type = Image.Type.Simple;
        }

        if (!string.IsNullOrEmpty(_0x2340c5e9))
            _0x47fca6ec.Caption = Label(_0xe2532d0e, _0x1739a319._0xe1de9d7a(new byte[7] { 230, 209, 196, 241, 192, 221, 209 }, 165), _0x2340c5e9, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x40e216cc.x - 48f, _0x40e216cc.y - 24f), _0xd38c34bc, _0xd38c34bc * 0.72f, _0x11562518, _0xa9488213, TextAlignmentOptions.Center);
        // The press tint multiplies the FILL, not the invisible hit layer - a tint on a
        // transparent graphic is no feedback at all, and rule C.7 wants the press seen.
        Button _0x044cb6d6 = _0xe2532d0e.gameObject.AddComponent<Button>();
        _0x044cb6d6.targetGraphic = _0x47fca6ec.Fill != null ? _0x47fca6ec.Fill : (Graphic)_0xcc0a7d5d;
        ColorBlock _0xf329a8f6 = _0x044cb6d6.colors;
        _0xf329a8f6.normalColor = Color.white;
        _0xf329a8f6.highlightedColor = Color.white;
        _0xf329a8f6.pressedColor = new Color(0.68f, 0.66f, 0.74f, 1f);
        _0xf329a8f6.selectedColor = Color.white;
        _0xf329a8f6.disabledColor = new Color(0.45f, 0.42f, 0.5f, 0.7f);
        _0xf329a8f6.colorMultiplier = 1f;
        _0xf329a8f6.fadeDuration = 0.06f;
        _0x044cb6d6.colors = _0xf329a8f6;
        _0x47fca6ec.Button = _0x044cb6d6;
        return _0x47fca6ec;
    }

    // The scene template ships seven tutorial panels full of filler copy. This game does
    // not run a tutorial, but leaving that filler in place risks it reaching a screen
    // (rule C.15), so every one of them is rewritten in this game's words on startup.
    private static readonly string[] _0x75ed053c =
    {
        _0x1739a319._0xe1de9d7a(new byte[17] { 213, 194, 202, 194, 202, 197, 194, 213, 167, 211, 207, 194, 167, 194, 222, 194, 212 }, 135),
        _0x1739a319._0xe1de9d7a(new byte[19] { 179, 164, 172, 164, 172, 163, 164, 179, 193, 181, 169, 164, 193, 162, 174, 173, 174, 180, 179 }, 225),
        _0x1739a319._0xe1de9d7a(new byte[16] { 126, 105, 110, 121, 101, 96, 104, 12, 120, 100, 105, 12, 97, 109, 127, 103 }, 44),
    };
    /// <summary>
    /// A brutalist plate: hard offset shadow, then the contour block, then the fill inset
    /// inside it. Returns the plate body - children added to it draw on top of the fill,
    /// which is the order rule E.1 asks for.
    /// </summary>
    public static RectTransform Plate(Transform _0xcefa8bdd, string _0x6c56de7e, Vector2 _0x25129840, Vector2 _0x7ab980e7, Vector2 _0xc92a95c4, Sprite _0x321cb786, Color _0x3347be3d, Color _0x38c79f00)
    {
        RectTransform _0x884d46d7 = Node(_0xcefa8bdd, _0x6c56de7e, _0x25129840, _0x7ab980e7, _0xc92a95c4);
        Image _0x279101fa = Block(_0x884d46d7, _0x1739a319._0xe1de9d7a(new byte[11] { 127, 67, 78, 91, 74, 124, 71, 78, 75, 64, 88 }, 47), new Vector2(0.5f, 0.5f), new Vector2(ShadowPixels, -ShadowPixels), _0xc92a95c4, _0x321cb786, _0x2861135b.Fade(_0x2861135b.Stroke, 0.85f));
        _0x279101fa.raycastTarget = false;
        Image _0xcffd5069 = Block(_0x884d46d7, _0x1739a319._0xe1de9d7a(new byte[9] { 129, 189, 176, 165, 180, 148, 181, 182, 180 }, 209), new Vector2(0.5f, 0.5f), Vector2.zero, _0xc92a95c4, _0x321cb786, _0x38c79f00);
        _0xcffd5069.raycastTarget = false;
        Image _0xfd1a3d4e = Block(_0x884d46d7, _0x1739a319._0xe1de9d7a(new byte[9] { 55, 11, 6, 19, 2, 37, 8, 3, 30 }, 103), new Vector2(0.5f, 0.5f), Vector2.zero, _0xc92a95c4 - new Vector2(ContourPixels * 2f, ContourPixels * 2f), _0x321cb786, _0x3347be3d);
        _0xfd1a3d4e.raycastTarget = false;
        return _0xfd1a3d4e.rectTransform;
    }

    public static Button Cta(Transform _0x31ebcd31, string _0x05a1ebd8, string _0x70c84db8, Vector2 _0x2260edbe, Vector2 _0x6410b4bc, Vector2 _0xac6f672d, Sprite _0xd4c361cd, Sprite _0xfd241cdc, Color _0x4643387c, Color _0xd97126c4, TMP_FontAsset _0x92c3b11d, float _0x2ea6c148)
    {
        return CtaParts(_0x31ebcd31, _0x05a1ebd8, _0x70c84db8, _0x2260edbe, _0x6410b4bc, _0xac6f672d, _0xd4c361cd, _0xfd241cdc, _0x4643387c, _0xd97126c4, _0x92c3b11d, _0x2ea6c148).Button;
    }

    private static readonly string[] _0xb8c95a55 =
    {
        _0x1739a319._0xe1de9d7a(new byte[54] { 167, 187, 182, 211, 190, 178, 160, 184, 211, 186, 160, 211, 191, 186, 167, 211, 181, 188, 161, 211, 178, 211, 190, 188, 190, 182, 189, 167, 223, 249, 167, 187, 182, 189, 211, 167, 187, 182, 211, 160, 167, 178, 180, 182, 211, 180, 188, 182, 160, 211, 183, 178, 161, 184 }, 243),
        _0x1739a319._0xe1de9d7a(new byte[46] { 71, 82, 67, 51, 71, 91, 86, 51, 94, 82, 71, 80, 91, 90, 93, 84, 51, 85, 65, 82, 84, 94, 86, 93, 71, 64, 25, 71, 92, 51, 65, 86, 81, 70, 90, 95, 87, 51, 71, 91, 86, 51, 94, 82, 64, 88 }, 19),
        _0x1739a319._0xe1de9d7a(new byte[32] { 253, 241, 255, 240, 236, 152, 232, 253, 234, 254, 247, 234, 245, 249, 246, 251, 253, 235, 148, 178, 236, 240, 234, 253, 253, 152, 245, 241, 235, 235, 253, 235 }, 184),
    };
    /// <summary>
    /// Word wrap OFF, autosize ON, floor never under the readable minimum. Line breaks
    /// are the caller's job and live in the string as an explicit newline.
    /// </summary>
    public static void Wrap(TMP_Text _0x0ac05685, float _0x013760f6, float _0x0aa341f9)
    {
        if (_0x0ac05685 == null)
            return;
        float _0xd8fd0dc5 = Mathf.Max(LabelFloor, _0x0aa341f9);
        _0x0ac05685.enableWordWrapping = false;
        _0x0ac05685.overflowMode = TextOverflowModes.Overflow;
        _0x0ac05685.enableAutoSizing = true;
        _0x0ac05685.fontSizeMax = Mathf.Max(_0xd8fd0dc5, _0x013760f6);
        _0x0ac05685.fontSizeMin = _0xd8fd0dc5;
        _0x0ac05685.fontSize = Mathf.Max(_0xd8fd0dc5, _0x013760f6);
    }
}

internal static class _0x1739a319
{
    internal static string _0xe1de9d7a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}