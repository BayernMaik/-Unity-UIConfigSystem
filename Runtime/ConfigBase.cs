using UnityEngine;

namespace UI
{
    [System.Serializable]
    public abstract class ConfigBase<T>
    {
        #region Attributes
        [SerializeField] private T reference;
        #endregion
        #region Properties
        public T Reference
        {
            get { return this.reference; }
            set { this.reference = value; }
        }
        #endregion
        #region Constructors
        public ConfigBase(){}
        public ConfigBase(T reference)
        {
            this.reference = reference;
        }
        #endregion
        #region Methods
        public T GetReference()
        {
            return this.reference;
        }
        public void SetReference(T reference)
        {
            this.reference = reference;
        }
        public bool Compare(T reference)
        {
            return
                reference != null &&
                this.reference != null &&
                this.reference.Equals(reference);
        }
        #endregion
    }
}