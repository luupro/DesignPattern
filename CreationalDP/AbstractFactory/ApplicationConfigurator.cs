using System;

namespace DesignParttern.CreationalDP.AbstractFactory
{
    class ApplicationConfigurator
    {

        public IGuiFactory MainProcess()
        {
            IGuiFactory factory;
            var config = readApplicationConfigFIle();

            if (config.OS.Equals("Windows"))
            {
                factory = new WinFactory();
            }
            else if (config.OS.Equals("Mac"))
            {
                factory = new MacFactory();
            }
            else
            {
                throw new Exception("Error! Unknown operating system.");
            }

            return factory;
        }

        private ConfigSimulator readApplicationConfigFIle()
        {
            throw new System.NotImplementedException();
        }
    }
}
