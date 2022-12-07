using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class ShowMessageReceiverViewInstaller : MonoInstaller<IShowNewMessageReceiver>
    {
        [SerializeField] private ShowMessageReceiverView _loginSuccessInfoView;

        protected override IShowNewMessageReceiver GetDataType()
        {
            return _loginSuccessInfoView;
        }
    }
}
