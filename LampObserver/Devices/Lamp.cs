using System;
using LampObserver.DeviceManager;
using LampObserver.DeviceManager.UpdateMessage;

namespace LampObserver.Devices
{
    public class Lamp : IDevice
    {
        public bool IsStateCalm { get; private set; } = true; //покой true или тревога false - состояние лампочки
        public bool IsTurnedOn { get; private set; } = false; // включен свет - true или выключен свет - false 
        public bool IsAuto { get; private set; } = true; // режим автоматический - true или ручной - false

        public Guid RoomId { get; }

        public Lamp(Guid roodId)
        {
            RoomId = roodId;
        }
        
        private void SwitchState()
        {
            IsStateCalm = !IsStateCalm;
        }

        private void SwitchMode()
        {
            if (IsStateCalm)
            {
                IsAuto = !IsAuto;
            }
        }

        private void SwitchLight()
        {
            if (IsStateCalm)
            {
                IsTurnedOn = !IsTurnedOn;
            }
        }

        public void SwitchLighting(SwitchLightingMessage lightingMessage)
        {
            if (!lightingMessage.RoomId.Equals(RoomId))
            {
                return;
            }
            SwitchLight();
        }

        public void SwitchReactionMode(ReactionModeMessage message)
        {
            if (!message.RoomId.Equals(RoomId))
            {
                return;
            }
            SwitchMode();
        }

        public void SwitchAlertState(AlertStateMessage stateMessage)
        {
            if (!stateMessage.RoomId.Equals(RoomId))
            {
                return;
            }
            SwitchState();
        }
    }
}