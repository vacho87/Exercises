using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor
{
    class TextEditorManager
    {
        public static TextEditor StartTextEditor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, 0);
            Console.WriteLine("===============STARTING TEXT EDITOR===============");
            PrintInvitation("\nEnter your text or just press enter - button to use sample text for initializing TextEditor");

            string str = Console.ReadLine();
            
            TextEditor textEditor;
            if (str == "")
            {
                textEditor = new TextEditor();
            }
            else
            {
                textEditor = new TextEditor(str);
            }

            textEditor.DisplayText();
            return textEditor;
        }

        public static void ManageTextEditor(TextEditor textEditor)
        {
            string command;
            do
            {
                PrintInvitation("\n << Chose command: \n" +
                           "  - \"i\" - to Insert some text to the end of the current text (append);\n" +
                           "  - \"d\" - to Delete the last symbol from the current text;\n" +
                           "  - \"c\" - to Copy a substring of existing text starting from {index} and to the end;\n" +
                           "  - \"p\" - to Paste (append) copied text to the current one;\n" +
                           "  - \"u\" - to Undo the last successful operation;\n" +
                           "  - \"e\" - to Exit the TextEditor;");

                command = Console.ReadLine();
                command.Trim().ToLower();

                if (InputIsACorrectCommand(command))
                {
                    try
                    {
                        switch (command)
                        {
                            case "i":
                                textEditor.Insert(GetString());
                                break;
                            case "d":
                                textEditor.Delete();
                                break;
                            case "c":
                                textEditor.Copy(GetInt());
                                break;
                            case "p":
                                textEditor.Paste();
                                break;
                            case "u":
                                textEditor.Undo();
                                break;
                            case "e":
                                return;
                        }

                    }
                    catch (MyException ex)
                    {
                        ReportOfError(ex.Message);
                    }
                    
                    textEditor.DisplayText();
                }
                else
                {
                    ReportOfError("Inputed command is incorrect. Try again.");                    
                }

            } while (true);
            

        }

        public static void PrintInvitation(string invitation)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(invitation);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n >>   ");
            Console.ResetColor();
        }

        public static void ReportOfError(string errorReport)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" !!! ERROR: {errorReport}\n");            
            Console.ResetColor();
        }

        private static bool InputIsACorrectCommand(string str)
        {
            List<string> commands = new List<string> { "i", "d", "c", "p", "u", "e" };
            if (commands.Contains(str))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private static string GetString()
        {
            PrintInvitation(" << Enter any text to to append it to the end of actual text");
            return Console.ReadLine();            
        }

        private static int GetInt()
        {
            string input;
            while (true)
            {
                PrintInvitation(" << Enter number of index to determine the beginnig of the copying text substring");
                input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    ReportOfError("Inputted data is not an integer number. Try again.");
                }
            }
            
        }

    }
}
