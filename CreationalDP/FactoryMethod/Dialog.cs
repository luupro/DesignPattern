using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.CreationalDP.FactoryMethod
{
    /// <summary>
    /// The creator class declares the factory method that must
    /// return an object of a product class. The creator's subclasses
    /// usually provide the implementation of this method.
    /// </summary>
    public abstract class Dialog
    {
        /// <summary>
        /// factory method and returning a different type of product
        /// of the factory method.
        /// </summary>
        /// <returns></returns>
        public abstract IButton CreateButton();

        /// <summary>
        /// contains some core business logic that relies on product
        /// objects returned by the factory method. Subclasses can
        /// indirectly change that business logic by overriding the
        /// factory method and returning a different type of product
        /// from it
        /// </summary>
        public void Render()
        {
            //Call the factory method to create a product object
            IButton okButton = CreateButton();
            // Now use the product.
            okButton.onClick();
            okButton.render();
        }

        public void onClick()
        {
            throw new NotImplementedException();
        }
    }
}
