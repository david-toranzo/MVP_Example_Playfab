using Patterns.Factory;
using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab.Installer
{
    public class LoginFactoryTypeDeviceInstaller : MonoInstaller<Factory<string, IBaseLogin>>
    {
        [SerializeField] private MonoInstaller<IBaseLogin>[] _baseLoginsInstaller;

        protected override Factory<string, IBaseLogin> GetDataType()
        {
            IBaseLogin[] baseLogins = new IBaseLogin[_baseLoginsInstaller.Length];

            for (int i = 0; i < _baseLoginsInstaller.Length; i++)
            {
                baseLogins[i] = _baseLoginsInstaller[i].Data;
            }

            return new LoginFactoryTypeDevice(baseLogins);
        }
    }
}
