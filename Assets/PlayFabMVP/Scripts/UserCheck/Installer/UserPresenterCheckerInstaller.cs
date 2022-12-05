using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class UserPresenterCheckerInstaller : MonoInstaller<UserPresenterChecker>
    {
        [Header("References")]
        [SerializeField] private MonoInstaller<IUserDataChecker> _userDataChecker;
        [SerializeField] private MonoInstaller<IUserViewChecker> _checkUserView;

        protected override UserPresenterChecker GetDataType()
        {
            return new UserPresenterChecker(_userDataChecker.Data, _checkUserView.Data);
        }
    }
}