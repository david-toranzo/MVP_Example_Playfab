namespace Toranzo.Playfab
{
    public class LoginSuccessPresenter
    {
        private IUserDataChecker _userDataChecker;
        private ILoginSuccessView _loginSuccessView;

        public LoginSuccessPresenter(IEventLoginSuccessReceiver loginSuccessReceiver, IUserDataChecker userDataChecker, 
                                    ILoginSuccessView loginSuccessView)
        {
            _userDataChecker = userDataChecker;
            _loginSuccessView = loginSuccessView;

            loginSuccessReceiver.OnReceiveLoginMessage += LoginSuccessReceive;
        }

        private void LoginSuccessReceive(string messageReceive)
        {
            _userDataChecker.VerificateIsInitializedUserData();

            _loginSuccessView.ShowReceiveLoginSuccess("\nNew login success, id: " + messageReceive);
        }
    }
}
