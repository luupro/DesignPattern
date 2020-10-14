﻿using System;

namespace DesignParttern.CreationalDP.AbstractFactory
{
    /// <summary>
    /// Concrete factories produce a family of products that belong
    /// to a single variant. The factory guarantees that the 
    /// resulting products are compatible. Signatures of the concrete 
    /// factory's methods return an abstract product, while inside
    /// the method a concrete product is instantiated.
    /// </summary>
    public class WinFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
