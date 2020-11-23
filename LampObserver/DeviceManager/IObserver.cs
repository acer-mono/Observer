namespace LampObserver.DeviceManager
{
    public interface IObserver
    {
        void Update(EventType message);
    }
}