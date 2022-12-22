using Survival.Extensions;
using Unity.VisualScripting.YamlDotNet.Core.Tokens;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Survival.Editor
{
    [CustomPropertyDrawer(typeof(Optional<>))]
    public class OptionalPropertyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var value = property.FindPropertyRelative("<Value>k__BackingField"); ;

            return EditorGUI.GetPropertyHeight(value);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var value = property.FindPropertyRelative("<Value>k__BackingField");
            var enable = property.FindPropertyRelative("<Enable>k__BackingField");

            position.width -= 24;
            EditorGUI.BeginDisabledGroup(!enable.boolValue);
            EditorGUI.PropertyField(position, value, label, true);
            EditorGUI.EndDisabledGroup();

            position.x += position.width + 24;
            position.width = position.height = EditorGUI.GetPropertyHeight(enable);
            position.x -= position.width;
            EditorGUI.PropertyField(position, enable, GUIContent.none);
        }
    }
}
