namespace LampObserver.DeviceManager.UpdateMessage
{
    public class UpdateInfo
    {
        private readonly EventType _type;
        
        public UpdateInfo(EventType type)
        {
            _type = type;
        }
        
        public EventType EventType => _type;
    }
}