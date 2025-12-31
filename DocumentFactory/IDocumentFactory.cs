/**
Class Name: IDocumentFactory
Purpose   : Abstract factory for creating documents and their elements.
Coder     : Omar Alkhamissi
Date      : 2025-06-09
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public interface IDocumentFactory
    {
        /*Method Name: CreateDocument
        *Purpose     : Instantiates a concrete document object.
        *Accepts     : string fileName – base name of the file to create.
        *Returns     : IDocument – the new document instance.
        */
        IDocument CreateDocument(string fileName);

        /*Method Name: CreateElement
        *Purpose     : Instantiates a concrete element object.
        *Accepts     : string elementType – type keyword (Header, Image, …).
        *              string props       – serialized element parameters.
        *Returns     : IElement – the new element instance.
        */
        IElement CreateElement(string elementType, string props);
    }
}
