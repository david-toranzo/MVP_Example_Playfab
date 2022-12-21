using NSubstitute;
using NUnit.Framework;

namespace Toranzo.Playfab.Tests
{
    public class LoginSuccessPresenterTest
    {
        [Test]
        public void Event_InvokeEvent_CallMethodVerificateIsInitializedUserData()
        {
            IUserDataChecker userDataChecker = Substitute.For<IUserDataChecker>();
            IEventMessageReceiver eventMessageReceiver = new LoginSuccessEventMessageReceiverTestClass();
            var loginSuccessPresenter = new LoginSuccessPresenter(eventMessageReceiver, userDataChecker);

            eventMessageReceiver.OnReceiveMessage.Invoke("");

            userDataChecker.Received(1).VerificateIsInitializedUserData();
        }
    }
}