using UnityEngine;

/// <summary>
/// The art the stage is built from, handed to every sub-component in one piece so no
/// component has to look an asset up by name. The director fills it from its own
/// serialized fields, which are assigned in the scene by guid.
/// </summary>
public sealed class _0x9109e422
{
    public Sprite ChipBase;
    /// <summary>Tint that stands for one variant, for the COLOUR feature.</summary>
    public static Color FeatureTint(int _0xbf558e6a, int _0x10aea52f)
    {
        if (_0xbf558e6a != _0x9133d900.FeatureColour)
            return _0x2861135b.TextPrimary;
        return _0x2861135b.MaskTints[Mathf.Clamp(_0x10aea52f, 0, _0x2861135b.MaskTints.Length - 1)];
    }

    public static string FeatureName(int _0xeef38130)
    {
        if (_0xeef38130 == _0x9133d900.FeatureEyes)
            return _0xd113997f._0x6bd698ea(new byte[4] { 146, 142, 146, 132 }, 215);
        if (_0xeef38130 == _0x9133d900.FeatureColour)
            return _0xd113997f._0x6bd698ea(new byte[6] { 150, 154, 153, 154, 128, 135 }, 213);
        return _0xd113997f._0x6bd698ea(new byte[5] { 239, 243, 234, 242, 250 }, 191);
    }

    public Sprite[] Plumes = new Sprite[0];
    public Sprite StageDrape;
    /// <summary>Sprite that stands for one variant of a feature, or null when the
    /// feature is expressed as a tint rather than a shape.</summary>
    public Sprite _0xc5503225(int _0xb4e263fb, int _0x1c161cd4)
    {
        if (_0xb4e263fb == _0x9133d900.FeatureEyes)
            return this.Eyes.Length == 0 ? null : this.Eyes[Mathf.Clamp(_0x1c161cd4, 0, this.Eyes.Length - 1)];
        if (_0xb4e263fb == _0x9133d900.FeaturePlume)
            return this.Plumes.Length == 0 ? null : this.Plumes[Mathf.Clamp(_0x1c161cd4, 0, this.Plumes.Length - 1)];
        return this.MaskBlank;
    }

    public Sprite MaskHero;
    public Sprite[] Eyes = new Sprite[0];
    public Sprite IconBack;
    public Sprite SpotlightCone;
    public Sprite PlatePanel;
    public Sprite MaskBlank;
    public Sprite IconClose;
    public Sprite Silhouette;
    public Sprite BurstSpark;
    public Sprite DotToken;
    public Sprite StageFloor;
    public Sprite IconPause;
    public Sprite BrandMark;
}

/// <summary>
/// The spawnable pieces of the stage, authored as prefabs so each object arrives already
/// Sliced, already sized and already on the right sorting layer.
/// </summary>
public sealed class _0xbd2ae5a9
{
    public GameObject Slot;
    public GameObject Chip;
    public GameObject Cone;
    public GameObject Plate;
    public GameObject Spark;
}

/// <summary>
/// Thin factory for the world-space carnival art. Every renderer it hands back is Sliced
/// with an explicit size, sits at scale 1 and takes a sorting order from StageConfig, so
/// the size on screen is the size that was computed from the camera (rule C.0).
/// </summary>
public static class _0x1bfd6668
{
    /// <summary>
    /// Spawn a pre-configured prefab and re-state its size from the camera. Falls back to
    /// a bare renderer when the prefab reference is missing, so a stage is never empty.
    /// </summary>
    public static SpriteRenderer Spawn(GameObject _0x01640e69, Transform _0xe60bc6e7, string _0xf421cbeb, Sprite _0x0fa2fbff, Vector2 _0x3c7d7be2, Vector2 _0x3408f533, int _0x78456bed, Color _0xd4dbcd4c)
    {
        if (_0x01640e69 == null)
            return Quad(_0xe60bc6e7, _0xf421cbeb, _0x0fa2fbff, _0x3c7d7be2, _0x3408f533, _0x78456bed, _0xd4dbcd4c);
        GameObject _0x1b2a899d = UnityEngine.Object.Instantiate(_0x01640e69, _0xe60bc6e7);
        _0x1b2a899d.transform.localPosition = new Vector3(_0x3408f533.x, _0x3408f533.y, 0f);
        _0x1b2a899d.transform.localRotation = Quaternion.identity;
        _0x1b2a899d.transform.localScale = Vector3.one;
        SpriteRenderer _0x19825d55 = _0x1b2a899d.GetComponent<SpriteRenderer>();
        if (_0x19825d55 == null)
            _0x19825d55 = _0x1b2a899d.AddComponent<SpriteRenderer>();
        if (_0x0fa2fbff != null)
            _0x19825d55.sprite = _0x0fa2fbff;
        _0x19825d55.drawMode = SpriteDrawMode.Sliced;
        _0x19825d55.size = _0x3c7d7be2;
        _0x19825d55.sortingOrder = _0x78456bed;
        _0x19825d55.color = _0xd4dbcd4c;
        return _0x19825d55;
    }

