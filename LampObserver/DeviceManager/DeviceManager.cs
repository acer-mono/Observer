using System;
using System.Collections.Generic;
using LampObserver.DeviceManager.UpdateMessage;

namespace LampObserver.DeviceManager
{
    public class DeviceManager : IObservable
    {
        private readonly List<ILampObserver> _observers;
        public DeviceManager()
        {
            _observers = new List<ILampObserver>();
        }
        public void AddObserver(ILampObserver o)
        {
            _observers.Add(o);
        }
 
        public void RemoveObserver(ILampObserver o)
        {
            _observers.Remove(o);
        }
 
        public void NotifyObservers(DeviceMessage info)
        {
            switch(info)
            {
                case AlertStateMessage alertMessage:
                    foreach (var observer in _observers)
                        observer.SwitchAlertState(alertMessage);
                    break;
                case SwitchLightingMessage lightingMessage:
                    foreach (var observer in _observers)
                        observer.SwitchLighting(lightingMessage);
                    break;
                case ReactionModeMessage reactionMessage:
                    foreach (var observer in _observers)
                        observer.SwitchReactionMode(reactionMessage);
                    break;
                default:
                    throw new ArgumentException($"Unknown message type: {info.GetType().Name}");
            }
        }
    }
}