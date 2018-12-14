using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emdl.Compiler.Definitions.Library;

namespace Emdl.Compiler {
    class CommandInstanceBody : CommandInstance {
        public CommandInstanceBody(string text) : base(text) {
        }

        string Body { get; }

        DefinitionLibrary BodyDefinitions;
    }
}
