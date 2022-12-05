using System;
using PlayFab.ClientModels;

namespace Toranzo.Playfab
{
    public class LoginSuccessUseCase : IEventLoginSuccessReceiver
    {
        public Action<string> OnReceiveLoginMessage { get; set; }

        public LoginSuccessUseCase(IEventDataReceiver<LoginResult> eventDataReceiver)
        {
            eventDataReceiver.OnReceiveEvent += ReceiveNewSuccessLogin;
        }

        private void ReceiveNewSuccessLogin(LoginResult loginResult)
        {
            OnReceiveLoginMessage?.Invoke(loginResult.PlayFabId);
        }
    }
}
