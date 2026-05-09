using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    public interface IDocument
    {
        /*Method Name: AddElement
        *Purpose     : Adds an element to the document’s internal list.
        *Accepts     : IElement element – element to append.
        *Returns     : void
        */
        void AddElement(IElement element);

        /*Method Name: RunDocument
        *Purpose     : Serializes the document to disk and launches a viewer.
        *Accepts     : ——
        *Returns     : void
        */
        void RunDocument();
    }
}
