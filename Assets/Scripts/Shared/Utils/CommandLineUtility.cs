using System;

/// <summary>
/// �����а�����
/// </summary>
public static class CommandLineUtility 
{
    /// <summary>
    /// ��ȡ��������������
    /// </summary>
    /// <returns></returns>
    public static string GetValue(string key)
    {
        string[] args = Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].Equals($"-{key}", StringComparison.OrdinalIgnoreCase))
            {
                return args[i + 1];
            }
        }

        return string.Empty;
    }
}
