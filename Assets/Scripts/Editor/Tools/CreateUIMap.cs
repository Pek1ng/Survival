using Survival.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Progress;

internal class CreateUIMap
{
    public static string Flag = "Binding_";

    [MenuItem("Tools/UIGenerator/GenerateMapping")]
    public static void Create()
    {
        var parent = Directory.GetParent(ConfigUtility.Path);
        if (!parent.Exists)
        {
            parent.Create();
        }

        if (File.Exists(ConfigUtility.Path))
        {
            File.Delete(ConfigUtility.Path);
        }

        Dictionary<string, List<string>> Fields = new Dictionary<string, List<string>>();

        string[] paths = AssetDatabase.FindAssets("t:Prefab", new string[] { "Assets" })
            .Select(g => AssetDatabase.GUIDToAssetPath(g)).ToArray();
        foreach (var path in paths)
        {
            GameObject go = AssetDatabase.LoadAssetAtPath<GameObject>(path);

            View component = go.GetComponent<View>();

            if (component != null)
            {
                List<GameObject> childs = new List<GameObject>();
                GetBinding(component.transform, childs);
                if (!Fields.ContainsKey(component.GetType().Name))
                {
                    Fields.Add(component.GetType().FullName, childs.Select(go => go.name.Substring(Flag.Length)).ToList());
                }
            }
        }

        foreach (var item in Fields)
        {
            ConfigUtility.Write(item.Key, item.Value);
        }

        AssetDatabase.Refresh();
        Debug.Log($"生成成功,映射文件位置：{ConfigUtility.Path}");
    }

    [MenuItem("Tools/UIGenerator/OpenFolder")]
    public static void OpenFolder()
    {
        System.Diagnostics.Process.Start("explorer.exe", Directory.GetParent(ConfigUtility.Path).FullName);
    }

    public static void GetBinding(Transform parent, List<GameObject> list)
    {
        for (int i = 0; i < parent.childCount; i++)
        {
            var child = parent.GetChild(i);
            if (child.name.StartsWith(Flag))
            {
                list.Add(child.gameObject);
            }
            GetBinding(child, list);
        }
    }
}

