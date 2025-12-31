/**
Class Name: HtmlDocumentFactory
Purpose   : Singleton factory that produces HTML documents and elements.
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
    public sealed class HtmlDocumentFactory : IDocumentFactory
    {
        private static readonly HtmlDocumentFactory _instance = new HtmlDocumentFactory();
        public static HtmlDocumentFactory Instance
        {
            /*Method Name: get_Instance
            *Purpose     : Provides global singleton access.
            *Accepts     : ——
            *Returns     : HtmlDocumentFactory – singleton instance.
            */
            get { return _instance; }
        }

        private HtmlDocumentFactory() { }

        /*Method Name: CreateDocument
        *Purpose     : Creates an HtmlDocument.
        *Accepts     : string fileName
        *Returns     : IDocument
        */
        public IDocument CreateDocument(string fileName)
        {
            return new HtmlDocument(fileName);
        }

        /*Method Name: CreateElement
        *Purpose     : Creates an HTML-specific element.
        *Accepts     : string elementType, string props
        *Returns     : IElement
        */
        public IElement CreateElement(string elementType, string props)
        {
            switch (elementType)
            {
                case "Header": return new HtmlHeader(props);
                case "Image": return new HtmlImage(props);
                case "List": return new HtmlList(props);
                case "Table": return new HtmlTable(props);
                default:
                    throw new ArgumentException("Unknown HTML element: " + elementType);
            }
        }
    }
}
