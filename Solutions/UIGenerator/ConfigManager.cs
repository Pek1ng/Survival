using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

/// <summary>
/// INIπ§æﬂ¿‡
/// </summary>
public class ConfigManager
{
    public static ConfigManager Instance = new ConfigManager();

    public static string ProjectPath = null;

    public string ConfigPath => Path.Combine(ProjectPath, "ProjectSettings", "UIMap.ini");

    public string LogPath => Path.Combine(ProjectPath, "Logs", "UI.txt");

    public static void Write(string section, string key, string value)
    {
        WritePrivateProfileString(section, key, value, Instance.ConfigPath);
    }

    public static string Get(string section, string key)
    {
        StringBuilder result = new StringBuilder();
        GetPrivateProfileString(section, key, "", result, 250,Instance.ConfigPath);

        return result.ToString();
    }

    public static string FindProjectFolder(string path)
    {
        DirectoryInfo directory = new DirectoryInfo(path);
        while (directory.Parent != null)
        {
            if (directory.Name == "Assets")
            {
                return directory.Parent.FullName;
            }
            directory = directory.Parent;
        }
        return null;
    }

    [DllImport("kernel32.dll")]
    private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

    [DllImport("kernel32.dll")]
    private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);
}