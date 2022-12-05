using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class IsUserInitializePlayfabCheckerInstaller : MonoInstaller<IsUserInitializePlayfabChecker>
    {
        [Header("Data")]
        [SerializeField] private GetUserDataSuccessEventReceiverSO _getUserDataSuccessEventReceiverSO;
        [SerializeField] private IsInitializedUserEventReceiverSO _initializedUser;
        [SerializeField] private UserDataInitializedID _userDataInitialized;

        protected override IsUserInitializePlayfabChecker GetDataType()
        {
            return new IsUserInitializePlayfabChecker(_getUserDataSuccessEventReceiverSO, _initializedUser, _userDataInitialized);
        }
    }
}