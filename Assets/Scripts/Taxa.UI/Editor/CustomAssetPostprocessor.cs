using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

//public class PostProcessImportAsset : AssetPostprocessor
//{
//    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
//    {
//        Debug.Log(importedAssets.FirstOrDefault());
//    }
//}

public class PostProcessImportAsset : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (var path in importedAssets)
        {
            if (!path.EndsWith(".prefab"))
            {
                return;
            }

            var go = AssetDatabase.LoadAssetAtPath<GameObject>(path);

            if (go == null)
            {
                return;
            }

            View view = go.GetComponent<View>();

            if (view == null)
            {
                return;
            }

            var @params = view.transform.GetBindingList();

            foreach (var item in @params)
            {
                var field = view.GetType().GetField(item.Key);
                if (field!=null)
                {
                    field.SetValue(view, item.Value);
                }
            }

            EditorUtility.SetDirty(view);
        }
    }
}
