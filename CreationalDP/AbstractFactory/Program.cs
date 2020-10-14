namespace DesignParttern.CreationalDP.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ApplicationConfigurator();
            var factory = config.Main();
            Application app = new Application(factory);
            app.CreateUI();
            app.Paint();
        }
    }
}
