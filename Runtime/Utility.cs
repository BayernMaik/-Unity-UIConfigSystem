using UnityEngine;

namespace UI
{
    public static class Utility
    {
        /*
        public static ConfigScriptableObject<T, U> CreateInstance<T, U>(T reference, U data)
        {
            ConfigScriptableObject<T, U> instance = (ConfigScriptableObject<T, U>)ScriptableObject.CreateInstance(typeof(ConfigScriptableObject<T, U>));

            Debug.Log(instance);

            instance.SetReference(reference);
            instance.SetData(data);
            return instance;
        }

        public static ConfigCollectionScriptableObject<T, U> CreateInstance<T, U>()
        {
            return ScriptableObject.Instantiate(typeof(ConfigScriptableObject<T,U>));
            return (ConfigCollectionScriptableObject<T, U>)ScriptableObject.CreateInstance(typeof(ConfigCollectionScriptableObject<T, U>));
        }
        public static ConfigCollectionScriptableObject<T, U> CreateInstance<T, U>(ConfigScriptableObject<T, U>[] data)
        {
            ConfigCollectionScriptableObject<T, U> instance = (ConfigCollectionScriptableObject<T, U>)ScriptableObject.CreateInstance(typeof(ConfigCollectionScriptableObject<T, U>));
            instance.SetData(data);
            return instance;
        }
        */
    }
}