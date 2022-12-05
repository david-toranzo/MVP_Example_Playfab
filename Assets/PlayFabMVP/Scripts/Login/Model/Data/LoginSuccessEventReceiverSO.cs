using PlayFab.ClientModels;
using UnityEngine;

namespace Toranzo.Playfab
{
    [CreateAssetMenu(fileName = "LoginSuccessEventSO", menuName = "ScriptableObjects/Playfab/LoginSuccessEvent", order = 0)]
    public class LoginSuccessEventReceiverSO : BaseScriptableEventReceiverSO<LoginResult>
    {

    }
}