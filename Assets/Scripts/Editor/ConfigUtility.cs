using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System;

/// <summary>
/// INIπ§æﬂ¿‡
/// </summary>
public static class ConfigUtility
{
    public static string Path = System.IO.Path.Combine(Environment.GetFolderPath(
   Environment.SpecialFolder.ApplicationData), "UIGenerator", "UI.ini");

    public static void Write(string section, string key, string value)
    {
        WritePrivateProfileString(section, key, value, Path);
    }

    public static void Write(string section, List<string> values)
    {
        Write(section, null, null);

        for (int i = 0; i < values.Count; i++)
        {
            Write(section, i.ToString(), values[i]);
        }
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