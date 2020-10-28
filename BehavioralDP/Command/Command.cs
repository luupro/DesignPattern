namespace DesignParttern.BehavioralDP.Command
{
    /// <summary>
    /// The base command class defines the common interface for all
    /// concrete commands.
    /// </summary>
    abstract class Command
    {
        protected Application app;
        protected Editor editor;
        protected string backup;

        public Command(Application app, Editor editor)
        {
            this.app = app;
            this.editor = editor;
        }

        /// <summary>
        /// Make a backup of editor's state.
        /// </summary>
        public void SaveBackup()
        {
            backup = editor.Text;
        }

        /// <summary>
        /// Restore the editor's state.
        /// </summary>
        public void Undo()
        {
            editor.Text = backup;
        }

        /// <summary>
        /// The execution method is declared abstract to force all
        /// concrete command to provide their own implementations.
        /// The method must return true or false depending on whether
        /// the command changes the editor's state.
        /// </summary>
        public abstract bool Execute();
    }
}
