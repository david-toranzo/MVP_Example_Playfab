using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class LoginPlayfabAndroid : BaseLogin
    {
        public LoginPlayfabAndroid(IEventDataReceiver<LoginResult> loginSuccess, IEventDataReceiver<string> loginFailed,
            ITypeLoginGetter sOPlayfabTypeEvent) : base(loginSuccess, loginFailed, sOPlayfabTypeEvent)
        {

        }

        public override void StartMakeLogin()
        {
            LoginWithAndroidDeviceIDRequest androidRequest = GetLoginWithAndroidRequest();
            PlayFabClientAPI.LoginWithAndroidDeviceID(androidRequest, LoginSuccess, LoginFailed);
        }

        private LoginWithAndroidDeviceIDRequest GetLoginWithAndroidRequest()
        {
            LoginWithAndroidDeviceIDRequest loginWithAndroidDeviceIDRequest = new LoginWithAndroidDeviceIDRequest
            {
                AndroidDevice = SystemInfo.deviceUniqueIdentifier,
                CreateAccount = true
            };

            return loginWithAndroidDeviceIDRequest;
        }
    }
}