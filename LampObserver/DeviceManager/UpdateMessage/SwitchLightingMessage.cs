using System;

namespace LampObserver.DeviceManager.UpdateMessage
{
    public class SwitchLightingMessage : DeviceMessage
    {
        public SwitchLightingMessage(Guid roomId) : base(roomId)
        {
        }
    }
}