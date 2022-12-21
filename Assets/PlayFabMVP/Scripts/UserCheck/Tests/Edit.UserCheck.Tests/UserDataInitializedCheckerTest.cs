using NSubstitute;
using NUnit.Framework;

namespace Toranzo.Playfab.Tests
{
    public class UserDataInitializedCheckerTest
    {
        [Test]
        public void VerificateIsInitializedUserData_CallMethod_SubstituteCallOneTime()
        {
            IUserDataIsInitializedRequester userDataIsInitializedRequester = Substitute.For<IUserDataIsInitializedRequester>();
            EventDataReceiverTestClass failedEventUserData = new EventDataReceiverTestClass();
            var userDataInitializedChecker = new UserDataInitializedChecker(userDataIsInitializedRequester, failedEventUserData);

            userDataInitializedChecker.VerificateIsInitializedUserData();

            userDataIsInitializedRequester.Received(1).RequestUserDataIsInitialized();
        }
    }
}
