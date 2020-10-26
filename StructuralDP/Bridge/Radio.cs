using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Bridge
{
    class Radio : IDevice
    {
        public void Disable()
        {
            throw new NotImplementedException();
        }

        public void Enable()
        {
            throw new NotImplementedException();
        }

        public int GetChannel()
        {
            throw new NotImplementedException();
        }

        public int GetVolume()
        {
            return 1; //pass it
        }

        public bool IsEnabled()
        {
            return true; // pass it
        }

        public void SetChannel(int channel)
        {
            throw new NotImplementedException();
        }

        public void SetVolume(int volume)
        {
            throw new NotImplementedException();
        }
    }
}
