using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


using Emdl.Compiler;

namespace Emdl {
    class EmdlFile {

        public string RawText;

        public string[] Lines => RawText.Split('\n');

        public static EmdlFile Load(string path) {
            EmdlFile file = new EmdlFile {
                RawText = File.ReadAllText(path)
            };

            foreach (string line in file.Lines) {
                string command = StringHelper.GetCommandOfLine(line);
                if (DefinitionLibrary.IsValidCommand(command)) {
                    Console.WriteLine(command);

                }
            }
            Console.Read();
            

            return file;
        }
    }
}
