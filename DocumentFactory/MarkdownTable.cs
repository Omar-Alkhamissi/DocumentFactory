using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    internal sealed class MarkdownTable : IElement
    {
        private readonly string _props;

        public MarkdownTable(string props)
        {
            _props = props;
        }

        /*Method Name: Render
        *Purpose     : Builds the Markdown string for the table.
        *Accepts     : ——
        *Returns     : string
        */
        public string Render()
        {
            var sb = new StringBuilder();
            string[] lines = _props.Split(';');

            for (int idx = 0; idx < lines.Length; idx++)
            {
                var cells = lines[idx].Split('$').Skip(1).ToArray();
                sb.AppendLine("| " + string.Join(" | ", cells) + " |");

                if (idx == 0)
                {
                    sb.AppendLine("| " + string.Join(" | ", cells.Select(_ => "---")) + " |");
                }
            }
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
