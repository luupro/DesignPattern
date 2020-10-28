namespace DesignParttern.BehavioralDP.Command
{
    class PasteCommand : Command
    {
        public PasteCommand(Application app, Editor editor) : base(app, editor) { }

        public override bool Execute()
        {
            SaveBackup();
            editor.ReplaceSelection(app.Clipboard);
            return true;
        }
    }
}
