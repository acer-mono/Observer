using System;

namespace LampObserver.DeviceManager.UpdateMessage
{
    public class SwitchLightingMessage : UpdateInfo
    {
        public SwitchLightingMessage(Guid roomId) : base(roomId)
        {
        }
    }
}