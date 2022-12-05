using PlayFab;
using PlayFab.ClientModels;

namespace Toranzo.Playfab
{
    public abstract class BaseLogin : IBaseLogin
    {
        private IEventDataReceiver<LoginResult> _eventLoginSuccess;
        private IEventDataReceiver<string> _eventLoginFailed;
        private ITypeLoginGetter _SOPlayfabTypeEvent;

        protected BaseLogin(IEventDataReceiver<LoginResult> loginSuccess, IEventDataReceiver<string> loginFailed,
                            ITypeLoginGetter sOPlayfabTypeEvent)
        {
            _eventLoginSuccess = loginSuccess;
            _eventLoginFailed = loginFailed;
            _SOPlayfabTypeEvent = sOPlayfabTypeEvent;
        }

        public abstract void StartMakeLogin();

        protected void LoginSuccess(LoginResult result)
        {
            UnityEngine.Debug.Log("Congratulations, you made your first successful API call!");

            _eventLoginSuccess.InvokeEvent(result);
        }

        protected void LoginFailed(PlayFabError error)
        {
            UnityEngine.Debug.Log("Here's some debug information:");

            _eventLoginFailed.InvokeEvent(error.GenerateErrorReport());
        }

        public string GetTypeLoginString()
        {
            return _SOPlayfabTypeEvent.TypeLogin;
        }
    }
}