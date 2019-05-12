using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Emdl = ExtendedMinecraftDatapackLanguage


namespace Emdl {
    class Program {

        public static EmdlProject Project;

        static void Main(string[] args) {

            
            //EmdlFile file = EmdlFile.Load(@"D:\Documents\repos\EmdlProjects\MyFirstProject\Main.emdl");

            foreach (var arg in args) {
                ValidateArg(arg);
            }
            
        }


        static void ValidateArg(string arg) {
            switch (arg) {
                case "init":
                    Console.WriteLine("Creating new Emdl project");
                    Project = EmdlProject.InitNew();
                    break;
                case "build":
                    Console.WriteLine("building project");

                    Project = EmdlProject.Load();
                    Project.Build();
                    break;
                default:
                    Console.WriteLine($"{arg} not recognized");
                    break;
            }

        }
    }
}
