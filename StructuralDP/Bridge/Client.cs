using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Bridge
{
    class Client
    {
        static void MainProcess(string[] args)
        {
            //Somewhere in client code
            var tv = new Tv();
            var remote = new RemoteControl(tv);
            remote.TogglePower();

            var radio = new Radio();
            remote = new AdvancedRemoteControl(radio);
        }
    }
}
