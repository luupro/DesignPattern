namespace DesignParttern.CreationalDP.FactoryMethod
{
    /// <summary>
    /// The product interface declares the operations that all
    /// concrete products must implement.
    /// </summary>
    public interface IButton
    {
        public void render();
        public void onClick();
    }
}
