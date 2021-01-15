using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextEditor t = new TextEditor();
            //Console.WriteLine("Enter any");
            //string str = Console.ReadLine();
            //Console.WriteLine($"str == null is {str == null}");
            //Console.WriteLine($"str == empty string is {str == ""}");
            //Console.WriteLine("Hello World!");

            TextEditor textEditor = TextEditorManager.StartTextEditor();
            TextEditorManager.ManageTextEditor(textEditor);
        }
    }
}
