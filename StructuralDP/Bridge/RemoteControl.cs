﻿namespace DesignParttern.StructuralDP.Bridge
{
    /// <summary>
    /// The "abstraction" defines the interface for the "control"
    /// part of the two class hierachies. It maintains a reference
    /// to an object of the "implementation" hierachy and delegates 
    /// all of the real work to this project.
    /// </summary>
    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl() { }

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if (device.IsEnabled())
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }

        public void VolumeDown()
        {
            device.SetVolume(device.GetVolume() - 10);
        }

        public void VolumeUp()
        {
            device.SetVolume(device.GetVolume() + 10);
        }

        public void ChannelDown()
        {
            device.SetChannel(device.GetChannel() - 1);
        }

        public void ChannelUp()
        {
            device.SetChannel(device.GetChannel() + 1);
        }
    }
}
