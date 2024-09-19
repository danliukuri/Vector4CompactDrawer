using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Vector4CompactDrawer.Editor
{
    [CustomPropertyDrawer(typeof(Vector4))]
    public class Vector4PropertyDrawer : PropertyDrawer
    {
        private static readonly string[] _fieldNames =
            { nameof(Vector4.x), nameof(Vector4.y), nameof(Vector4.z), nameof(Vector4.w) };

        private static readonly GUIContent[] _fieldLabels =
            _fieldNames.Select(fieldName => new GUIContent(fieldName.ToUpper())).ToArray();

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            using (new EditorGUI.PropertyScope(position, label, property))
            {
                SerializedProperty firstChildProperty = property.FindPropertyRelative(_fieldNames.First());
                EditorGUI.MultiPropertyField(position, _fieldLabels, firstChildProperty, label);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) =>
            EditorGUIUtility.singleLineHeight +
            (EditorGUIUtility.wideMode ? default : EditorGUIUtility.singleLineHeight);
    }
}