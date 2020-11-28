using System;

namespace LampObserver.DeviceManager.UpdateMessage
{
    public class ReactionModeMessage : UpdateInfo
    {
        public ReactionModeMessage(Guid roomId) : base(roomId)
        {
        }
    }
}