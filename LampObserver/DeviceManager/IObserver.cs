using LampObserver.DeviceManager.UpdateMessage;

namespace LampObserver.DeviceManager
{
    public interface IObserver
    {

        void SwitchLighting(SwitchLightingMessage lightingMessage);
        void SwitchReactionMode(ReactionModeMessage message);
        void SwitchAlertState(AlertStateMessage stateMessage);
    }
}