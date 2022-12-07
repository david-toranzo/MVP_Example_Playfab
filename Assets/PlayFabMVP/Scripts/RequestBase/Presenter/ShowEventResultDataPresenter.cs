namespace Toranzo.Playfab
{
    public class ShowEventResultDataPresenter
    {
        private IShowNewMessageReceiver _loginSuccessView;

        public ShowEventResultDataPresenter(IEventMessageReceiver eventResultData, IShowNewMessageReceiver loginSuccessView)
        {
            _loginSuccessView = loginSuccessView;

            eventResultData.OnReceiveMessage += EventDataResultReceive;
        }

        private void EventDataResultReceive(string messageReceive)
        {
            _loginSuccessView.ShowMessageReceive(GetMessageToShow(messageReceive));
        }

        protected virtual string GetMessageToShow(string messageReceive)
        {
            return "\nNew data result : " + messageReceive;
        }
    }
}
