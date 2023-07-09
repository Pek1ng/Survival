using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

/// <summary>
/// INIπ§æﬂ¿‡
/// </summary>
public static class ConfigUtility
{
    public static string ConfigFolder = Path.Combine(Environment.GetFolderPath(
   Environment.SpecialFolder.ApplicationData), "UIGenerator");

    public static string ConfigPath = Path.Combine(ConfigFolder, "UI.ini");

    public static string LogPath = Path.Combine(ConfigFolder, "Logs.txt");

    public static string GenPath = Path.Combine(ConfigFolder, "Gen");

    public static void Write(string section, string key, string value)
    {
        WritePrivateProfileString(section, key, value, ConfigPath);
    }

    public static string Get(string section, string key)
    {
        StringBuilder result = new StringBuilder();
        GetPrivateProfileString(section, key, "", result, 250, ConfigPath);

        return result.ToString();
    }

    [DllImport("kernel32.dll")]
    private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

    [DllImport("kernel32.dll")]
    private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);
}