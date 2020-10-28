
namespace DesignParttern.BehavioralDP.Command
{
    /// <summary>
    /// Concrete command go here
    /// </summary>
    class CopyCommand : Command
    {
        public CopyCommand(Application app, Editor editor) : base(app, editor) { }

        /// <summary>
        /// The copy command isn't saved to the history since it
        /// doesn't change the editor's state.
        /// </summary>
        /// <returns></returns>
        public override bool Execute()
        {
            app.Clipboard = editor.GetSelection();
            return false;
        }
    }
}