    /// <summary>Half the camera's visible height in world units.</summary>
    public static float HalfHeight(Camera _0x7ea03ba5)
    {
        return _0x7ea03ba5 == null ? 5f : _0x7ea03ba5.orthographicSize;
    }

    public static void SetAlpha(SpriteRenderer _0xac953417, float _0x47f92c18)
    {
        if (_0xac953417 == null)
            return;
        Color _0x756c5f50 = _0xac953417.color;
        _0xac953417.color = new Color(_0x756c5f50.r, _0x756c5f50.g, _0x756c5f50.b, _0x47f92c18);
    }

    /// <summary>Resize a Sliced renderer without ever touching its transform scale.</summary>
    public static void Resize(SpriteRenderer _0x345c1f8c, Vector2 _0x99d3cee1)
    {
        if (_0x345c1f8c == null)
            return;
        _0x345c1f8c.drawMode = SpriteDrawMode.Sliced;
        _0x345c1f8c.size = _0x99d3cee1;
        _0x345c1f8c.transform.localScale = Vector3.one;
    }

    public static SpriteRenderer Quad(Transform _0x60511422, string _0x839e7c0d, Sprite _0xad1dc257, Vector2 _0x80d7e43a, Vector2 _0x92f52c56, int _0x2abf960d, Color _0x3320612e)
    {
        GameObject _0x572bf5fe = new GameObject(_0x839e7c0d);
        _0x572bf5fe.transform.SetParent(_0x60511422, false);
        _0x572bf5fe.transform.localPosition = new Vector3(_0x92f52c56.x, _0x92f52c56.y, 0f);
        _0x572bf5fe.transform.localScale = Vector3.one;
        SpriteRenderer _0x99ed7467 = _0x572bf5fe.AddComponent<SpriteRenderer>();
        _0x99ed7467.sprite = _0xad1dc257;
        _0x99ed7467.drawMode = SpriteDrawMode.Sliced;
        _0x99ed7467.size = _0x80d7e43a;
        _0x99ed7467.sortingOrder = _0x2abf960d;
        _0x99ed7467.color = _0x3320612e;
        return _0x99ed7467;
    }

    /// <summary>Half the camera's visible width in world units.</summary>
    public static float HalfWidth(Camera _0x3b3d6454)
    {
        float _0x5f345665 = HalfHeight(_0x3b3d6454);
        float _0xfa690d20 = _0x3b3d6454 == null || _0x3b3d6454.aspect <= 0f ? 9f / 19.5f : _0x3b3d6454.aspect;
        return _0x5f345665 * _0xfa690d20;
    }

    /// <summary>Axis-aligned world rectangle of a Sliced renderer, for tap hit-testing.</summary>
    public static Rect BoundsOf(SpriteRenderer _0x80cf15b6)
    {
        if (_0x80cf15b6 == null)
            return new Rect(0f, 0f, 0f, 0f);
        Vector3 _0x66d44be9 = _0x80cf15b6.transform.position;
        Vector2 _0xe8149836 = _0x80cf15b6.size;
        return new Rect(_0x66d44be9.x - _0xe8149836.x * 0.5f, _0x66d44be9.y - _0xe8149836.y * 0.5f, _0xe8149836.x, _0xe8149836.y);
    }
}

internal static class _0xd113997f
{
    internal static string _0x6bd698ea(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}