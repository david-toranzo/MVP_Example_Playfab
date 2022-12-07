using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class LoginSuccessPresenterInstaller : MonoInstaller<LoginSuccessPresenter>
    {
        [Header("References")]
        [SerializeField] private MonoInstaller<IUserDataChecker> _userDataCheckerInstaller;
        [SerializeField] private MonoInstaller<ILoginSuccessView> _loginSuccessView;
        [SerializeField] private MonoInstaller<IEventLoginSuccessReceiver> _eventLoginSuccessReceiver;

        protected override LoginSuccessPresenter GetDataType()
        {
            return new LoginSuccessPresenter(_eventLoginSuccessReceiver.Data, _userDataCheckerInstaller.Data, _loginSuccessView.Data);
        }
    }
}
