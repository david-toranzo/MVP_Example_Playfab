using System;

namespace Toranzo.Playfab
{
    public abstract class EventUseCaseReceiver<TypeResult> : IEventMessageReceiver
    {
        public Action<string> OnReceiveMessage { get; set; }

        public EventUseCaseReceiver(IEventDataReceiver<TypeResult> eventDataReceiver)
        {
            eventDataReceiver.OnReceiveEvent += ReceiveNewEventDataWithResult;
        }

        private void ReceiveNewEventDataWithResult(TypeResult loginResult)
        {
            OnReceiveMessage?.Invoke(GetStringMessageFromResult(loginResult));
        }

        protected abstract string GetStringMessageFromResult(TypeResult typeResult);
    }
}
