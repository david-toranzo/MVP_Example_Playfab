using System;

namespace Toranzo.Playfab
{
    public abstract class ChainTypeDevice : IChainTypeDevice
    {
        private ITypeLoginGetter _getTypeEvent;

        protected ChainTypeDevice(ITypeLoginGetter getTypeEvent)
        {
            _getTypeEvent = getTypeEvent;
        }

        public abstract bool IsThisDeviceCorrectType();

        public string GetTypeLoginString()
        {
            return _getTypeEvent.TypeLogin;
        }
    }
}