#region Imports

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.CSharp;

#endregion

namespace PEIK.Util.Crypter
{
    internal class Compiler
    {
        protected static CompilerError CompileError;

        public static void GenerateExecutable(string output, string source, string icon)
        {
            CSharpCodeProvider compiler = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters
                                                {
                                                    GenerateExecutable = true,
                                                    OutputAssembly = output
                                                };
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Data.dll");
            parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");

            string ico = Path.GetTempPath() + "\\comp.ico";

            if (!string.IsNullOrEmpty(icon))
            {
                File.Copy(icon, ico);
                parameters.CompilerOptions += " /win32icon:" + ico;
            }

            CompilerResults cResults = compiler.CompileAssemblyFromSource(parameters, source);
            if (cResults.Errors.Count > 0)
            {
                foreach (CompilerError compilerErrorLoopVariable in cResults.Errors)
                {
                    CompileError = compilerErrorLoopVariable;
                    MessageBox.Show("Error: " + CompileError.ErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!string.IsNullOrEmpty(icon))
            {
                File.Delete(ico);
            }
        }
    }
}