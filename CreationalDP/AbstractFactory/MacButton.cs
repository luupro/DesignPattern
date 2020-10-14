using System;

namespace DesignParttern.CreationalDP.AbstractFactory
{
    /// <summary>
    /// Concrete products are created by corresponding concrete factories
    /// </summary>
    class MacButton : IButton
    {
        // Render a button in macOS style.
        public void Paint()
        {
            throw new NotImplementedException();
        }
    }
}
