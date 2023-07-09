using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomAssetPostprocessor : AssetPostprocessor
{
    void OnPostprocessPrefab(GameObject g)
    {
        //if (g.TryGetComponent(out View view))
        //{
        //    List<GameObject> list = new List<GameObject>();

        //    Get(view.transform, list);

        //    foreach (var item in list)
        //    {
        //        Debug.Log(item.name);
        //    }
        //}
    }

    public static void Get(Transform parent, List<GameObject> list)
    {
        for (int i = 0; i < parent.childCount; i++)
        {
            var child = parent.GetChild(i);
            if (child.name.StartsWith("Binding_"))
            {
                list.Add(child.gameObject);
            }
            Get(child, list);
        }
    }
}
