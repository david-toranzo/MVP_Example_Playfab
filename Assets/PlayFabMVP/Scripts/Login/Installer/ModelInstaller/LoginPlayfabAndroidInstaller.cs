using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab.Installer
{
    public class LoginPlayfabAndroidInstaller : MonoInstaller<IBaseLogin>
    {
        [SerializeField] private LoginSuccessEventReceiverSO _SOLoginSuccess;
        [SerializeField] private FailedEventReceiverSO _SOLoginFailed;
        [SerializeField] private DeviceTypeEventSO _SOTypeEvent;

        protected override IBaseLogin GetDataType()
        {
            return new LoginPlayfabAndroid(_SOLoginSuccess, _SOLoginFailed, _SOTypeEvent);
        }
    }
}