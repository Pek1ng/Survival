using Survival.Extensions;
using UnityEditor;
using UnityEngine;

namespace Survival.Editor
{
    [CustomPropertyDrawer(typeof(DisplayOnly))]
    public class DisplayOnlyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property, label, true);
            GUI.enabled = true;
        }
    }
}
