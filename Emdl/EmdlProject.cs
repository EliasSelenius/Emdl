using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Emdl {
    class EmdlProject {

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DirectoryInfo OutputDir { get; private set; }
        public DirectoryInfo RootDir { get; private set; }


        private EmdlProject(string name, string desc, string rootdir, string outdir) {

            Name = name;
            Description = desc;

            RootDir = new DirectoryInfo(rootdir);
            OutputDir = new DirectoryInfo(outdir);
        }

        public static EmdlProject InitNew() {


            var proj = new EmdlProject("", "", Directory.GetCurrentDirectory(), Directory.GetCurrentDirectory() + "\\output\\");

            File.WriteAllLines("emdlconfig.json", new[] { proj.ToJson() });


            return proj;
        }

        private string ToJson() {
            return "{\"msg\": \"Work In progress\"}";
        }

        public static EmdlProject Load() {
            return new EmdlProject("", "", Directory.GetCurrentDirectory(), Directory.GetCurrentDirectory() + "\\output\\");

        }

        public void Build() {
            OutputDir.CreateSubdirectory("data");

            foreach(var file in RootDir.EnumerateFiles("*.emdl")) {
                new EmdlFile(file).Build();
            }

        }

      
    }
}
