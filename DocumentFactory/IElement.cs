/**
Class Name: IElement
Purpose   : Contract for document elements that can render themselves.
Coder     : Omar Alkhamissi
Date      : 2025-06-09
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    public interface IElement
    {
        /*Method Name: Render
        *Purpose     : Produces formatted markup text for the element.
        *Accepts     : ——
        *Returns     : string – rendered output.
        */
        string Render();
    }
}
