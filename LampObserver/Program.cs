using System;
using LampObserver.DeviceManager.UpdateMessage;
using LampObserver.Devices;

namespace LampObserver
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var room1 = Guid.NewGuid();
            var room2 = Guid.NewGuid();
            var lamp1 = new Lamp(room1);
            var lamp2 = new Lamp(room2);
            var lamp3 = new Lamp(room2);
            
            var deviceManager = new DeviceManager.DeviceManager();
            deviceManager.AddObserver(lamp1);
            deviceManager.AddObserver(lamp2);
            deviceManager.AddObserver(lamp3);
            
            deviceManager.NotifyObservers(new AlertStateMessage(room1));
            
            Console.WriteLine($"Send alert message to the first room: {room1}");
            Console.WriteLine($"Room: {lamp1.RoomId}\n" +
                              $"Is Lamp1`s mode is auto: {lamp1.IsAuto}\n" +
                              $"Is lamp1 is calm: {lamp1.IsStateCalm}\n" +
                              $"Is lamp1 turned on: {lamp1.IsTurnedOn}\n");
            Console.WriteLine($"Room: {lamp2.RoomId}\n" +
                              $"Is Lamp2`s mode is auto: {lamp2.IsAuto}\n" +
                              $"Is lamp2 is calm: {lamp2.IsStateCalm}\n" +
                              $"Is lamp2 turned on: {lamp2.IsTurnedOn}\n");
            Console.WriteLine($"Room: {lamp3.RoomId}\n" +
                              $"Is Lamp3`s mode is auto: {lamp3.IsAuto}\n" +
                              $"Is lamp3 is calm: {lamp3.IsStateCalm}\n" +
                              $"Is lamp3 turned on: {lamp3.IsTurnedOn}\n");
        }
    }
}