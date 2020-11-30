using System;

namespace LampObserver.DeviceManager.UpdateMessage
{
    public class AlertStateMessage : DeviceMessage
    {
        public AlertStateMessage(Guid roomId) : base(roomId)
        {
        }
    }
}