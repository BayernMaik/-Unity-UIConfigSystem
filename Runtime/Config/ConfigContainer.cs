using System.Collections.Generic;
using System.Linq;

namespace UI
{
    /// <summary>
    /// Container for a List of ConfigCollection's.
    /// This container can hold ConfigCollection's of different types.
    /// </summary>
    public class ConfigContainer
    {
        #region Attributes
        /// <summary>
        /// List of ConfigCollection's for this Container
        /// </summary>
        private List<ConfigCollectionBase> collections;
        #endregion
        #region Properties
        /// <summary>
        /// List of ConfigCollection's for this Container
        /// </summary>
        public List<ConfigCollectionBase> Collections
        {
            get { return this.collections; }
            set { this.collections = value; }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Constructor for ConfigContainer
        /// </summary>
        public ConfigContainer()
        {
            this.collections = new List<ConfigCollectionBase>();
        }
        /// <summary>
        /// Parameter Constructor for ConfigContainer
        /// </summary>
        /// <param name="collection">Config Collections for Container</param>
        public ConfigContainer(List<ConfigCollectionBase> collection)
        {
            this.collections = collection;
        }
        /// <summary>
        /// Parameter Constructor for ConfigContainer
        /// </summary>
        /// <param name="collection">Config Collections for Container</param>
        public ConfigContainer(params ConfigCollectionBase[] collection)
        {
            this.collections = collection.ToList();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get first Config of specified type for given key.
        /// </summary>
        /// <typeparam name="T">Type for key</typeparam>
        /// <typeparam name="U">Type for value</typeparam>
        /// <param name="reference">Key to get value for</param>
        /// <returns>Config of specified type matching the given key</returns>
        public Config<T, U> GetConfig<T, U>(T reference)
        {
            if (collections != null)
            {
                foreach (ConfigCollectionBase collection in collections)
                {
                    // Debug.Log(collection.GetConfigType().ToString());
                    // Debug.Log(typeof(Config<T, U>).ToString());
                    if (
                        collection != null &&
                        collection.GetConfigType() == typeof(Config<T, U>)
                    )
                    {
                        return ((ConfigList<T, U>)collection).GetConfig(reference);
                    }
                }
            }
            return null;
        }
        #endregion
    }
}