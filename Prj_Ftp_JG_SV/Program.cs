using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Ftp_JG_SV
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"..\..\Documentos");
            Console.WriteLine("No search pattern returns:");
            Console.WriteLine(di.Name + "\n");
            foreach (var fi in di.GetFiles())
            {
                string[] lineas = File.ReadAllLines(di + "/" + fi.Name);
                foreach (var item in lineas)
                {
                    var valores = item.Split(';');
                    Console.Write(valores[0]);
                }

                //Console.WriteLine(fi.Name + "\n");
            }
       
            Console.WriteLine();
        }
    }
}
