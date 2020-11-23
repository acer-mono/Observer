using LampObserver.DeviceManager.UpdateMessage;

namespace LampObserver.DeviceManager
{
    public interface IObserver
    {
        void Update(UpdateInfo message);
    }
}