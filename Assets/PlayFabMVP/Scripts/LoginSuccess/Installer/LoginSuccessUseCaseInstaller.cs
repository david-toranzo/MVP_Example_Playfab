using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class LoginSuccessUseCaseInstaller : MonoInstaller<IEventLoginSuccessReceiver>
    {
        [SerializeField] private LoginSuccessEventReceiverSO _SOLoginSuccess;

        protected override IEventLoginSuccessReceiver GetDataType()
        {
            return new LoginSuccessUseCase(_SOLoginSuccess);
        }
    }
}
