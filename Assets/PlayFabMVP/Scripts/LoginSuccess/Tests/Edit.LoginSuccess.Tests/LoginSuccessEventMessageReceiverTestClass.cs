using System;

namespace Toranzo.Playfab.Tests
{
    public class LoginSuccessEventMessageReceiverTestClass : IEventMessageReceiver
    {
        public Action<string> OnReceiveMessage { get; set; }
    }
}