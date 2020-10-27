namespace DesignParttern.BehavioralDP.COR
{
    class Component : IComponentWithContextualHelp
    {
        public string TooltipText { get; set; }

        protected string name;

        protected int x;
        protected int y;
        protected int width;
        protected int height;

        // The component's container acts as the next link in the
        // chain of handlers.
        //protected Container container;
        public Container container;


        /// <summary>
        /// The component shows a tooltip if there's a help text
        /// assigned to it. Otherwise it forwards the call to the
        /// container, if it exists.
        /// </summary>
        public virtual void ShowHelp()
        {
            if (TooltipText != null)
            {
                //show tooltip
            }
            else
            {
                container.ShowHelp();
            }
        }
    }
}
