using Patterns.Factory;

namespace Toranzo.Playfab
{
    public class TypeDeviceLoginSelector : ITypeDeviceLoginSelector
    {
        private IChainTypeDevice[] _chainTypeDevices;
        private Factory<string, IBaseLogin> _factoryLogin;

        public TypeDeviceLoginSelector(IChainTypeDevice[] chainTypeDevices, Factory<string, IBaseLogin> factoryLogin)
        {
            _chainTypeDevices = chainTypeDevices;
            _factoryLogin = factoryLogin;
        }

        public IBaseLogin GetTypeLogin()
        {
            string typeLogin = GetNameLoginTypeFromFactory();
            return _factoryLogin.GetObjectType(typeLogin);
        }

        private string GetNameLoginTypeFromFactory()
        {
            for (int i = 0; i < _chainTypeDevices.Length; i++)
            {
                if (_chainTypeDevices[i].IsThisDeviceCorrectType())
                    return _chainTypeDevices[i].GetTypeLoginString();
            }

            return null;
        }
    }
}