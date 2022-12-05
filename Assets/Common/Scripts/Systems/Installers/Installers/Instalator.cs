using UnityEngine;

namespace Toranzo.Installer
{
    public class Instalator : MonoInstaller
    {
        [SerializeField] private MonoInstaller[] _monoInstallers;

        public override void Install()
        {
            for (int i = 0; i < _monoInstallers.Length; i++)
            {
                _monoInstallers[i].Install();
            }
        }
    }
}
