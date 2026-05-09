using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    internal class HtmlHeader : IElement
    {
        private readonly int _level;
        private readonly string _text;

        public HtmlHeader(string props)
        {
            var p = props.Split(';');
            _level = int.Parse(p[0]);
            _text = p[1];
        }

        /*Method Name: Render
        *Purpose     : Builds the HTML string for this header.
        *Accepts     : ——
        *Returns     : string
        */
        public string Render() => "<h" + _level + ">" + _text + "</h" + _level + "><br />";
    }
}

