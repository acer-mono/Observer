using System;
using LampObserver.DeviceManager;
using LampObserver.DeviceManager.UpdateMessage;
using LampObserver.Devices;

namespace LampObserver
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var lamp1 = new Lamp();
            var lamp2 = new Lamp();
            var lamp3 = new Lamp();
            
            var deviceManager = new DeviceManager.DeviceManager();
            deviceManager.AddObserver(lamp1);
            deviceManager.AddObserver(lamp2);
            deviceManager.AddObserver(lamp3);
            
            deviceManager.NotifyObservers(new UpdateInfo(EventType.ChangeLight));
            
            Console.WriteLine($"Is Lamp1`s mode is auto: {lamp1.IsAuto}\n" +
                              $"Is lamp1 is calm: {lamp1.IsStateCalm}\n" +
                              $"Is lamp1 turned on: {lamp1.IsTurnedOn}\n");
            
            deviceManager.NotifyObservers(new UpdateInfo(EventType.ChangeMode));
            
            Console.WriteLine($"Is Lamp1`s mode is auto: {lamp1.IsAuto}\n" +
                              $"Is lamp1 is calm: {lamp1.IsStateCalm}\n" +
                              $"Is lamp1 turned on: {lamp1.IsTurnedOn}\n");
        }
    }
}