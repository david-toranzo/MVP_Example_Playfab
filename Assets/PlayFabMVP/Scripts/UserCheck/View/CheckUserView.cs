using UnityEngine;

namespace Toranzo.Playfab
{
    public class CheckUserView : MonoBehaviour, IUserViewChecker
    {
        [SerializeField] private TMPro.TMP_Text _textShowError;

        public void SetNewErrorMessageCheckUser(string userDataError)
        {
            _textShowError.text += "\n" + userDataError;
        }
    }
}