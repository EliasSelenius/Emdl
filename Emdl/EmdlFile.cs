using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Emdl {
    class EmdlFile {

        const string Function_regex = "func +(?<name>\\w+) +{(?<body>[a-zA-Z0-9\\w\\s\\n'\"/;.,]*)}";

        public EmdlFile(FileInfo file) {

        }

        public void Build() {

        }

    }
}
