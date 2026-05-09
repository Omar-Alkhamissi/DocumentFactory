using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    internal sealed class MarkdownList : IElement
    {
        private readonly bool _ordered;
        private readonly string[] _items;

        public MarkdownList(string props)
        {
            var parts = props.Split(';');
            _ordered = parts[0] == "Ordered";
            _items = parts[1].Split(';');
        }

        /*Method Name: Render
        *Purpose     : Builds the Markdown string for this list.
        *Accepts     : ——
        *Returns     : string
        */
        public string Render()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < _items.Length; i++)
            {
                string bullet = _ordered ? (i + 1).ToString() + ". " : "- ";
                sb.AppendLine(bullet + _items[i]);
            }
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
