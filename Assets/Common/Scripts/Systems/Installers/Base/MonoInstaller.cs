using UnityEngine;

namespace Toranzo.Installer
{
    public abstract class MonoInstaller<DataType> : MonoInstaller
    {
        public DataType Data => _dataType;

        private DataType _dataType;

        public override void Install()
        {
            _dataType = GetDataType();
        }

        protected abstract DataType GetDataType();
    }
    public abstract class MonoInstaller : MonoBehaviour
    {
        public abstract void Install();
    }
}