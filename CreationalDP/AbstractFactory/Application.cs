namespace DesignParttern.CreationalDP.AbstractFactory
{
    /// <summary>
    /// The client code works with factories and products only
    /// through abstract types: GUIFactory, Button, and Checkbox.
    /// This let you pass any factory or product subclass to the client
    /// code without breaking it.
    /// </summary>
    public class Application
    {
        private IButton button;
        private readonly IGuiFactory factory;

        public Application(IGuiFactory factory)
        {
            this.factory = factory;
        }

        public void CreateUI()
        {
            this.button = factory.CreateButton();
        }

        public void Paint()
        {
            button.Paint();
        }


    }
}
