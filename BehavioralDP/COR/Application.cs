using System;

namespace DesignParttern.BehavioralDP.COR
{
    /// <summary>
    /// Client code
    /// </summary>
    class Application
    {
        // Every application configures the chain differently.
        public void CreateUI()
        {
            var dialog = new Dialog("Budget Reports");
            dialog.WikiPageURL = "http://...";

            var panel = new Panel(0, 0, 400, 800);
            panel.ModalHelpText = "This panel does...";

            var ok = new Button(250, 760, 50, 20, "OK");
            ok.TooltipText = "This is an OK button that...";

            var cancel = new Button(320, 760, 50, 20, "Cancel");
            //...

            panel.Add(ok);
            panel.Add(cancel);
            dialog.Add(panel);
        }

        public void OnF1KeyPress()
        {
            var component = this.getComponentAtMouseCoords();
            component.ShowHelp();
        }

        private Component getComponentAtMouseCoords()
        {
            throw new NotImplementedException();
        }
    }
}
