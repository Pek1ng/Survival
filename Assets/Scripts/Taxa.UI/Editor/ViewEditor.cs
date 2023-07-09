using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(View), true)]
public class ViewEditor : Editor
{
    bool showFoldout;

    Dictionary<string,GameObject> _params = new Dictionary<string,GameObject>();

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        showFoldout = EditorGUILayout.BeginFoldoutHeaderGroup(showFoldout, "Params");
        if (showFoldout)
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
            if (GUILayout.Button("Éú³É½Å±¾"))
            {
                var view = (View)target;
                _params = view.transform.GetBindingList(); 
                _params.WriteMap(view.GetType().FullName);

                var script = MonoScript.FromMonoBehaviour(view);
                var path = AssetDatabase.GetAssetPath(script);
                AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
                AssetDatabase.Refresh();
                Unity.CodeEditor.CodeEditor.CurrentEditor.SyncAll();
            }
        }   
    }
}
