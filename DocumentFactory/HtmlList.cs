/**
Class Name: HtmlList
Purpose   : Renders an ordered or unordered HTML list.
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
    internal sealed class HtmlList : IElement
    {
        private readonly bool _ordered;
        private readonly string[] _items;

        public HtmlList(string props)
        {
            var parts = props.Split(';');
            _ordered = parts[0] == "Ordered";
            _items = parts[1].Split(';');
        }

        /*Method Name: Render
        *Purpose     : Builds the HTML string for this list.
        *Accepts     : ——
        *Returns     : string
        */
        public string Render()
        {
            var sb = new StringBuilder();
            sb.AppendLine(_ordered ? "<ol>" : "<ul>");
            foreach (var item in _items) sb.AppendLine("  <li>" + item + "</li>");
            sb.AppendLine(_ordered ? "</ol><br />" : "</ul><br />");
            return sb.ToString();
        }
    }
}
