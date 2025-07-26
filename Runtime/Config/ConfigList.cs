using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UI
{
    /// <summary>
    /// Container for a List of Configs
    /// </summary>
    /// <typeparam name="T">Reference Key Type</typeparam>
    /// <typeparam name="U">Reference Value Type</typeparam>
    public class ConfigList<T, U> : ConfigCollectionBase
    {
        #region Attributes
        /// <summary>
        /// Config List for this ConfigCollection
        /// </summary>
        [SerializeField] private List<Config<T, U>> configs;
        #endregion
        #region Properties
        /// <summary>
        /// Config List for this ConfigCollection
        /// </summary>
        public List<Config<T, U>> Configs
        {
            get { return this.configs; }
            set { this.configs = value; }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Constructor for ConfigCollection
        /// </summary>
        public ConfigList()
        {
            this.configs = new List<Config<T, U>>();
        }
        /// <summary>
        /// Parameter Constructor for ConfigCollection
        /// </summary>
        /// <param name="configs">Config List to initialize ConfigCollection with</param>
        public ConfigList(List<Config<T, U>> configs)
        {
            this.configs = configs;
        }
        /// <summary>
        /// Parameter Constructor for ConfigCollection
        /// </summary>
        /// <param name="configs">Config Array to initialize ConfigCollection with</param>
        public ConfigList(Config<T, U>[] configs)
        {
            this.configs = configs.ToList();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get Config with given Key
        /// </summary>
        /// <param name="key">Key to find Config for</param>
        /// <returns>Config value for key</returns>
        public Config<T, U> GetConfig(T key)
        {
            if (this.configs != null && key != null)
            {
                foreach (Config<T, U> config in this.configs)
                {
                    if (config != null && config.Compare(key))
                    {
                        return config;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Get Type for generic Config
        /// </summary>
        /// <returns>Type of Config</returns>
        public override Type GetConfigType()
        {
            return typeof(Config<T, U>); // return this.GetType();
        }
        #endregion
    }
}