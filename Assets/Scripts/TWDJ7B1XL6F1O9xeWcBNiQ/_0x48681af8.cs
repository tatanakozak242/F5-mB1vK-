using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// One performance's worth of pattern: which mask the spotlights showed, in which order
/// its features have to be rebuilt, and what the fragment tray offers.
/// </summary>
public sealed class _0x48681af8
{
    public int _0x71e18380
    {
        get
        {
            int _0xa556dd6a = 17;
            for (int _0xdaf82d6d = 0; _0xdaf82d6d < this.ChipFeatures.Length; _0xdaf82d6d++)
                _0xa556dd6a = _0xa556dd6a * 31 + this.ChipFeatures[_0xdaf82d6d] * 7 + this.ChipVariants[_0xdaf82d6d];
            return _0xa556dd6a;
        }
    }

    /// <summary>Plaque columns; the tray is never deeper than two rows.</summary>
    public int Columns = 3;
    /// <summary>Variant the sample used, indexed by feature id; -1 when unused.</summary>
    public int[] SampleVariants =
    {
        -1,
        -1,
        -1
    };
    /// <summary>Feature id carried by each tray plaque.</summary>
    public int[] ChipFeatures = new int[0];
    /// <summary>Variant carried by each tray plaque.</summary>
    public int[] ChipVariants = new int[0];
    /// <summary>Feature ids in the order the cast accepts them.</summary>
    public int[] SlotOrder = new int[0];
}

/// <summary>
/// Seeded pattern builder. Every performance is generated, never hand-placed: the seed
/// mixes the performance index with the attempt count, so a re-deal after a missed
/// recall is a genuinely different mask (rule C.11). Placement always comes from here;
/// the hardcoded layout below is a guarantee of last resort, not the game.
/// </summary>
public sealed class _0x9133d900
{
    // -- drafting --------------------------------------------------------------
    private _0x48681af8 _0x0649b490(System.Random _0xb40b10ac, int _0x75151f7a, int _0xc421550d)
    {
        _0x48681af8 _0x1af9a1c9 = new _0x48681af8();
        _0x1af9a1c9.Columns = _0xc421550d <= 4 ? 2 : (_0xc421550d <= 6 ? 3 : 4);
        List<int> _0xf10b45c9 = new List<int>
        {
            FeatureEyes,
            FeatureColour
        };
        if (_0x75151f7a >= 3)
            _0xf10b45c9.Add(FeaturePlume);
        this._0xe606cb11(_0xf10b45c9, _0xb40b10ac);
        _0x1af9a1c9.SlotOrder = _0xf10b45c9.ToArray();
        _0x1af9a1c9.SampleVariants = new[]
        {
            -1,
            -1,
            -1
        };
        for (int _0xe9dbaf2a = 0; _0xe9dbaf2a < _0xf10b45c9.Count; _0xe9dbaf2a++)
        {
            int _0x8461b150 = _0xf10b45c9[_0xe9dbaf2a];
            _0x1af9a1c9.SampleVariants[_0x8461b150] = _0xb40b10ac.Next(_0xd2a4c7f5[_0x8461b150]);
        }

        // The tray always carries every sample feature exactly once; the rest are decoys
        // that differ from the sample in the feature they belong to.
        List<int> _0xdc30babf = new List<int>();
        List<int> _0x32f99601 = new List<int>();
        for (int _0x13d50fec = 0; _0x13d50fec < _0xf10b45c9.Count; _0x13d50fec++)
        {
            _0xdc30babf.Add(_0xf10b45c9[_0x13d50fec]);
            _0x32f99601.Add(_0x1af9a1c9.SampleVariants[_0xf10b45c9[_0x13d50fec]]);
        }

        int _0x2da05578 = 0;
        while (_0xdc30babf.Count < _0xc421550d && _0x2da05578 < 400)
        {
            _0x2da05578++;
            int _0x6971b68c = _0xf10b45c9[_0xb40b10ac.Next(_0xf10b45c9.Count)];
            int _0x892192bc = _0xb40b10ac.Next(_0xd2a4c7f5[_0x6971b68c]);
            if (_0x892192bc == _0x1af9a1c9.SampleVariants[_0x6971b68c])
                continue;
            bool _0xdd92c999 = false;
            for (int _0x9176a437 = 0; _0x9176a437 < _0xdc30babf.Count; _0x9176a437++)
                if (_0xdc30babf[_0x9176a437] == _0x6971b68c && _0x32f99601[_0x9176a437] == _0x892192bc)
                    _0xdd92c999 = true;
            if (_0xdd92c999)
                continue;
            _0xdc30babf.Add(_0x6971b68c);
            _0x32f99601.Add(_0x892192bc);
        }

        int[] _0x41c98805 = new int[_0xdc30babf.Count];
        for (int _0x5c7165ca = 0; _0x5c7165ca < _0x41c98805.Length; _0x5c7165ca++)
            _0x41c98805[_0x5c7165ca] = _0x5c7165ca;
        List<int> _0xe7c15f67 = new List<int>(_0x41c98805);
        this._0xe606cb11(_0xe7c15f67, _0xb40b10ac);
        _0x1af9a1c9.ChipFeatures = new int[_0xe7c15f67.Count];
        _0x1af9a1c9.ChipVariants = new int[_0xe7c15f67.Count];
        for (int _0xa8238bce = 0; _0xa8238bce < _0xe7c15f67.Count; _0xa8238bce++)
        {
            _0x1af9a1c9.ChipFeatures[_0xa8238bce] = _0xdc30babf[_0xe7c15f67[_0xa8238bce]];
            _0x1af9a1c9.ChipVariants[_0xa8238bce] = _0x32f99601[_0xe7c15f67[_0xa8238bce]];
        }

        return _0x1af9a1c9;
    }

