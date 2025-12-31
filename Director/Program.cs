/**
Class Name: Program
Purpose   : Console entry point that reads the script file, parses commands,
            and drives document creation.
Coder     : Omar Alkhamissi
Date      : 2025-06-09
*/
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using DocumentFactory;

namespace Director
{
    internal class Program
    {
        /*Method Name: Main
        *Purpose     : Executes the script processing workflow.
        *Accepts     : string[] args.
        *Returns     : void
        */
        private static void Main(string[] args)
        {
            string script = File.ReadAllText(@"CreateDocumentScript.txt");

            IDocumentFactory factory = null;
            IDocument doc = null;

            foreach (string raw in script.Split('#'))
            {
                string line = Regex.Replace(raw, @"\t|\n|\r", "").Trim();
                if (line.Length == 0) continue;

                string[] parts = line.Split(':');
                string command = parts[0];

                if (command == "Document")
                {
                    string[] docFields = parts[1].Split(';');
                    string docType = docFields[0];
                    string fileName = docFields[1];

                    if (docType.Equals("Html", StringComparison.OrdinalIgnoreCase))
                        factory = HtmlDocumentFactory.Instance;
                    else
                        factory = MarkdownDocumentFactory.Instance;

                    doc = factory.CreateDocument(fileName);
                }
                else if (command == "Element" && factory != null && doc != null)
                {
                    string payload = line.Substring("Element:".Length);
                    int firstColon = payload.IndexOf(':');

                    string elemType;
                    string props;

                    if (firstColon >= 0)
                    {
                        elemType = payload.Substring(0, firstColon);
                        props = payload.Substring(firstColon + 1);
                    }
                    else
                    {
                        elemType = payload;
                        props = string.Empty;
                    }

                    IElement element = factory.CreateElement(elemType, props);
                    doc.AddElement(element);
                }
                else if (command == "Run" && doc != null)
                {
                    doc.RunDocument();
                }
            }
        }
    }
}
