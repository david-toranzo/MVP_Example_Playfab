using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class LoginSuccessInfoViewInstaller : MonoInstaller<ILoginSuccessView>
    {
        [SerializeField] private LoginSuccessInfoView _loginSuccessInfoView;

        protected override ILoginSuccessView GetDataType()
        {
            return _loginSuccessInfoView;
        }
    }
}
