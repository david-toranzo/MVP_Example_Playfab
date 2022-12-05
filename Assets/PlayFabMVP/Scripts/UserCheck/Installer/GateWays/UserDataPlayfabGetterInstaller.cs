using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class UserDataPlayfabGetterInstaller : MonoInstaller<IUserDataIsInitializedRequester>
    {
        [Header("Data")]
        [SerializeField] private GetUserDataSuccessEventReceiverSO _successEventUserData;
        [SerializeField] private FailedEventReceiverSO _failedEventUserData;
        [SerializeField] private UserDataInitializedID _userDataInitialized;

        protected override IUserDataIsInitializedRequester GetDataType()
        {
            return new UserDataPlayfabGetter(_successEventUserData, _failedEventUserData, _userDataInitialized);
        }
    }
}