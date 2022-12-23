using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Survival.Editor
{
    [CustomEditor(typeof(MonoBehaviour), true)]
    internal class MonoBehaviorEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {

            base.OnInspectorGUI();


            //var fs = serializedObject.targetObject.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            //foreach (var item in fs)
            //{
            //    if (Showable(item))
            //    {
            //        var text= item.Name.Replace("<", "").Replace(">", "").Replace("k__BackingField","");
            //    }
            //}
        }

        private bool Showable(FieldInfo fieldInfo)
        {
            //判断是字典并且可以显示
            bool isDictionary =fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(Dictionary<,>);
            bool publicOrHaveAttribute = fieldInfo.IsPublic | Attribute.IsDefined(fieldInfo, typeof(SerializeField));

            return isDictionary && publicOrHaveAttribute;
        }
    }
}
