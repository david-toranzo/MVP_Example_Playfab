using Patterns.Factory;
using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab.Installer
{
    public class TypeDeviceLoginSelectorInstaller : MonoInstaller<ITypeDeviceLoginSelector>
    {
        [SerializeField] private MonoInstaller<IChainTypeDevice>[] _chainTypeDevices;
        [SerializeField] private MonoInstaller<Factory<string, IBaseLogin>> _factoryLogin;

        protected override ITypeDeviceLoginSelector GetDataType()
        {       
            IChainTypeDevice[] chainTypeDevices = new IChainTypeDevice[_chainTypeDevices.Length];

            for (int i = 0; i < chainTypeDevices.Length; i++)
            {
                chainTypeDevices[i] = _chainTypeDevices[i].Data;
            }

            return new TypeDeviceLoginSelector(chainTypeDevices, _factoryLogin.Data);
        }
    }
}