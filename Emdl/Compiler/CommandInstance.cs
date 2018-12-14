using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emdl.Compiler.Definitions;

namespace Emdl.Compiler {
    public class CommandInstance {

        private readonly CommandDefinition definition;

        bool IsInitialized => definition != null;

        public CommandInstance(string text) {
            RawText = text;
            definition = DefinitionLibrary.GetDefinitionOfLine(RawText);
        }


        readonly string RawText;

        string[] Args => throw new NotImplementedException();

    }
}
