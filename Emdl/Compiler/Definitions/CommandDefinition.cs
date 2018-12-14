using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emdl.Compiler.Definitions {
    public abstract class CommandDefinition {

        public readonly string Name;

        protected CommandDefinition(string name) {
            Name = name;
        }

        public abstract CommandInstance Init(string line);
    }
}
