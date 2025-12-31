/**
Class Name: MarkdownDocument
Purpose   : Concrete document that writes Markdown to disk and opens Notepad.
Coder     : Omar Alkhamissi
Date      : 2025-06-09
*/
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DocumentFactory
{
    internal sealed class MarkdownDocument : IDocument
    {
        private readonly List<IElement> _elements = new List<IElement>();
        private readonly string _path;

        public MarkdownDocument(string fileName)
        {
            _path = fileName + ".md";
        }

        /*Method Name: AddElement
        *Purpose     : Stores an element for later rendering.
        *Accepts     : IElement element
        *Returns     : void
        */
        public void AddElement(IElement element) => _elements.Add(element);

        /*Method Name: RunDocument
        *Purpose     : Builds the .md file and opens it in Notepad.
        *Accepts     : ——
        *Returns     : void
        */
        public void RunDocument()
        {
            var sb = new StringBuilder();
            _elements.ForEach(e => sb.AppendLine(e.Render()));
            File.WriteAllText(_path, sb.ToString());

            Process.Start(new ProcessStartInfo("notepad.exe", "\"" + Path.GetFullPath(_path) + "\"")
            { UseShellExecute = true });
        }
    }
}
