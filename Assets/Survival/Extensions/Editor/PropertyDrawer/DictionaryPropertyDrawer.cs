using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Survival.Editor
{
    [CustomPropertyDrawer(typeof(Dictionary<int,int>))]
    internal class DictionaryPropertyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return 40;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.ColorField(position,Color.red);
        }
    }
}
