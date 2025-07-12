using UnityEngine;

namespace UI
{
    [System.Serializable]
    public class Config<T, U> : ConfigBase<T>
    {
        #region Attributes
        [SerializeField] private U data;
        #endregion
        #region Properties
        public U Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        #endregion
        #region Constructors
        public Config(){}
        public Config(T reference) : base(reference){}
        public Config(U data)
        {
            this.data = data;
        }
        public Config(T reference, U data) : base(reference)
        {
            this.data = data;
        }
        #endregion
        #region Methods
        public U GetData()
        {
            return this.data;
        }
        public void SetData(U data)
        {
            this.data = data;
        }
        #endregion
    }
}