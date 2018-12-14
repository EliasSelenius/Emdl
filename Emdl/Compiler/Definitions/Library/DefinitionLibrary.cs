using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emdl.Compiler.Definitions;

namespace Emdl.Compiler.Definitions.Library {
    public abstract class DefinitionLibrary {
        private static readonly List<CommandDefinition> definitions = new List<CommandDefinition>();
        
        public static bool IsValidCommand(string command) {
            foreach (CommandDefinition def in definitions) {
                if (def.Name.Equals(command)) {
                    return true;
                }
            }
            return false;
        }

        public static CommandDefinition GetDefinitionOfLine(string line) {
            string name = StringHelper.GetCommandOfLine(line);
            CommandDefinition res = null;
            definitions.ForEach(def => {
                if (def.Name.Equals(name)) {
                    res = def;
                }
            });

            return res;
        }

        public static void AddDefinition(CommandDefinition def) {
            definitions.Add(def);
        }
    }
}
