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
        public void UndoModification(TextEditor textEditor)
        {
            textEditor.Output = textEditor.Output.Remove(textEditor.Output.Length - insertionLength);
        }
    }
}
