using UnityEngine;

public class _0x22ba7dd5 : MonoBehaviour
{
    private void _0xed38feba()
    {
    }

    public bool IsTimerEnabled;
    public static _0x22ba7dd5 Instance;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsLevelSelectorEnabled;
    private void _0xf7031172()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsSkipSplashEnabled;
    public bool IsStoryEnabled;
    public bool IsTutorialEnabled;
    public bool IsBestScoreEnabled;
    public bool IsLevelIncrementOnWin;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x22ba7dd5>();
            DontDestroyOnLoad(this.gameObject);
            this._0xf7031172();
        }
        else
        {
            this._0xed38feba();
            Destroy(this.gameObject);
        }
    }
}