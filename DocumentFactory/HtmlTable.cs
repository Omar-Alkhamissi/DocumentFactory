using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    internal sealed class HtmlTable : IElement
    {
        private readonly string _props;

        public HtmlTable(string props)
        {
            _props = props;
        }

        /*Method Name: Render
        *Purpose     : Builds the HTML string for the table.
        *Accepts     : ——
        *Returns     : string
        */
        public string Render()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<table border='1'>");

            foreach (var line in _props.Split(';'))
            {
                var cells = line.Split('$');
                if (cells[0] == "Head")
                {
                    sb.AppendLine("  <thead><tr>");
                    for (int i = 1; i < cells.Length; i++)
                        sb.AppendLine("    <th>" + cells[i] + "</th>");
                    sb.AppendLine("  </tr></thead>");
                }
                else // Row
                {
                    sb.AppendLine("  <tr>");
                    for (int i = 1; i < cells.Length; i++)
                        sb.AppendLine("    <td>" + cells[i] + "</td>");
                    sb.AppendLine("  </tr>");
                }
            }
            sb.AppendLine("</table><br />");
            return sb.ToString();
        }
    }
}
