using System;

namespace DesignParttern.CreationalDP.FactoryMethod
{
    /// <summary>
    /// Concrete products prvide various implementations of the product interface
    /// </summary>
    class WindowsButton : IButton
    {
        public void onClick()
        {
            //Bind a native OS click event
            throw new NotImplementedException();
        }

        public void render()
        {
            //Render a button in Windows stype
            throw new NotImplementedException();
        }
    }
}
