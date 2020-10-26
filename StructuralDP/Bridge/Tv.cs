using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Bridge
{
    /// <summary>
    /// All devices follow the same interface
    /// </summary>
    class Tv : IDevice
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
            throw new NotImplementedException();
        }

        public bool IsEnabled()
        {
            throw new NotImplementedException();
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
