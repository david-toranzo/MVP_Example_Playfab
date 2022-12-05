using System;

namespace Toranzo.Playfab
{
    public class UserDataInitializedChecker : IUserDataChecker
    {
        public Action<string> OnCheckUserError { get; set; }

        private IUserDataIsInitializedRequester _checkUserDataInitialized;

        public UserDataInitializedChecker(IUserDataIsInitializedRequester checkUserDataInitialized, 
                                          IEventDataReceiver<string> failedEventUserData)
        {
            _checkUserDataInitialized = checkUserDataInitialized;

            failedEventUserData.OnReceiveEvent += ErrorCheckExistDataUser;
        }

        public void VerificateIsInitializedUserData()
        {
            _checkUserDataInitialized.RequestUserDataIsInitialized();
        }

        private void ErrorCheckExistDataUser(string errorMessage)
        {
            OnCheckUserError?.Invoke(errorMessage);
        }
    }
}