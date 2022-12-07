using System;

namespace Toranzo.Playfab
{
    public interface IEventMessageReceiver
    {
        Action<string> OnReceiveMessage { get; set; }
    }
}