using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab.Installer
{
    public class ChainAndroidDeviceInstaller : MonoInstaller<IChainTypeDevice>
    {
        [SerializeField] private DeviceTypeEventSO _SOPlayfabTypeEvent;

        protected override IChainTypeDevice GetDataType()
        {
            return new ChainAndroidDevice(_SOPlayfabTypeEvent);
        }
    }
}