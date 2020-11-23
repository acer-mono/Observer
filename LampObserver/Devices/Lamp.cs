using LampObserver.DeviceManager;
using LampObserver.DeviceManager.UpdateMessage;

namespace LampObserver.Devices
{
    public class Lamp : IDevice
    {
        public bool IsStateCalm { get; private set; } = true; //покой true или тревога false - состояние лампочки
        public bool IsTurnedOn { get; private set; } = false; // включен свет - true или выключен свет - false 
        public bool IsAuto { get; private set; } = true; // режим автоматический - true или ручной - false

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

        public void Update(UpdateInfo message)
        {
            switch (message.EventType)
            {
                case EventType.ChangeLight:
                    SwitchLight();
                    break;
                case EventType.ChangeMode:
                    SwitchMode();
                    break;
                case EventType.ChangeState:
                    SwitchState();
                    break;
            }
        }
    }
}