using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor
{
    interface IModification
    {
        void UndoModification();
    }
}
