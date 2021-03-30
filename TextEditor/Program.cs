using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {            
            TextEditorConsoleController controller = new TextEditorConsoleController();
            TextEditor textEditor = controller.StartTextEditor();
            controller.ManageTextEditor(textEditor);
        }
    }
}
