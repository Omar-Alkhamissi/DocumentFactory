using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DocumentFactory
{
    internal sealed class HtmlDocument : IDocument
    {
        private readonly List<IElement> _elements = new List<IElement>();
        private readonly string _path;

        public HtmlDocument(string fileName)
        {
            _path = fileName + ".html";
        }

        /*Method Name: AddElement
        *Purpose     : Stores an element for later rendering.
        *Accepts     : IElement element
        *Returns     : void
        */
        public void AddElement(IElement element) => _elements.Add(element);

        /*Method Name: RunDocument
        *Purpose     : Builds the HTML file and opens it in Chrome.
        *Accepts     : ——
        *Returns     : void
        */
        public void RunDocument()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html><html><body>");
            _elements.ForEach(e => sb.AppendLine(e.Render()));
            sb.AppendLine("</body></html>");

            File.WriteAllText(_path, sb.ToString());

            Process.Start(new ProcessStartInfo("chrome", "\"" + Path.GetFullPath(_path) + "\"")
            { UseShellExecute = true });
        }
    }
}
