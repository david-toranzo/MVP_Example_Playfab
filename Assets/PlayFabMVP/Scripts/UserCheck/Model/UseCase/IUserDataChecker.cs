using System;

namespace Toranzo.Playfab
{
    public interface IUserDataChecker 
    {
        Action<string> OnCheckUserError { get; set; }

        void VerificateIsInitializedUserData();
    }
}