using PlayFab;
using PlayFab.ClientModels;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class InitialUserData
{
    public int InitialSoftCurrency;
    public bool TutorialEnabled;
}

[Serializable]
public class TutorialConfiguration
{
    public bool IsEnabled;
}

[Serializable]
public class UserInitialized
{
    public bool IsInitialized;
}

public class PlayFabLogin : MonoBehaviour
{
    public void Start()
    {
        if (string.IsNullOrEmpty(PlayFabSettings.staticSettings.TitleId))
        {
            /*
            Please change the titleId below to your own titleId from PlayFab Game Manager.
            If you have already set the value in the Editor Extensions, this can be skipped.
            */
            PlayFabSettings.staticSettings.TitleId = "42";
        }

#if UNITY_ANDROID
        LoginWithAndroidDeviceIDRequest androidRequest = new LoginWithAndroidDeviceIDRequest
        {
            AndroidDevice = SystemInfo.deviceUniqueIdentifier, CreateAccount = true
        }           
        PlayFabClientAPI.LoginWithAndroidDeviceID(androidRequest, OnLoginSuccess, OnLoginFailure);

#elif UNITY_IOS

        LoginWithIOSDeviceIDRequest iosRequest = new LoginWithIOSDeviceIDRequest
        {
            DeviceId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        }
        PlayFabClientAPI.LoginWithIOSDeviceID(iosRequest, OnLoginSuccess, OnLoginFailure);
#else        
        var request = new LoginWithCustomIDRequest { CustomId = "GettingStartedGuide2", CreateAccount = true };
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
#endif
    }

    private void OnLoginSuccess(LoginResult result)
    {
        PlayFabClientAPI.GetUserData(new GetUserDataRequest { Keys = new List<string>() { "IsInitialized" } },
            dataResult => 
            {
                if (!dataResult.Data.ContainsKey("IsInitialized"))
                {
                    InitializeUser();
                }

            }, error => { });

        Debug.Log("Congratulations, you made your first successful API call!");
    }

    private void InitializeUser()
    {
        GetTitleDataRequest request = new GetTitleDataRequest
        {
            Keys = new List<string>() { "InitialUserData" }
        };

        PlayFabClientAPI.GetTitleData(request, dataResult =>
        {
            var data = dataResult.Data["InitialUserData"];
            var initialUserData = JsonUtility.FromJson<InitialUserData>(data);
            Debug.Log(data);
            PlayFabClientAPI.AddUserVirtualCurrency(
                new AddUserVirtualCurrencyRequest
                {
                    Amount = initialUserData.InitialSoftCurrency,
                    VirtualCurrency = "SC"
                },
                result => { }, error => { });

            PlayFabClientAPI.UpdateUserData(new UpdateUserDataRequest
            {
                Data = new Dictionary<string, string>
                {
                    { "Tutorial", JsonUtility.ToJson(new TutorialConfiguration{ IsEnabled = initialUserData.TutorialEnabled} ) },
                    { "IsInitialized", JsonUtility.ToJson(new UserInitialized{ IsInitialized = true})}
                }

            }, result => { }, error => { });



        }, dataError => { });

    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.LogWarning("Something went wrong with your first API call.  :(");
        Debug.LogError("Here's some debug information:");
        Debug.LogError(error.GenerateErrorReport());
    }
}
