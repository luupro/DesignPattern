namespace DesignParttern.BehavioralDP.Command
{
    /// <summary>
    /// The undo operation is also a command.
    /// </summary>
    class UndoCommand : Command
    {
        public UndoCommand(Application app, Editor editor) : base(app, editor) { }

        public override bool Execute()
        {
            app.Undo();
            return false;
        }
    }
}
