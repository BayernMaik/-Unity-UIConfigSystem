using UnityEngine;

namespace UI
{
    public class ConfigCollection<T, U>
    {
        #region Attributes
        [SerializeField] private Config<T, U>[] configs;
        #endregion
        #region Properties
        public Config<T, U>[] Configs
        {
            get { return this.configs; }
            set { this.configs = value; }
        }
        #endregion
        #region Constructors
        public ConfigCollection(){}
        public ConfigCollection(Config<T, U>[] configs)
        {
            this.configs = configs;
        }
        #endregion
        #region Methods
        public Config<T, U> GetConfig(T reference)
        {
            if (this.configs != null && reference != null)
            {
                foreach (Config<T, U> config in this.configs)
                {
                    if (config != null && config.Compare(reference))
                    {
                        return config;
                    }
                }
            }
            return null;
        }
        #endregion
    }
}