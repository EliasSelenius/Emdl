using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emdl {
    class McFunctionFile {

        public string Name;
        private List<string> lines = new List<string>();

        public McFunctionFile(string name) {
            Name = name;
        }

        public void ToDisk() {
            System.IO.File.AppendAllLines(Name, lines);
        }

        public void WriteLines(params string[] l) {
            lines.AddRange(l);
        }


    }
}
