using System;

namespace Toranzo.Playfab.Tests
{
    public class EventDataReceiverTestClass : IEventDataReceiver<string>
    {
        public Action<string> OnReceiveEvent { get; set; }

        public void DisposeAll() => throw new NotImplementedException();
        public void InvokeEvent(string result) => throw new NotImplementedException();
    }
}
