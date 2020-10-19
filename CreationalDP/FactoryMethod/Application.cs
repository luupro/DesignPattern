
namespace DesignParttern.CreationalDP.FactoryMethod
{
    public class Application
    {
        static Dialog dialog;

        // The application picks a creator's type depending on the 
        // current configuration or environment settings.
        public static void Initialize()
        {
            var config = readApplicationConfigFIle();

            if (config.OS.Equals("Window"))
            {
                dialog = new WindowsDialog();
            }
            else if (config.OS.Equals("Web"))
            {
                dialog = new WebDialog();
            }
            else
                throw new System.Exception("Error! Uknown operating system.");
        }


        public void MainProcess(string[] args)
        {
            Initialize();
            dialog.Render();
        }

        static private ConfigSimulator readApplicationConfigFIle()
        {
            throw new System.NotImplementedException();
        }
    }
}
