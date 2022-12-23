using Survival.Extensions;
using UnityEditor;
using UnityEngine;

namespace Survival.Editor
{
    [CustomPropertyDrawer(typeof(Optional<>))]
    internal class OptionalPropertyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var value = property.FindPropertyRelative("Value");

            //if (value == null)
            //{
            //    value = property.FindPropertyRelative("<Value>k__BackingField");
            //}

            return EditorGUI.GetPropertyHeight(value);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var value = property.FindPropertyRelative("Value");
            var enable = property.FindPropertyRelative("Enable");

            position.width -= 24;
            EditorGUI.BeginDisabledGroup(!enable.boolValue);
            EditorGUI.PropertyField(position, value, label, true);
            EditorGUI.EndDisabledGroup();

            position.x = position.width + 24;
            position.width = position.height = EditorGUI.GetPropertyHeight(enable);
            position.x -= position.width;
            EditorGUI.PropertyField(position, enable, GUIContent.none);
        }
    }
}
