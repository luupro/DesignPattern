using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Bridge
{
    /// <summary>
    /// The "implementation" interface declares methods common to all
    /// concrete implementation classes. It doesn't have to match the
    /// abstraction's interface. In fact, the two interfaces can be
    /// entirely different. Typically the implementation interface 
    /// provides only primitive operations, while the abstraction
    /// defines higher-level operations based on those primitives.
    /// </summary>
    public interface Device
    {
        public bool IsEnabled();
        public void Enable();
        public void Disable();
        public int GetVolume();
        public void SetVolume(int volume);
        public int GetChannel();
        public void SetChannel(int channel);
    }
}
