using PlayFab;
using PlayFab.ClientModels;

namespace Toranzo.Playfab
{
    public class LoginPlayfabPC : BaseLogin
    {
        public LoginPlayfabPC(IEventDataReceiver<LoginResult> loginSuccess, IEventDataReceiver<string> loginFailed,
                    ITypeLoginGetter sOPlayfabTypeEvent) : base(loginSuccess, loginFailed, sOPlayfabTypeEvent)
        {

        }

        public override void StartMakeLogin()
        {
            LoginWithCustomIDRequest request = GetLoginCustomIDRequest();
            PlayFabClientAPI.LoginWithCustomID(request, LoginSuccess, LoginFailed);
        }

        private LoginWithCustomIDRequest GetLoginCustomIDRequest()
        {
            return new LoginWithCustomIDRequest 
            { 
                CustomId = "GettingStartedGuide", 
                CreateAccount = true 
            };
        }
    }
}