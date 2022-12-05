namespace Toranzo.Playfab
{
    public class UserPresenterChecker
    {
        private IUserDataChecker _userDataChecker;
        private IUserViewChecker _checkUserView;

        public UserPresenterChecker(IUserDataChecker userDataChecker, IUserViewChecker checkUserView)
        {
            _userDataChecker = userDataChecker;
            _checkUserView = checkUserView;

            _userDataChecker.OnCheckUserError += CheckErrorGetUserData;
        }

        private void CheckErrorGetUserData(string errorMessage)
        {
            _checkUserView.SetNewErrorMessageCheckUser(errorMessage);
        }
    }
}
