using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

internal class CreateUIMap
{
    public static string Flag = "RD_";

   // [MenuItem("Tools/UIGenerator/GenerateMapping")]
    //public static void Create()
    //{
    //    var parent = Directory.GetParent(GeneratorUtility.ConfigPath);
    //    if (!parent.Exists)
    //    {
    //        parent.Create();
    //    }

    //    if (File.Exists(GeneratorUtility.ConfigPath))
    //    {
    //        File.Delete(GeneratorUtility.ConfigPath);
    //    }

    //    Dictionary<string, List<string>> Fields = new Dictionary<string, List<string>>();

    //    string[] paths = AssetDatabase.FindAssets("t:Prefab", new string[] { "Assets" })
    //        .Select(g => AssetDatabase.GUIDToAssetPath(g)).ToArray();
    //    foreach (var path in paths)
    //    {
    //        GameObject go = AssetDatabase.LoadAssetAtPath<GameObject>(path);

    //        View component = go.GetComponent<View>();

    //        if (component != null)
    //        {
    //            List<GameObject> childs = new List<GameObject>();
    //            GetBindingList(component.transform, childs);
    //            if (!Fields.ContainsKey(component.GetType().Name))
    //            {
    //                Fields.Add(component.GetType().FullName, childs.Select(go => go.name.Substring(Flag.Length)).ToList());
    //            }
    //        }
    //    }


    //    foreach (var item in Fields)
    //    {
    //        var repeatValues = item.Value.GroupBy(x => x)
    //                  .Where(g => g.Count() > 1)
    //                  .Select(y => y.Key);

    //        if (repeatValues.Count() > 1)
    //        {
    //            Debug.LogError($"{item.Key}，拥有重复的值:{string.Join(",",repeatValues)}");
    //            continue;
    //        }

    //        GeneratorUtility.Write(item.Key, item.Value);
    //    }

    //    AssetDatabase.Refresh();
    //    Debug.Log($"生成成功,映射文件位置：{GeneratorUtility.ConfigPath}");
    //}

    //[MenuItem("Tools/UIGenerator/OpenFolder")]
    //public static void OpenFolder()
    //{
    //    System.Diagnostics.Process.Start("explorer.exe", Directory.GetParent(GeneratorUtility.ConfigPath).FullName);
    //}

    //public static void GetBindingList(Transform parent, List<GameObject> list)
    //{
    //    for (int i = 0; i < parent.childCount; i++)
    //    {
    //        var child = parent.GetChild(i);
    //        if (child.name.StartsWith(Flag))
    //        {
    //            list.Add(child.gameObject);
    //        }
    //        GetBindingList(child, list);
    //    }
    //}
}

