using PlayFab.ClientModels;

namespace Toranzo.Playfab
{
    public class LoginSuccessUseCase : EventUseCaseReceiver<LoginResult>
    {
        public LoginSuccessUseCase(IEventDataReceiver<LoginResult> eventDataReceiver) : base(eventDataReceiver)
        {
        }

        protected override string GetStringMessageFromResult(LoginResult typeResult)
        {
            return typeResult.PlayFabId;
        }
    }
}
