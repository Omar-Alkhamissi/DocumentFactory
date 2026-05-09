using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    internal sealed class MarkdownImage : IElement
    {
        private readonly string _src, _alt, _title;

        public MarkdownImage(string props)
        {
            var p = props.Split(';');
            _src = p[0];
            _alt = p[1];
            _title = p[2];
        }

        /*Method Name: Render
        *Purpose     : Builds the Markdown string for this image.
        *Accepts     : ——
        *Returns     : string
        */
        public string Render()
        {
            return "![" + _alt + "](" + _src + " \"" + _title + "\")\n";
        }
    }
}
