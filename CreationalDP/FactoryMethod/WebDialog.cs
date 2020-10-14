namespace DesignParttern.CreationalDP.FactoryMethod
{
    class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HtmlButton();
        }
    }
}
