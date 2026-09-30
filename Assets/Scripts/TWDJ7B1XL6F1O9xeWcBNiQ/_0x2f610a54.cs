using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x2f610a54 : MonoBehaviour
{
    private void OnEnable()
    {
        if (this._0xf0115d11 == null)
            this._0xf0115d11 = _0x63e676d6 => this._0x17977b0a(_0x63e676d6);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xf0115d11);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xf0115d11;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x17977b0a(Object _0x7f7c84f5)
    {
        TMP_Text _0xa3dafa1b = _0x7f7c84f5 as TMP_Text;
        if (_0xa3dafa1b != null)
            this._0x2dc8c239.Add(_0xa3dafa1b);
    }

    private const float MinOutlineWidth = 0.01f;
    private void LateUpdate()
    {
        if (this._0x2dc8c239.Count == 0)
            return;
        this._0x979feb9f.Clear();
        this._0x979feb9f.AddRange(this._0x2dc8c239);
        this._0x2dc8c239.Clear();
        for (int _0x22705785 = 0; _0x22705785 < this._0x979feb9f.Count; _0x22705785++)
            Fix(this._0x979feb9f[_0x22705785]);
    }

    private static float Linear(float _0x8dfb2f3f)
    {
        _0x8dfb2f3f = Mathf.Clamp01(_0x8dfb2f3f);
        return _0x8dfb2f3f <= 0.03928f ? _0x8dfb2f3f / 12.92f : Mathf.Pow((_0x8dfb2f3f + 0.055f) / 1.055f, 2.4f);
    }

    private const float MinRatio = 4.5f;
    private static float Ratio(Color _0x72bd35e0, Color _0xf5d2e305)
    {
        float _0x7cd3440f = Luminance(_0x72bd35e0);
        float _0x19c76f82 = Luminance(_0xf5d2e305);
        return (Mathf.Max(_0x7cd3440f, _0x19c76f82) + 0.05f) / (Mathf.Min(_0x7cd3440f, _0x19c76f82) + 0.05f);
    }

    private static void Fix(TMP_Text _0xaa93b86f)
    {
        if (_0xaa93b86f == null || !_0xaa93b86f.isActiveAndEnabled)
            return;
        Material _0xe6fceeab = _0xaa93b86f.fontSharedMaterial;
        if (_0xe6fceeab == null || !_0xe6fceeab.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xe6fceeab.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xe6fceeab.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xe25e2e10 = _0xaa93b86f.color;
        if (_0xe25e2e10.a <= 0f)
            return;
        Color _0xf7dfe9d9 = _0xe6fceeab.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xe25e2e10, _0xf7dfe9d9) >= MinRatio)
            return;
        Color _0x0cb8463c = Luminance(_0xf7dfe9d9) < 0.5f ? Color.white : Color.black;
        Color _0x79624f7f;
        if (Ratio(_0x0cb8463c, _0xf7dfe9d9) < TargetRatio)
        {
            _0x79624f7f = _0x0cb8463c;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x16ccb4e7 = 0f;
            float _0x33ee31bd = 1f;
            for (int _0x105bcb01 = 0; _0x105bcb01 < 20; _0x105bcb01++)
            {
                float _0x8303085a = (_0x16ccb4e7 + _0x33ee31bd) * 0.5f;
                if (Ratio(Color.Lerp(_0xe25e2e10, _0x0cb8463c, _0x8303085a), _0xf7dfe9d9) >= TargetRatio)
                    _0x33ee31bd = _0x8303085a;
                else
                    _0x16ccb4e7 = _0x8303085a;
            }

            _0x79624f7f = Color.Lerp(_0xe25e2e10, _0x0cb8463c, _0x33ee31bd);
        }

        _0x79624f7f.a = _0xe25e2e10.a;
        _0xaa93b86f.color = _0x79624f7f;
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x74def5bb != null)
            return;
        GameObject _0x036e1bf9 = new GameObject(_0x20bd590c._0x0dc62c14(new byte[16] { 146, 171, 182, 133, 169, 168, 178, 180, 167, 181, 178, 129, 179, 167, 180, 162 }, 198));
        _0x036e1bf9.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x036e1bf9);
        _0x74def5bb = _0x036e1bf9.AddComponent<_0x2f610a54>();
    }

    private const float TargetRatio = 7f;
    private readonly HashSet<TMP_Text> _0x2dc8c239 = new HashSet<TMP_Text>();
    private static _0x2f610a54 _0x74def5bb;
    private void OnDisable()
    {
        if (this._0xf0115d11 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xf0115d11);
    }

    private readonly List<TMP_Text> _0x979feb9f = new List<TMP_Text>();
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x99717b85)
    {
        return 0.2126f * Linear(_0x99717b85.r) + 0.7152f * Linear(_0x99717b85.g) + 0.0722f * Linear(_0x99717b85.b);
    }
}

internal static class _0x20bd590c
{
    internal static string _0x0dc62c14(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}