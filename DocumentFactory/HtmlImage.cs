using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    internal sealed class HtmlImage : IElement
    {
        private readonly string _src, _alt, _title;

        public HtmlImage(string props)
        {
            var p = props.Split(';');
            _src = p[0];
            _alt = p[1];
            _title = p[2];
        }

        /*Method Name: Render
        *Purpose     : Builds the HTML string for this image.
        *Accepts     : ——
        *Returns     : string
        */
        public string Render()
        {
            return "<img alt='" + _alt + "' title='" + _title + "' src='" + _src + "' /><br />";
        }
    }
}
