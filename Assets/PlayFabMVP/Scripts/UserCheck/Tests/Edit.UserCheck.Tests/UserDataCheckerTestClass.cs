using System;

namespace Toranzo.Playfab.Tests
{
    public class UserDataCheckerTestClass : IUserDataChecker
    {
        public Action<string> OnCheckUserError { get; set; }

        public void VerificateIsInitializedUserData()
        {
        }
    }
}