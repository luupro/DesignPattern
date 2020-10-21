using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Bridge
{
    /// <summary>
    /// You can extend classes from the abstraction hierachy
    /// independently from device class
    /// </summary>
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void Mute()
        {
            device.SetVolume(0);
        }
    }
}
