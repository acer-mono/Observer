using System.Collections.Generic;

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
 
        public void NotifyObservers(EventType type)
        {
            foreach (var observer in _observers)
                observer.Update(type);
        }
    }
}