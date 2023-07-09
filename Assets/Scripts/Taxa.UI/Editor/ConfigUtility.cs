using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System;
using UnityEngine;
using System.Linq;
using System.IO;

/// <summary>
/// 工具类
/// </summary>
public static class GeneratorUtility
{
    public const string BINDING_FLAG = "RD_";

   // public static string ConfigPath = Path.Combine(Environment.GetFolderPath(
   //Environment.SpecialFolder.ApplicationData), "UIGenerator", "Config.ini");

    public static string UIMapPath = Path.Combine(Directory.GetCurrentDirectory(), "ProjectSettings", "UIMap.ini");

    public static void WriteMap(string section, string key, string value)
    {
        WritePrivateProfileString(section, key, value, UIMapPath);  
    }

    public static void WriteMap(string section, List<string> values)
    {
        WriteMap(section, null, null);

        for (int i = 0; i < values.Count; i++)
        {
            WriteMap(section, i.ToString(), values[i]);
        }
    }

    public static string GetMap(string section, string key)
    {
        StringBuilder result = new StringBuilder();
        GetPrivateProfileString(section, key, "", result, 250, UIMapPath);

        return result.ToString();
    }

    public static Dictionary<string, GameObject> GetBindingList(this Transform parent)
    {
        Dictionary<string, GameObject> map = new();

        FindBinding(parent, map);
        return map;
    }

    public static void WriteMap(this Dictionary<string, GameObject> map, string section)
    {
        WriteMap(section, map.Select(kv => kv.Key).ToList());
    }

    public static string FindAssetsFolder(string path)
    {
        DirectoryInfo directory = new DirectoryInfo(path);
        while (directory.Parent != null)
        {
            if (directory.Name == "Assets")
            {
                return directory.FullName;
            }
            directory = directory.Parent;
        }
        return null;
    }

    private static void FindBinding(Transform parent, Dictionary<string, GameObject> map)
    {
        for (int i = 0; i < parent.childCount; i++)
        {
            var child = parent.GetChild(i);
            var name = child.name;

            if (name.StartsWith(BINDING_FLAG))
            {
                try
                {
                    map.Add(child.name.Substring(BINDING_FLAG.Length), child.gameObject);
                }
                catch
                {
                    Debug.Log($"拥有重复的物体名:{name}");
                }
            }

            FindBinding(child, map);
        }
    }

    [DllImport("kernel32.dll")]
    public static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

    [DllImport("kernel32.dll")]
    public static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);
}