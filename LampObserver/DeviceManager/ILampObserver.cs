using LampObserver.DeviceManager.UpdateMessage;
using LampObserver.Devices;

namespace LampObserver.DeviceManager
{
    public interface ILampObserver : IDevice
    {

        void SwitchLighting(SwitchLightingMessage lightingMessage);
        void SwitchReactionMode(ReactionModeMessage message);
        void SwitchAlertState(AlertStateMessage stateMessage);
    }
}