using System;

/// <summary>
/// 命令行帮助类
/// </summary>
public static class CommandLineUtility 
{
    /// <summary>
    /// 获取命令行启动参数
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
