using PlayFab;

namespace Toranzo.Playfab
{
    public class PlayfabLoginInitializer
    {
        public PlayfabLoginInitializer(ITypeDeviceLoginSelector typeDeviceLogin)
        {
            InitializePlayfabValues();
            CallStartLogin(typeDeviceLogin);
        }

        private void InitializePlayfabValues()
        {
            if (string.IsNullOrEmpty(PlayFabSettings.staticSettings.TitleId))
                PlayFabSettings.staticSettings.TitleId = "42";
        }

        private void CallStartLogin(ITypeDeviceLoginSelector typeDeviceLogin)
        {
            IBaseLogin baseLogin = typeDeviceLogin.GetTypeLogin();
            baseLogin.StartMakeLogin();
        }
    }
}
