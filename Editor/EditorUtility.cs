#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

namespace UI
{
    public class EditorUtility
    {
        public static T[] GetAllInstances<T>() where T : ScriptableObject
        {
            string[] guids = AssetDatabase.FindAssets("t:" + typeof(T).Name); //FindAssets uses tags check documentation for more info
            T[] a = new T[guids.Length];
            for (int i = 0; i < guids.Length; i++) //probably could get optimized
            {
                string path = AssetDatabase.GUIDToAssetPath(guids[i]);
                a[i] = AssetDatabase.LoadAssetAtPath<T>(path);
            }
            return a;
        }
        
        public static MonoScript FindScriptReference(string name)
        {
            // Find Script Reference
            string[] assets = AssetDatabase.FindAssets(name, null);
            for (int i = 0; i < assets.Length; i++)
            {
                string assetPath = AssetDatabase.GUIDToAssetPath(assets[i]);
                string[] splitPath = assetPath.Split("/");
                string fileName = splitPath[splitPath.Length - 1];
                if (fileName == name + ".cs")
                {
                    // Debug.Log(AssetDatabase.GetMainAssetTypeAtPath(assetPath));
                    MonoScript monoScript = (MonoScript)AssetDatabase.LoadAssetAtPath(assetPath, typeof(MonoScript));
                    return monoScript;
                }
            }
            return null;
        }
        public static MonoScript ScriptReference(MonoScript monoScript)
        {
            // Script Reference
            bool enable = GUI.enabled;
            GUI.enabled = false;
            MonoScript returnMonoScript = (MonoScript)UnityEditor.EditorGUILayout.ObjectField("Script", monoScript, typeof(MonoScript), true);
            GUI.enabled = true;

            return returnMonoScript;
        }
    }
}

#endif