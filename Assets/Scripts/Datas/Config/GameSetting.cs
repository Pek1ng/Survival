using Survival.Datas;
using System;
using System.IO;

/// <summary>
/// ��Ϸ����
/// </summary>
[Serializable]
public sealed class GameSetting
{
    /// <summary>
    /// ���ô�ŵ�Ŀ¼
    /// </summary>
    public static readonly string Path =
#if UNITY_ANDROID || UNITY_IOS
       Application.persistentDataPath + "/Setting";
#else
#if UNITY_EDITOR
       Directory.GetCurrentDirectory() + "\\Setting";
#else
       Application.dataPath + "/Setting";
#endif
#endif

    public Sound Sound { get; set; }
}

