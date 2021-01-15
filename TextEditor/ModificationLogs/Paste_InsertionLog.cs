using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor.ModificationLoggers
{
    public class Paste_InsertionLog : IModification
    {
        readonly int insertionLength;
        public Paste_InsertionLog(int insertedTextLength)
        {
            insertionLength = insertedTextLength;
        }
        public void UndoModification()
        {
            TextEditor.Output = TextEditor.Output.Remove(TextEditor.Output.Length - insertionLength);
        }
    }
}
