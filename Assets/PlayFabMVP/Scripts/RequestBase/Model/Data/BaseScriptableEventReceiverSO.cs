using System;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class BaseScriptableEventReceiverSO<TypeResult> : ScriptableObject, IEventDataReceiver<TypeResult>
    {
        public Action<TypeResult> OnReceiveEvent { get; set; }

        public void InvokeEvent(TypeResult result)
        {
            OnReceiveEvent?.Invoke(result);
        }

        public void DisposeAll()
        {
            OnReceiveEvent = null;
        }
    }
}