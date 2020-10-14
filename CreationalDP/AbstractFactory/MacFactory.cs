using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.CreationalDP.AbstractFactory
{
    /// <summary>
    /// Each concrete factory has a corresponding product variant.
    /// </summary>
    public class MacFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
