using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Emdl = ExtendedMinecraftDatapackLanguage


namespace Emdl {
    class Program {
        static void Main(string[] args) {
            //EmdlProject proj = EmdlProject.InitNewProjectAt("MyFirstProject", @"D:\Documents\repos\EmdlProjects\");

            EmdlFile file = EmdlFile.Load(@"D:\Documents\repos\EmdlProjects\MyFirstProject\Main.emdl");

            
        }

        static void ValidateArg(string arg) {
            switch (arg) {
                case "new":
                    Console.WriteLine("Creating new Emdl project");
                    break;
                case "build":
                    Console.WriteLine("building project");
                    break;
                default:
                    Console.WriteLine($"{arg} not recognized");
                    break;
            }

        }
    }
}
