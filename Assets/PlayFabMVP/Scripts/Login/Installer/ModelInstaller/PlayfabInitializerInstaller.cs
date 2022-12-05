using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab.Installer
{
    public class PlayfabInitializerInstaller : MonoInstaller<PlayfabLoginInitializer>
    {
        [SerializeField] private MonoInstaller<ITypeDeviceLoginSelector> _typeDeviceLogin;

        protected override PlayfabLoginInitializer GetDataType()
        {
            return new PlayfabLoginInitializer(_typeDeviceLogin.Data);
        }
    }
}