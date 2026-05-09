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
