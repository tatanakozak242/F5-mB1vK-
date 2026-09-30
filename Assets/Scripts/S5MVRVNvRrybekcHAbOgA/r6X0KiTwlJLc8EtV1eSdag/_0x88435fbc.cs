using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x88435fbc : MonoBehaviour
{
    [HideInInspector]
    public int TimeLeft;
    [HideInInspector]
    public int CurrentGameIndex;
    public int CustomTargetScore = 10;
    private IEnumerator _0xd2700cef()
    {
        this._0x64d856f7();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x279ca21b.Instance._0x6ea1624f == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x279ca21b.Instance._0xfd2919c1)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x64d856f7();
            }
        }

        if (!this.IsGameEnd)
            this._0xff30091a();
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x1fc4ac30;
        this.CurrentGameIndex = _0x279ca21b.Instance._0x6ea1624f;
        foreach (Button _0x40949e57 in this.HomeButtons)
            _0x40949e57.onClick.AddListener(() =>
            {
                this._0xf7e82306();
            });
        foreach (Button _0xb495e0da in this.PauseButtons)
            _0xb495e0da.onClick.AddListener(() =>
            {
                _0x279ca21b.Instance._0x7afb8f10(false);
                _0x35837dc7.Instance._0x028b3e26(_0xab68611e._0xb6633f3a.PAUSE);
            });
        this._0xf9e1d122();
        this.LevelNumberText.ForEach(_0xb54275b4 => _0xb54275b4.text = $"LVL {_0x279ca21b._0x57a0446f._0x40f97b4f + 1}");
        if (_0x22ba7dd5.Instance.IsTimerEnabled)
        {
            this._0x64d856f7();
            this.StartCoroutine(this._0xd2700cef());
        }
    }

    public List<Button> HomeButtons = new();
    public List<Button> PauseButtons = new();
    private static _0x88435fbc _0x4b5b3593;
    private int _0xfd4a7c9a => this.CustomTargetScore + _0x279ca21b._0x57a0446f._0x40f97b4f * 10;
    private int _0xd93b188b => this.ScoreCurrent;

    private void _0xa5d55880()
    {
        if (this.ScoreCurrent >= this._0xfd4a7c9a)
            this._0xfe47f015();
        else
            this._0xff30091a();
    }

    [HideInInspector]
    public int ScoreCurrent;
    private int _0x1fc4ac30 => this.CustomTimeInitial + _0x279ca21b._0x57a0446f._0x40f97b4f * 10;

    public List<TMP_Text> SubtitleText = new();
    public void _0xff30091a()
    {
        if (_0x22ba7dd5.Instance.IsOnlyWinGameEndEnabled)
            this._0xfe47f015();
        if (!this.IsGameEnd)
        {
            this._0xad554e4e();
            _0x279ca21b.IsAfterLevelComplete = false;
            _0x279ca21b.IsAfterLevelFailed = true;
            _0xfd5d95d0 _0x2da4281f = _0x35837dc7.Instance._0x52763680(_0xab68611e._0xb6633f3a.LOSE).GetComponent<_0xfd5d95d0>();
            if (_0x22ba7dd5.Instance.IsCheckScoreEnabled)
                _0x2da4281f.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xfd4a7c9a}";
            else
                _0x2da4281f.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x2da4281f.ContentAdditionalText.text = $"{0}";
            _0xab68611e._0x651c7180._0x022bcc30 += 0;
            _0x35837dc7.Instance._0x028b3e26(_0xab68611e._0xb6633f3a.LOSE);
        }
    }

    private void _0xf9e1d122()
    {
        if (_0x22ba7dd5.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xb54275b4 => _0xb54275b4.text = $"{this.ScoreCurrent}/{this._0xfd4a7c9a}");
        else
            this.ScoreText.ForEach(_0xb54275b4 => _0xb54275b4.text = $"{this.ScoreCurrent}");
    }

    public int CustomTimeInitial = 30;
    public List<TMP_Text> TimerText = new();
    private void Awake()
    {
        _0x4b5b3593 = this.gameObject.GetComponent<_0x88435fbc>();
    }

    public void _0x442942d9(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xf9e1d122();
            this._0x0493bfdd();
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
    public void _0xf7e82306()
    {
        _0x279ca21b.Instance._0x7afb8f10(true);
        _0x279ca21b.Instance.LoadSceneByIndex(_0xab68611e._0x61bc701f.SCENE_0);
    }

    private void _0xad554e4e()
    {
        this.IsGameEnd = true;
        _0x279ca21b.IsAfterLevelComplete = true;
    }

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> ScoreText = new();
    private void _0x64d856f7()
    {
        this.TimerText.ForEach(_0xb54275b4 => _0xb54275b4.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xb7e1bced._0x4c234714(new byte[6] { 113, 113, 64, 38, 111, 111 }, 28)));
    }

    private void _0x0493bfdd()
    {
        if (this.ScoreCurrent > _0x279ca21b._0x57a0446f._0x9a4ad0b0)
            _0x279ca21b._0x57a0446f._0x9a4ad0b0 = this.ScoreCurrent;
        if (_0x22ba7dd5.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xfd4a7c9a)
                this._0xfe47f015();
    }

    public void _0xfe47f015()
    {
        if (!this.IsGameEnd)
        {
            this._0xad554e4e();
            _0x279ca21b.IsAfterLevelComplete = true;
            _0x279ca21b.IsAfterLevelFailed = false;
            _0xfd5d95d0 _0x730a35ee = _0x35837dc7.Instance._0x52763680(_0xab68611e._0xb6633f3a.WIN).GetComponent<_0xfd5d95d0>();
            if (_0x22ba7dd5.Instance.IsCheckScoreEnabled)
                _0x730a35ee.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xfd4a7c9a}";
            else
                _0x730a35ee.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x22ba7dd5.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xab68611e._0x651c7180._0x022bcc30)
                    _0xab68611e._0x651c7180._0x022bcc30 = this.ScoreCurrent;
                _0x730a35ee.ContentAdditionalText.text = $"{_0xab68611e._0x651c7180._0x022bcc30}";
            }
            else
            {
                _0x730a35ee.ContentAdditionalText.text = $"{this._0xd93b188b}";
                _0xab68611e._0x651c7180._0x022bcc30 += this._0xd93b188b;
            }

            if (_0x22ba7dd5.Instance.IsLevelIncrementOnWin)
                ++_0x279ca21b._0x57a0446f._0x40f97b4f;
            _0x35837dc7.Instance._0x028b3e26(_0xab68611e._0xb6633f3a.WIN);
        }
    }
}

internal static class _0xb7e1bced
{
    internal static string _0x4c234714(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}