using System;

namespace Toranzo.Playfab
{
    public interface IEventDataReceiver<TypeResult>
    {
        public Action<TypeResult> OnReceiveEvent { get; set; }

        public void InvokeEvent(TypeResult result);

        public void DisposeAll();
    }
}