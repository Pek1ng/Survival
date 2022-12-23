using Survival.Extensions;
using UnityEditor;
using UnityEngine;

namespace Survival.Editor
{
    [CustomPropertyDrawer(typeof(CustomName))]
    internal class CustomNameAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var name = (attribute as CustomName).Name;
            label.text = name;

            EditorGUI.PropertyField(position,property,label);
        }
    }
}
