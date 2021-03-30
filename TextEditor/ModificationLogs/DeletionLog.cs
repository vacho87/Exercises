using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor
{
    class DeletionLog : IModification
    {
        private readonly char deletedSymbol;
        public DeletionLog(char delSymb)
        {
            deletedSymbol = delSymb;
        }

        public void UndoModification(TextEditor textEditor)
        {
            textEditor.Output += deletedSymbol;
        }
    }
}
