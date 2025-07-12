using UnityEngine;

namespace UI
{
    public abstract class ConfigScriptableObject<T, U> : ScriptableObject
    {
        #region Attributes
        [SerializeField] private Config<T, U> config;
        #endregion
        #region Properties
        public Config<T, U> Config
        {
            get { return this.config; }
            set { this.config = value; }
        }
        #endregion
        #region Methods
        public Config<T, U> GetConfig()
        {
            return this.config;
        }
        public void SetConfig(Config<T, U> config)
        {
            this.config = config;
        }
        #endregion
    }
}