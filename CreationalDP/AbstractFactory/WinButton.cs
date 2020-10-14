using System;

namespace DesignParttern.CreationalDP.AbstractFactory
{
    /// <summary>
    /// Concrete products are created by corresponding concrete factories
    /// </summary>
    class WinButton : IButton
    {
        // Render a button in Windows style.
        public void Paint()
        {
            throw new NotImplementedException();
        }
    }
}
