using System;

namespace LampObserver.DeviceManager.UpdateMessage
{
    public class AlertStateMessage : UpdateInfo
    {
        public AlertStateMessage(Guid roomId) : base(roomId)
        {
        }
    }
}