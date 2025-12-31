/**
Class Name: MarkdownDocumentFactory
Purpose   : Singleton factory that produces Markdown documents and elements.
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
    public sealed class MarkdownDocumentFactory : IDocumentFactory
    {
        private static readonly MarkdownDocumentFactory _instance = new MarkdownDocumentFactory();
        public static MarkdownDocumentFactory Instance
        {
            /*Method Name: get_Instance
            *Purpose     : Provides global singleton access.
            *Accepts     : ——
            *Returns     : MarkdownDocumentFactory – singleton instance.
            */
            get { return _instance; }
        }

        private MarkdownDocumentFactory() { }

        /*Method Name: CreateDocument
        *Purpose     : Creates a MarkdownDocument.
        *Accepts     : string fileName
        *Returns     : IDocument
        */
        public IDocument CreateDocument(string fileName)
        {
            return new MarkdownDocument(fileName);
        }

        /*Method Name: CreateElement
        *Purpose     : Creates a Markdown-specific element.
        *Accepts     : string elementType, string props
        *Returns     : IElement
        */
        public IElement CreateElement(string elementType, string props)
        {
            switch (elementType)
            {
                case "Header": return new MarkdownHeader(props);
                case "Image": return new MarkdownImage(props);
                case "List": return new MarkdownList(props);
                case "Table": return new MarkdownTable(props);
                default:
                    throw new ArgumentException("Unknown Markdown element: " + elementType);
            }
        }
    }
}
