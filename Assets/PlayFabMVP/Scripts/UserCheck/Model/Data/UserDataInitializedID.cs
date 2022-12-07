using UnityEngine;

namespace Toranzo.Playfab
{
    [CreateAssetMenu(fileName = "IdIsInitialized", menuName = "ScriptableObjects/Playfab/IdIsInitialized", order = 0)]
    public class UserDataInitializedID : ScriptableObject, IUserDataInitializedGetter
    {
        [SerializeField] private string _idIsInitialized;

        public string IdIsInitialized
        {
            get => _idIsInitialized;
        }
    }
}