using Survival.UI;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;

internal class CreateUIMap
{
    public static string Flag = "Binding_";

    [MenuItem("Tools/UIGenerator")]
    public static void Create()
    {
        if (File.Exists(INIUtility.Path))
        {
            File.Delete(INIUtility.Path);
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


        
       


        var serializer = new DataContractSerializer(Fields.GetType());
        using (var sw = new StringWriter())
        {
            using (var writer = new XmlTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented; // indent the Xml so it's human readable
                serializer.WriteObject(writer, Fields);
                writer.Flush();
                Debug.Log(sw.ToString());
            }
        }


        //foreach (var item in Fields)
        //{
        //    int index = 0;

        //    foreach (var fd in item.Value)
        //    {
        //        INIUtility.Write(item.Key, index.ToString(), fd);
        //        index++;
        //    }
        //}

        //Debug.Log(INIUtility.Path);
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

