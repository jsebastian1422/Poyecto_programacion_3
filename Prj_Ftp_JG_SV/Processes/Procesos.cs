using Prj_Ftp_JG_SV.Classes;
using Prj_Ftp_JG_SV.ListNodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Ftp_JG_SV.Processes
{
    class Procesos
    {
        public void GenerarXmlSolictInscripcion(string nameFile, string[] contentFile)
        {
            //Console.WriteLine("Nombre Archivo : " + nameFile);
            foreach (var item in contentFile)
            {
                var valores = item.Split(';');
                ListaPersona listPersona = new ListaPersona();
                listPersona.AgregarElementoAlInicio(new Persona { Soli_id = valores[0],
                    Tipo_documento = valores[1], Documento = valores[2], Lugar_expedicion = valores[3],
                    Genero = valores[4], Primer_nombre = valores[5], Segundo_nombre = valores[6],
                    Primer_apellido = valores[7], Segundo_apellido = valores[8], Estado_civil = valores[9],
                    Pais_origen = valores[10], Dpmt_origen = valores[11], Mpio_origen = valores[12], Fecha_nacimiento = valores[13],
                    Direccion_residencia = valores[14], Barrio = valores[15], Tele_contacto = valores[16], Tele_movil = valores[17],
                    Correo = valores[18], Fecha_registro = valores[19]
                });

                listPersona.GenerarXml(nameFile);
                //listPersona.imprimir();
            }
        }
    }
}
