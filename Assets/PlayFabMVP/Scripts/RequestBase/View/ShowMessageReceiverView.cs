using UnityEngine;
using TMPro;

namespace Toranzo.Playfab
{
    public class ShowMessageReceiverView : MonoBehaviour, IShowNewMessageReceiver
    {
        [SerializeField] TMP_Text _textInfo;

        public void ShowMessageReceive(string messageToShow)
        {
            _textInfo.text += messageToShow;
        }
    }
}