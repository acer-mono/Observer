namespace LampObserver.DeviceManager
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(EventType type);
    }
}