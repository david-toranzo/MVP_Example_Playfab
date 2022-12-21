using PlayFab;
using PlayFab.ClientModels;
using System.Collections.Generic;

namespace Toranzo.Playfab
{
    public class UserDataPlayfabGetter : IUserDataIsInitializedRequester
    {
        private IEventDataReceiver<GetUserDataResult> _successEventUserData;
        private IEventDataReceiver<string> _failedEventUserData;
        private IUserDataInitializedGetter _userDataInitialized;

        public UserDataPlayfabGetter(IEventDataReceiver<GetUserDataResult> successEventUserData, IEventDataReceiver<string> failedEventUserData, 
                                    IUserDataInitializedGetter userDataInitialized)
        {
            _successEventUserData = successEventUserData;
            _failedEventUserData = failedEventUserData;
            _userDataInitialized = userDataInitialized;
        }

        public void RequestUserDataIsInitialized()
        {
            PlayFabClientAPI.GetUserData(GetUserDataRequest(), RequestSuccess, RequestFailure);
        }

        private GetUserDataRequest GetUserDataRequest()
        {
            GetUserDataRequest getUserDataRequest = new GetUserDataRequest
            {
                Keys = new List<string>() { _userDataInitialized.IdIsInitialized }
            };
            return getUserDataRequest;
        }

        private void RequestSuccess(GetUserDataResult userData)
        {
            _successEventUserData.InvokeEvent(userData);
        }

        private void RequestFailure(PlayFabError error)
        {
            _failedEventUserData.InvokeEvent(error.GenerateErrorReport());
        }
    }
}