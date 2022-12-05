using UnityEngine;

namespace Toranzo.Installer
{
    public class AwakeInstallerInitial : MonoBehaviour
    {
        [SerializeField] private MonoInstaller _monoInstaller;

        private void Awake()
        {
            _monoInstaller.Install();
        }
    }
}
