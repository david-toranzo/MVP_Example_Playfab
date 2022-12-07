namespace Toranzo.Playfab
{
    public class LoginSuccessPresenter
    {
        private IUserDataChecker _userDataChecker;

        public LoginSuccessPresenter(IEventMessageReceiver loginSuccessReceiver, IUserDataChecker userDataChecker)
        {
            _userDataChecker = userDataChecker;

            loginSuccessReceiver.OnReceiveMessage += LoginSuccessReceive;
        }

        private void LoginSuccessReceive(string messageReceive)
        {
            _userDataChecker.VerificateIsInitializedUserData();
        }
    }
}
