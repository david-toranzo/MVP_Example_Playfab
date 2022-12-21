namespace Toranzo.Playfab
{
    public class UserPresenterChecker
    {
        private IUserViewChecker _checkUserView;

        public UserPresenterChecker(IUserDataChecker userDataChecker, IUserViewChecker checkUserView)
        {
            _checkUserView = checkUserView;

            userDataChecker.OnCheckUserError += CheckErrorGetUserData;
        }

        private void CheckErrorGetUserData(string errorMessage)
        {
            _checkUserView.SetNewErrorMessageCheckUser(errorMessage);
        }
    }
}
