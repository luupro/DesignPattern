
namespace DesignParttern.BehavioralDP.Command
{
    /// <summary>
    /// The editor class has actual text editing operations. It plays
    /// the role of receiver: all commands end up delegating 
    /// execution to editor's methods.
    /// </summary>
    class Editor
    {
        public string Text { get; set; }

        public string GetSelection()
        {
            return "selected text";
        }

        public string DeleteSelection()
        {
            return "delete selected text";
        }

        public string ReplaceSelection(string clipboard)
        {
            return clipboard;
        }
    }
}
