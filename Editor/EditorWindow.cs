#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

namespace UI
{
    public class EditorWindow : UnityEditor.EditorWindow
    {
        #region Attributes
        private MonoScript monoScript;
        #endregion
        #region Methods
        /// <summary>
        /// Callback if MenuItem Action is triggered
        /// </summary>
        [MenuItem("Tools/UI System/Settings")]
        public static void MenuItem()
        {
            // Debug In
            // Debug.Log("MenuItem() In");

            // Initialize Editor Window in Inspector
            EditorWindow editorWindow = EditorWindow.GetWindow<EditorWindow>();
            editorWindow.titleContent = new GUIContent("UI System Settings");

            // Script Reference
            editorWindow.monoScript = EditorUtility.FindScriptReference("EditorWindow");

            // Debug Out
            // Debug.Log("MenuItem() Out");
        }
        private void OnGUI()
        {
            // Script Reference
            EditorUtility.ScriptReference(this.monoScript);

            // Header
            UnityEditor.EditorGUILayout.LabelField(
                "UI System Settings",
                EditorStyles.boldLabel
            );

        }
        #endregion
    }
}

#endif