using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class CheckUserViewInstaller : MonoInstaller<IUserViewChecker>
    {
        [SerializeField] private CheckUserView _checkUserView;

        protected override IUserViewChecker GetDataType()
        {
            return _checkUserView;
        }
    }
}