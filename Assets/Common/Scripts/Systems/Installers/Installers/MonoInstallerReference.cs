using UnityEngine;

namespace Toranzo.Installer
{
    public class MonoInstallerReference : MonoInstaller
    {
        [SerializeField] private MonoInstaller _monoInstaller;

        public override void Install()
        {
            _monoInstaller.Install();
        }
    }
}
