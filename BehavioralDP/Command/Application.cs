using System.Collections.Generic;

namespace DesignParttern.BehavioralDP.Command
{
    /// <summary>
    /// The application class sets up object relations. It acts as a 
    /// sender: when something need to be done, it creates a command 
    /// object and executes it.
    /// </summary>
    class Application
    {
        public string Clipboard;
        public List<Editor> editors;
        public Editor activeEditor;
        public CommandHistory history;

        /// <summary>
        /// The code which assigns commands to UI objects may look
        /// like this.
        /// </summary>
        public void CreateUI()
        {
            //...

        }

        /// <summary>
        /// Execute a command and check whether it has to be added
        /// to the history.
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(Command command)
        {
            if (command.Execute())
            {
                history.Push(command);
            }
        }

        public void Undo()
        {
            var command = history.Pop();
            if (command != null)
            {
                command.Undo();
            }
        }
    }
}
