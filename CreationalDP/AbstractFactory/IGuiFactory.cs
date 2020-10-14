namespace DesignParttern.CreationalDP.AbstractFactory
{
    /// <summary>
    /// The abstract factory interface declares a set of method that
    /// return different abstract products. These products are called
    /// a family and are related by a high-level theme or concept.
    /// Products of one family are usally able to collaborate among themselves.
    /// A family of products may have several variants,
    /// but the products of one variant are incompatible with the products
    /// of another variant.
    /// </summary>
    public interface IGuiFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
