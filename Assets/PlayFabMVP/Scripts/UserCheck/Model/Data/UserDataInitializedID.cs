using UnityEngine;

namespace Toranzo.Playfab
{
    [CreateAssetMenu(fileName = "TypePlayfab", menuName = "ScriptableObjects/Playfab/TypePlayfab", order = 0)]
    public class UserDataInitializedID : ScriptableObject, IUserDataInitializedGetter
    {
        [SerializeField] private string _idIsInitialized;

        public string IdIsInitialized
        {
            get => _idIsInitialized;
        }
    }
}