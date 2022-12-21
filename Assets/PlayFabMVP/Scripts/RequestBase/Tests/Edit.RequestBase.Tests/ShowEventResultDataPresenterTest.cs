using NSubstitute;
using NUnit.Framework;

namespace Toranzo.Playfab.Tests
{
    public class ShowEventResultDataPresenterTest
    {
        [Test]
        public void Event_InvokeEvent_CallMethodShowMessageReceive()
        {
            IShowNewMessageReceiver showNewMessageReceiver = Substitute.For<IShowNewMessageReceiver>();
            IEventMessageReceiver eventMessageReceiver = new LoginSuccessEventMessageReceiverTestClass();
            var loginSuccessPresenter = new ShowEventResultDataPresenter(eventMessageReceiver, showNewMessageReceiver);

            eventMessageReceiver.OnReceiveMessage.Invoke("");

            showNewMessageReceiver.Received(1).ShowMessageReceive(Arg.Any<string>());
        }
    }
}