using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab.Installer
{
    public class ChainDefaultDeviceInstaller : MonoInstaller<IChainTypeDevice>
    {
        [SerializeField] private DeviceTypeEventSO _SOPlayfabTypeEvent;

        protected override IChainTypeDevice GetDataType()
        {
            return new ChainDefaultDevice(_SOPlayfabTypeEvent);
        }
    }
}