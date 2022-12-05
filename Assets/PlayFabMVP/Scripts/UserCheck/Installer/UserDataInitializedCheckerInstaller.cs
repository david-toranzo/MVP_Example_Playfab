using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class UserDataInitializedCheckerInstaller : MonoInstaller<IUserDataChecker>
    {
        [Header("References")]
        [SerializeField] private MonoInstaller<IUserDataIsInitializedRequester> _checkUserDataInitialized;

        [Header("Data")]
        [SerializeField] private FailedEventReceiverSO _loginFailedEventReceiverSO;

        protected override IUserDataChecker GetDataType()
        {
            return new UserDataInitializedChecker(_checkUserDataInitialized.Data, _loginFailedEventReceiverSO);
        }
    }
}