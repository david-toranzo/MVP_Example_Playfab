using PlayFab.ClientModels;
using System.Collections.Generic;

namespace Toranzo.Playfab
{
    public class IsUserInitializePlayfabChecker
    {
        private IEventDataReceiver<bool> _initializedUser;
        private IUserDataInitializedGetter _userDataInitializedGetter;

        public IsUserInitializePlayfabChecker(IEventDataReceiver<GetUserDataResult> successEventUserData,
                                              IEventDataReceiver<bool> initializedUser, 
                                              IUserDataInitializedGetter userDataInitializedGetter)
        {
            _initializedUser = initializedUser;
            _userDataInitializedGetter = userDataInitializedGetter;

            successEventUserData.OnReceiveEvent += RequestSuccess;
        }

        private void RequestSuccess(GetUserDataResult userData)
        {
            CheckExistDataUser(userData);
        }

        private void CheckExistDataUser(GetUserDataResult dataResult)
        {
            Dictionary<string, UserDataRecord> userValues = dataResult.Data;
            bool resExist = userValues.ContainsKey(_userDataInitializedGetter.IdIsInitialized);

            _initializedUser?.InvokeEvent(resExist);
        }
    }
}