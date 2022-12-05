using System;

namespace Toranzo.Playfab
{
    public interface IEventLoginSuccessReceiver
    {
        Action<string> OnReceiveLoginMessage { get; set; }
    }
}