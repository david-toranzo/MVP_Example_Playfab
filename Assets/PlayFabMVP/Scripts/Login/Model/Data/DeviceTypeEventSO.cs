using UnityEngine;

namespace Toranzo.Playfab
{
    [CreateAssetMenu(fileName = "TypeLogin", menuName = "ScriptableObjects/Playfab/TypeLogin", order = 0)]
    public class DeviceTypeEventSO : ScriptableObject, ITypeLoginGetter
    {
        [SerializeField] private string _typeLogin;

        public string TypeLogin 
        { 
            get => _typeLogin;
        }
    }
}