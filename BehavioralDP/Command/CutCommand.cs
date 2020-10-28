namespace DesignParttern.BehavioralDP.Command
{
    class CutCommand : Command
    {
        public CutCommand(Application app, Editor editor) : base(app, editor) { }

        /// <summary>
        /// The cut command does change the editor's state, therefore
        /// it must be saved to the history. And it'll be saved as 
        /// long as the method return true.
        /// </summary>
        /// <returns></returns>
        public override bool Execute()
        {
            SaveBackup();
            app.Clipboard = editor.GetSelection();
            editor.DeleteSelection();
            return true;
        }
    }
}
