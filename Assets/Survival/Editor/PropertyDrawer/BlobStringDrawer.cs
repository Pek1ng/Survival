using Unity.Entities;
using UnityEditor;
using UnityEngine;

namespace Survival.Editor
{
    [CustomPropertyDrawer(typeof(BlobString))]
    public class BlobStringDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return base.GetPropertyHeight(property, label)*100;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            EditorGUILayout.PropertyField(property, new GUIContent("姓名："));
            EditorGUI.EndProperty();
        }
    }
}
