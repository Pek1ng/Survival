using System;
using System.Runtime.InteropServices;
using System.Text;

/// <summary>
/// INIπ§æﬂ¿‡
/// </summary>
public static class INIUtility
{
    public static string Path = Environment.CurrentDirectory + @"\ProjectSettings\UI.ini";

    public static void Write(string section, string key, string value)
    {
        WritePrivateProfileString(section, key, value, Path);
    }

    public static string Get(string section, string key)
    {
        StringBuilder result = new StringBuilder();
        GetPrivateProfileString(section, key, "", result, 250, Path);

        return result.ToString();
    }

    [DllImport("kernel32.dll")]
    private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

    [DllImport("kernel32.dll")]
    private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);
}
