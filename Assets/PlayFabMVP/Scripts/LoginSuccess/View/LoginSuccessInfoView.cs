using UnityEngine;
using TMPro;

namespace Toranzo.Playfab
{
    public class LoginSuccessInfoView : MonoBehaviour, ILoginSuccessView
    {
        [SerializeField] TMP_Text _textInfo;

        public void ShowReceiveLoginSuccess(string messageToShow)
        {
            _textInfo.text += messageToShow;
        }
    }
}