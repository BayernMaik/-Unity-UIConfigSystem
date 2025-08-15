using System;
using UnityEngine;

namespace UI
{
    /// <summary>
    /// Base Class for Config
    /// </summary>
    /// <typeparam name="T">Type for Config's key</typeparam>
    [Serializable]
    public abstract class ConfigBase<T>
    {
        #region Attributes
        /// <summary>
        /// Config key
        /// </summary>
        [SerializeField] protected T key;
        #endregion
        #region Properties
        /// <summary>
        /// Config key
        /// </summary>
        public T Key
        {
            get { return this.key; }
            set { this.key = value; }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Constructor for ConfigBase
        /// </summary>
        public ConfigBase() { }
        /// <summary>
        /// Parameter Constructor for ConfigBase
        /// </summary>
        /// <param name="key">Key for ConfigBase</param>
        public ConfigBase(T key)
        {
            this.key = key;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get key to ConfigBase
        /// </summary>
        /// <returns></returns>
        public T GetKey()
        {
            return this.key;
        }
        /// <summary>
        /// Set key to ConfigBase
        /// </summary>
        /// <param name="key"></param>
        public void SetKey(T key)
        {
            this.key = key;
        }
        /// <summary>
        /// Check if Config has matching key
        /// </summary>
        /// <param name="key"></param>
        /// <returns>True if keys match, false otherwise</returns>
        public bool Compare(T key)
        {
            return
                key != null &&
                this.key != null &&
                this.key.Equals(key);
        }
        #endregion
    }
}