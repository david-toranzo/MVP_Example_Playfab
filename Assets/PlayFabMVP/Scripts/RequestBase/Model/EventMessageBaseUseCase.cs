namespace Toranzo.Playfab
{
    public class EventMessageBaseUseCase : EventUseCaseReceiver<string>
    {
        public EventMessageBaseUseCase(IEventDataReceiver<string> eventDataReceiver) : base(eventDataReceiver)
        {

        }

        protected override string GetStringMessageFromResult(string typeResult)
        {
            return typeResult;
        }
    }
}
