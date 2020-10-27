namespace DesignParttern.BehavioralDP.COR
{
    /// <summary>
    /// But complex components may override the default 
    /// implementation. If the help text can't be provided in a new
    /// way, the component can always call the base implementation
    /// (see Component class).
    /// </summary>
    class Panel : Container
    {
        public Panel(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public string ModalHelpText { get; set; }

        public override void ShowHelp()
        {
            if (ModalHelpText != null)
            {
                //Show a modal window with the help text.
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
}
