using System.Collections.Generic;

namespace DesignParttern.BehavioralDP.Command
{
    /// <summary>
    /// The global command history is just a stack
    /// </summary>
    class CommandHistory
    {
        private Stack<Command> history = new Stack<Command>();

        // last in ...
        public void Push(Command c)
        {
            history.Push(c);
        }

        // first out ...
        public Command Pop()
        {
            return history.Pop();
        }

    }
}
