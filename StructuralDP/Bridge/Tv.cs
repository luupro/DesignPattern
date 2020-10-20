using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Bridge
{
    /// <summary>
    /// All devices follow the same interface
    /// </summary>
    class Tv : Device
    {
        public void Disable()
        {
            throw new NotImplementedException();
        }

        public void Enable()
        {
            throw new NotImplementedException();
        }

        public void GetChannel()
        {
            throw new NotImplementedException();
        }

        public void GetVolume()
        {
            throw new NotImplementedException();
        }

        public void IsEnabled()
        {
            throw new NotImplementedException();
        }

        public void SetChannel()
        {
            throw new NotImplementedException();
        }

        public void SetVolume()
        {
            throw new NotImplementedException();
        }
    }
}
