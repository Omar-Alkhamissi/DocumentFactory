/**
Class Name: MarkdownHeader
Purpose   : Renders a Markdown # / ## / ### header line.
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
    internal sealed class MarkdownHeader : IElement
    {
        private readonly int _level;
        private readonly string _text;

        public MarkdownHeader(string props)
        {
            var p = props.Split(';');
            _level = int.Parse(p[0]);
            _text = p[1];
        }

        /*Method Name: Render
        *Purpose     : Builds the Markdown string for this header.
        *Accepts     : ——
        *Returns     : string
        */
        public string Render()
        {
            return new string('#', _level) + " " + _text + "\n";
        }
    }
}
