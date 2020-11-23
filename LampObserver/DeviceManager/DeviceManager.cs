using System.Collections.Generic;
using LampObserver.DeviceManager.UpdateMessage;

namespace LampObserver.DeviceManager
{
    public class DeviceManager : IObservable
    {
        private readonly List<IObserver> _observers;
        public DeviceManager()
        {
            _observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
        }
 
        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }
 
        public void NotifyObservers(UpdateInfo info)
        {
            foreach (var observer in _observers)
                observer.Update(info);
        }
    }
}