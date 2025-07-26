using System;
using UnityEngine;

namespace UI
{
    /// <summary>
    /// Config to map a key of specified type with a value of specified type
    /// </summary>
    /// <typeparam name="T">Type for Config's key</typeparam>
    /// <typeparam name="U">Type for Config's value</typeparam>
    [Serializable]
    public class Config<T, U> : ConfigBase<T>
    {
        #region Attributes
        /// <summary>
        /// Config value
        /// </summary>
        [SerializeField] protected U value;
        #endregion
        #region Properties
        /// <summary>
        /// Config value
        /// </summary>
        public U Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Constructor for Config
        /// </summary>
        public Config() { }
        /// <summary>
        /// Parameter Constructor for Config
        /// </summary>
        /// <param name="key">Key for Config</param>
        public Config(T key) : base(key) { }
        /// <summary>
        /// Parameter Constructor for Config
        /// </summary>
        /// <param name="value">Value for Config</param>
        public Config(U value)
        {
            this.value = value;
        }
        /// <summary>
        /// Parameter Constructor for Config
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="data"></param>
        public Config(T reference, U data) : base(reference)
        {
            this.value = data;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Set value to Config
        /// </summary>
        /// <param name="value"></param>
        public void SetValue(U value)
        {
            this.value = value;
        }
        /// <summary>
        /// Get value from Config
        /// </summary>
        /// <returns></returns>
        public U GetValue()
        {
            return this.value;
        }
        /*
        public U GetValue<U>() // IConfig
        {
            if (this.value != null && this.value is U)
            {
                return (U)Convert.ChangeType(this.value, typeof(U));
            }
            return default(U);
        }
        */
        #endregion
    }
}