    public const int FeatureEyes = 0;
    private static readonly int[] _0xd2a4c7f5 =
    {
        5,
        5,
        4
    };
    // -- the guarantee: a mask that cannot be rebuilt never reaches the player --
    private bool _0xf472fbef(_0x48681af8 _0x7d69c2ce, int _0xf72c1ccf, int _0x4f9af663)
    {
        if (_0x7d69c2ce == null || _0x7d69c2ce.SlotOrder.Length != _0xf72c1ccf)
            return false;
        if (_0x7d69c2ce.ChipFeatures.Length != _0x4f9af663 || _0x7d69c2ce.ChipVariants.Length != _0x4f9af663)
            return false;
        for (int _0xa3bc834c = 0; _0xa3bc834c < _0x7d69c2ce.SlotOrder.Length; _0xa3bc834c++)
        {
            int _0x47313651 = _0x7d69c2ce.SlotOrder[_0xa3bc834c];
            if (_0x7d69c2ce.SampleVariants[_0x47313651] < 0)
                return false;
            int _0x6fda296e = 0;
            for (int _0x217abeab = 0; _0x217abeab < _0x4f9af663; _0x217abeab++)
                if (_0x7d69c2ce.ChipFeatures[_0x217abeab] == _0x47313651 && _0x7d69c2ce.ChipVariants[_0x217abeab] == _0x7d69c2ce.SampleVariants[_0x47313651])
                    _0x6fda296e++;
            if (_0x6fda296e != 1)
                return false;
        }

        for (int _0x1c920ad5 = 0; _0x1c920ad5 < _0x4f9af663; _0x1c920ad5++)
            for (int _0xe0142568 = _0x1c920ad5 + 1; _0xe0142568 < _0x4f9af663; _0xe0142568++)
                if (_0x7d69c2ce.ChipFeatures[_0x1c920ad5] == _0x7d69c2ce.ChipFeatures[_0xe0142568] && _0x7d69c2ce.ChipVariants[_0x1c920ad5] == _0x7d69c2ce.ChipVariants[_0xe0142568])
                    return false;
        if (this._0xf862bac2 != null)
        {
            bool _0x41da16ba = true;
            for (int _0x773153a0 = 0; _0x773153a0 < _0x7d69c2ce.SampleVariants.Length; _0x773153a0++)
                if (_0x7d69c2ce.SampleVariants[_0x773153a0] != this._0xf862bac2.SampleVariants[_0x773153a0])
                    _0x41da16ba = false;
            if (_0x41da16ba)
                return false;
            if (_0x7d69c2ce._0x71e18380 == this._0xf862bac2._0x71e18380)
                return false;
        }

        return true;
    }

    public const int FeatureColour = 1;
    private void _0xe606cb11(List<int> _0x4f9efb6e, System.Random _0x2c0fb4bd)
    {
        for (int _0x587c35f2 = _0x4f9efb6e.Count - 1; _0x587c35f2 > 0; _0x587c35f2--)
        {
            int _0x7ecde89f = _0x2c0fb4bd.Next(_0x587c35f2 + 1);
            int _0x29a6de31 = _0x4f9efb6e[_0x587c35f2];
            _0x4f9efb6e[_0x587c35f2] = _0x4f9efb6e[_0x7ecde89f];
            _0x4f9efb6e[_0x7ecde89f] = _0x29a6de31;
        }
    }

