using System;

namespace UI
{
    /// <summary>
    /// Base class for ConfigCollection
    /// </summary>
    public abstract class ConfigCollectionBase
    {
        // public abstract Config<T, U> GetConfig<T, U>(T key);
        /// <summary>
        /// Reimplement this method to identify derived classes by type
        /// </summary>
        /// <returns></returns>
        public abstract Type GetConfigType();
    }
}