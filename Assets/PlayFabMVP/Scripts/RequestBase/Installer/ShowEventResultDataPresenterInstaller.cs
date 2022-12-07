using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.Playfab
{
    public class ShowEventResultDataPresenterInstaller : MonoInstaller<ShowEventResultDataPresenter>
    {
        [Header("References")]
        [SerializeField] private MonoInstaller<IShowNewMessageReceiver> _showMessageView;
        [SerializeField] private MonoInstaller<IEventMessageReceiver> _eventMessageReceiver;

        protected override ShowEventResultDataPresenter GetDataType()
        {
            return new ShowEventResultDataPresenter(_eventMessageReceiver.Data, _showMessageView.Data);
        }
    }
}