    public _0x48681af8 Build(int _0xaf4dbe3f, int _0x3e8b24d0, bool _0xb29a063b)
    {
        int _0xdf178033 = _0x2861135b.Row(_0xaf4dbe3f);
        int _0xea8e41c6 = _0x2861135b.SlotCounts[_0xdf178033];
        int _0x8d9baf84 = _0x2861135b.ChipCounts[_0xdf178033];
        if (_0xb29a063b && _0x8d9baf84 < 8)
            _0x8d9baf84 += 2;
        int _0xc9d8478e = (_0xaf4dbe3f + 1) * 7919 ^ (_0x3e8b24d0 + 1) * 104729;
        System.Random _0x62a6650e = new System.Random(_0xc9d8478e);
#if B_LOGS
        {
            Debug.Log($"[stage] performance={_0xaf4dbe3f} attempt={_0x3e8b24d0} seed={_0xc9d8478e} slots={_0xea8e41c6} chips={_0x8d9baf84}");
        }

#endif
        _0x48681af8 _0x3d826b64 = this._0x0649b490(_0x62a6650e, _0xea8e41c6, _0x8d9baf84);
        for (int _0xfebc72b9 = 0; _0xfebc72b9 < 20 && !this._0xf472fbef(_0x3d826b64, _0xea8e41c6, _0x8d9baf84); _0xfebc72b9++)
            _0x3d826b64 = this._0x0649b490(_0x62a6650e, _0xea8e41c6, _0x8d9baf84);
        if (!this._0xf472fbef(_0x3d826b64, _0xea8e41c6, _0x8d9baf84))
            _0x3d826b64 = this._0x62906ca5(_0xea8e41c6, _0x8d9baf84);
        this._0xf862bac2 = _0x3d826b64;
        return _0x3d826b64;
    }

    private _0x48681af8 _0x62906ca5(int _0xa26c1b57, int _0x59039a35)
    {
        _0x48681af8 _0xb95307a4 = new _0x48681af8();
        _0xb95307a4.Columns = _0x59039a35 <= 4 ? 2 : (_0x59039a35 <= 6 ? 3 : 4);
        _0xb95307a4.SlotOrder = _0xa26c1b57 >= 3 ? new[]
        {
            FeatureEyes,
            FeatureColour,
            FeaturePlume
        }

        : new[]
        {
            FeatureEyes,
            FeatureColour
        };
        _0xb95307a4.SampleVariants = new[]
        {
            0,
            0,
            _0xa26c1b57 >= 3 ? 0 : -1
        };
        List<int> _0xfa7a5fc1 = new List<int>();
        List<int> _0x12999925 = new List<int>();
        for (int _0xc656c116 = 0; _0xc656c116 < _0xb95307a4.SlotOrder.Length; _0xc656c116++)
        {
            _0xfa7a5fc1.Add(_0xb95307a4.SlotOrder[_0xc656c116]);
            _0x12999925.Add(0);
        }

        int _0x8df701fe = 1;
        while (_0xfa7a5fc1.Count < _0x59039a35)
        {
            int _0x2c61e5cf = _0xfa7a5fc1.Count % 2 == 0 ? FeatureEyes : FeatureColour;
            int _0x68c0a45c = _0x8df701fe % _0xd2a4c7f5[_0x2c61e5cf];
            if (_0x68c0a45c == 0)
                _0x68c0a45c = 1;
            bool _0x0a04be18 = false;
            for (int _0x3bb0adb9 = 0; _0x3bb0adb9 < _0xfa7a5fc1.Count; _0x3bb0adb9++)
                if (_0xfa7a5fc1[_0x3bb0adb9] == _0x2c61e5cf && _0x12999925[_0x3bb0adb9] == _0x68c0a45c)
                    _0x0a04be18 = true;
            if (!_0x0a04be18)
            {
                _0xfa7a5fc1.Add(_0x2c61e5cf);
                _0x12999925.Add(_0x68c0a45c);
            }

            _0x8df701fe++;
            if (_0x8df701fe > 40)
                break;
        }

        _0xb95307a4.ChipFeatures = _0xfa7a5fc1.ToArray();
        _0xb95307a4.ChipVariants = _0x12999925.ToArray();
        return _0xb95307a4;
    }

    public const int FeaturePlume = 2;
    private _0x48681af8 _0xf862bac2;
}