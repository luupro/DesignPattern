namespace DesignParttern.BehavioralDP.COR
{
    /// <summary>
    /// But complex components may override the default 
    /// implementation. If the help text can't be provided in a new
    /// way, the component can always call the base implementation
    /// (see Component class).
    /// </summary>
    class Dialog : Container
    {
        public Dialog(string name)
        {
            this.name = name;
        }

        public string WikiPageURL { get; set; }

        public override void ShowHelp()
        {
            if (WikiPageURL != null)
            {
                //Open the wiki help page.
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
}
