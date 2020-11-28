using System;

namespace LampObserver.DeviceManager.UpdateMessage
{
    public abstract class UpdateInfo
    {
        protected UpdateInfo(Guid roomId)
        {
            RoomId = roomId;
        }
        
        public Guid RoomId { get; }
    }
}