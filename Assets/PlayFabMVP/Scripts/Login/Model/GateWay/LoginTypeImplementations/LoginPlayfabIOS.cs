using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class LoginPlayfabIOS : BaseLogin
    {
        public LoginPlayfabIOS(IEventDataReceiver<LoginResult> loginSuccess, IEventDataReceiver<string> loginFailed,
            ITypeLoginGetter sOPlayfabTypeEvent) : base(loginSuccess, loginFailed, sOPlayfabTypeEvent)
        {
        }

        public override void StartMakeLogin()
        {
            LoginWithIOSDeviceIDRequest iosRequest = GetLoginWithIOSRequest();
            PlayFabClientAPI.LoginWithIOSDeviceID(iosRequest, LoginSuccess, LoginFailed);
        }

        private LoginWithIOSDeviceIDRequest GetLoginWithIOSRequest()
        {
            return new LoginWithIOSDeviceIDRequest
            {
                DeviceId = SystemInfo.deviceUniqueIdentifier,
                CreateAccount = true
            };
        }
    }
}