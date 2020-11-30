using System;

namespace LampObserver.DeviceManager.UpdateMessage
{
    public class ReactionModeMessage : DeviceMessage
    {
        public ReactionModeMessage(Guid roomId) : base(roomId)
        {
        }
    }
}