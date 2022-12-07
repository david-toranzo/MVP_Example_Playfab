using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class EventMessageBaseUseCaseInstaller : MonoInstaller<IEventMessageReceiver>
    {
        [SerializeField] private FailedEventReceiverSO _eventReceiver;

        protected override IEventMessageReceiver GetDataType()
        {
            return new EventMessageBaseUseCase(_eventReceiver);
        }
    }
}
