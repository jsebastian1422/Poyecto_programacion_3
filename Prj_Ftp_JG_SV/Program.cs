using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Ftp_JG_SV.Processes;

namespace Prj_Ftp_JG_SV
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"..\..\Documentos");
            foreach (var fi in di.GetFiles())
            {
                Procesos procesos = new Procesos();
                string[] nameFile = fi.Name.Split('_');
                string[] contentFile = File.ReadAllLines(di + "/" + fi.Name);
                switch (nameFile[0])
                {
                    case "SOLI":
                        procesos.GenerarXmlSolictInscripcion(fi.Name, contentFile);                       
                        break;
                    case "SOLMAFI":
                        //Console.WriteLine(fi.Name);
                        break;
                    case "SOLMAAC":
                        //Console.WriteLine(fi.Name);
                        break;
                    case "SOLGRA":
                        //Console.WriteLine(fi.Name);
                        break;
                    case "SOLCREES":
                        //Console.WriteLine(fi.Name);
                        break;
                    case "SOLCANMA":
                        //Console.WriteLine(fi.Name);
                        break;
                    default:
                        break;
                }
            }
        }
       
    }
}
