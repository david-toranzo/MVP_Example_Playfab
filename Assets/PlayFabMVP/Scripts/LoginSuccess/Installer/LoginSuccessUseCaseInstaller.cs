using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class LoginSuccessUseCaseInstaller : MonoInstaller<IEventMessageReceiver>
    {
        [SerializeField] private LoginSuccessEventReceiverSO _SOLoginSuccess;

        protected override IEventMessageReceiver GetDataType()
        {
            return new LoginSuccessUseCase(_SOLoginSuccess);
        }
    }
}
