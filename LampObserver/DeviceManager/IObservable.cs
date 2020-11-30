using LampObserver.DeviceManager.UpdateMessage;

namespace LampObserver.DeviceManager
{
    public interface IObservable
    {
        void AddObserver(ILampObserver lampObserver);
        void RemoveObserver(ILampObserver lampObserver);
        void NotifyObservers(DeviceMessage type);
    }
}