using System;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[CustomEditor(typeof(View), true)]
public class ViewEditor : Editor
{
    bool _showFoldout;

    public override void OnInspectorGUI()
    {
        _showFoldout = EditorGUILayout.BeginFoldoutHeaderGroup(_showFoldout, "Fields");
        if (_showFoldout)
        {
            var fs = target.GetType().GetFields();

            foreach (var item in fs)
            {
                EditorGUILayout.LabelField(item.Name);
            }
        }
        EditorGUILayout.EndFoldoutHeaderGroup();

        if (!Application.isPlaying)
        {
            var view = (View)target;
            bool PrefabMode = EditorSceneManager.IsPreviewSceneObject(view.gameObject);

            if (!PrefabMode)
            {
                return;
            }

            if (GUILayout.Button("生成脚本"))
            {

                var @params = view.transform.GetBindingList();
                @params.WriteMap(view.GetType().FullName);

                var script = MonoScript.FromMonoBehaviour(view);
                var path = AssetDatabase.GetAssetPath(script);
                AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
                Unity.CodeEditor.CodeEditor.CurrentEditor.SyncAll();
                EditorApplication.delayCall += () =>
                {
                    serializedObject.Update();
                    view = (View)serializedObject.targetObject;

                    foreach (var item in @params)
                    {
                        try
                        {
                            var field = view.GetType().GetField(item.Key);
                            field.SetValue(view, item.Value);
                        }
                        catch
                        {
                            Debug.Log($"{item.Key}赋值失败");
                        }
                    }
                    EditorUtility.SetDirty(view.gameObject);
                };
            }
        }
    }
}
