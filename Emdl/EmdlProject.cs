using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Emdl {
    class EmdlProject {

        public string Name;
        public string Description;

        public string Path;

        private List<EmdlFile> emdlFiles;

        public static EmdlProject InitNewProjectAt(string name, string path) {
            EmdlProject emdlProject = new EmdlProject {
                Name = name,
                Path = path
            };

            string projectPath = path + name;
            var projectDir = System.IO.Directory.CreateDirectory(projectPath);

            string configPath = projectPath + @"\emdlconfig.json";
            File.WriteAllText(configPath, emdlProject.ToJson());

            return emdlProject;
        }

        public static EmdlProject FromFile(string path) {
            EmdlProject emdlProject = new EmdlProject();

            return emdlProject;
        }


        public string ToJson() {
            return
                "{" +
                $"\"project\": \"{Name}\"" +
                "}";
        }

        public void Load() {
            
        }

        public void Build() {

        }
    }
}
