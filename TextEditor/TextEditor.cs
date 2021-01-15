using System;
using System.Collections.Generic;
using System.Text;
using TextEditor.ModificationLoggers;

namespace TextEditor
{
    class TextEditor
    {
        public static string Output { get; set; }
                
        private static readonly List<IModification> modificationLogs = new List<IModification>();
        public string Buffer { get; private set; } = null;

        public TextEditor()
        {
            Output = "Это пример текста, которым по умолчанию инициализируется поле _output объекта класса TextEditor при создании объекта" +
                " посредством конструктора без параметров";
        }

        public TextEditor(string initialText)
        {
            Output = initialText;
        }

        public void Insert(string text)
        {
            Output += text;
            modificationLogs.Insert(0, new Paste_InsertionLog(text.Length));
        }

        public void Delete()
        {
            if (Output.Length == 0)
            {
                throw new MyException("It's nothing to delete. String is empty.");
            }
            else
            {
                modificationLogs.Insert(0, new DeletionLog(Output[Output.Length-1]));
                Output = Output.Remove(Output.Length - 1);                 
            }

        }

        public void Copy(int startIndex)
        {
            if (Output.Length == 0 || startIndex < 0 || startIndex >= Output.Length)
            {
                throw new MyException("It's nothing to copy. There's no any symbols to copy or start index out of text bounds.");
            }
            else
            {
                Buffer = Output.Substring(startIndex);
            }

        }

        public void Paste()
        {
            if (Buffer == null)
            {
                throw new MyException("It's nothing to paste. Buffer is empty.");
            }
            else
            {
                
                Output += Buffer;
                modificationLogs.Insert(0, new Paste_InsertionLog(Buffer.Length));
                Buffer = null;
            }

        }


        public void Undo()
        {
            if (modificationLogs.Count == 0)
            {
                throw new MyException("It's nothing to undo. The text haven't been changed or the last text modification was undone");
            }
            else
            {
                modificationLogs[0].UndoModification();
                modificationLogs.RemoveAt(0);
            }

        }

        public void DisplayText()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nTEXT: ");
            Console.ResetColor();
            Console.WriteLine(Output);
        }

        
                
    }
    
}
