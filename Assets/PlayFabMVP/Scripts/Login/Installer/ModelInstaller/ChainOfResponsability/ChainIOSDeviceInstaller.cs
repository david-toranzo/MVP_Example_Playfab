using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab.Installer
{
    public class ChainIOSDeviceInstaller : MonoInstaller<IChainTypeDevice>
    {
        [SerializeField] private DeviceTypeEventSO _SOPlayfabTypeEvent;

        protected override IChainTypeDevice GetDataType()
        {
            return new ChainIOSDevice(_SOPlayfabTypeEvent);
        }
    }
}