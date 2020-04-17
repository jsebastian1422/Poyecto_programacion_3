using Prj_Ftp_JG_SV.Classes;
using Prj_Ftp_JG_SV.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Prj_Ftp_JG_SV.ListNodos
{
    class ListaPersona
    {
        NodoPersona cabeza;

        // public Nodo Cabeza;
        public bool ListaVacia() //Metodo que indica si la lista esta vacia
        {
            if (cabeza == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AgregarElementoAlInicio(Persona value) //Metodo que permite adicionar elementos al inicio.
        {
            NodoPersona Nuevo = new NodoPersona(); //Instancia obj Nodo
            Nuevo.Persona = value; //Asignamos el valor del objeto persona obtenido

            if (ListaVacia()) //Validamos si la lista esta vacia
            {
                cabeza = Nuevo; //Cabeza sera el nuevo nodo
            }
            else
            {
                Nuevo.Siguiente = cabeza; //El siguiente nodo es la cabeza anterior
                cabeza = Nuevo; //Cabeza es el nuevo nodo
            }
        }

        public void AgregarElementosAlFinal(Persona value) //Metodo que permite adicionar elementos al final.
        {
            NodoPersona Nuevo = new NodoPersona();  //Instancia obj Nodo
            Nuevo.Persona = value; //Asignamos el valor del objeto persona obtenido

            if (ListaVacia()) //Valida si la lista esta vacia
            {
                cabeza = Nuevo;
            }
            else
            {
                NodoPersona Recorrido = cabeza;
                while (Recorrido.Siguiente != null) //Recorre la lista mientras != null
                {
                    Recorrido = Recorrido.Siguiente; //Se almacena el valor del ultimo nodo
                }
                Recorrido.Siguiente = Nuevo; //El nuevo nodo queda al final (Primero en ingresar);
            }
        }

        public void GenerarXml(String nameFile)
        {
            NodoPersona recorrido = cabeza;
            XmlDocument documento = new XmlDocument();
            XmlDeclaration xmlDeclaration = documento.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = documento.DocumentElement;
            documento.InsertBefore(xmlDeclaration, root);

            XmlElement element_1 = documento.CreateElement("solicitud_inscripcion");
            documento.AppendChild(element_1);

            XmlElement element_2 = documento.CreateElement("solicitudes_estudiantes");
            element_1.AppendChild(element_2);

            while (recorrido != null)
            {
                XmlElement soli_id = documento.CreateElement("solicitud_id");
                soli_id.AppendChild(documento.CreateTextNode(recorrido.Persona.Soli_id));
                element_2.AppendChild(soli_id);

                XmlElement tipo_documento = documento.CreateElement("tipo_documento");
                tipo_documento.AppendChild(documento.CreateTextNode(recorrido.Persona.Tipo_documento));
                element_2.AppendChild(tipo_documento);

                XmlElement documento_id = documento.CreateElement("documento");
                documento_id.AppendChild(documento.CreateTextNode(recorrido.Persona.Documento));
                element_2.AppendChild(documento_id);

                XmlElement lugar_expedicion = documento.CreateElement("lugar_expedicion");
                lugar_expedicion.AppendChild(documento.CreateTextNode(recorrido.Persona.Lugar_expedicion));
                element_2.AppendChild(lugar_expedicion);

                XmlElement genero = documento.CreateElement("genero");
                genero.AppendChild(documento.CreateTextNode(recorrido.Persona.Genero));
                element_2.AppendChild(genero);

                XmlElement primer_nombre = documento.CreateElement("primer_nombre");
                primer_nombre.AppendChild(documento.CreateTextNode(recorrido.Persona.Primer_nombre));
                element_2.AppendChild(primer_nombre);

                XmlElement segundo_nombre = documento.CreateElement("segundo_nombre");
                segundo_nombre.AppendChild(documento.CreateTextNode(recorrido.Persona.Segundo_nombre));
                element_2.AppendChild(segundo_nombre);

                XmlElement primer_apellido = documento.CreateElement("primer_apellido");
                primer_apellido.AppendChild(documento.CreateTextNode(recorrido.Persona.Primer_apellido));
                element_2.AppendChild(primer_apellido);

                XmlElement segundo_apellido = documento.CreateElement("segundo_apellido");
                segundo_apellido.AppendChild(documento.CreateTextNode(recorrido.Persona.Segundo_apellido));
                element_2.AppendChild(segundo_apellido);

                XmlElement estado_civil = documento.CreateElement("estado_civil");
                estado_civil.AppendChild(documento.CreateTextNode(recorrido.Persona.Estado_civil));
                element_2.AppendChild(estado_civil);

                XmlElement pais_origen = documento.CreateElement("pais_origen");
                pais_origen.AppendChild(documento.CreateTextNode(recorrido.Persona.Pais_origen));
                element_2.AppendChild(pais_origen);

                XmlElement dpmt_origen = documento.CreateElement("dpmt_origen");
                dpmt_origen.AppendChild(documento.CreateTextNode(recorrido.Persona.Dpmt_origen));
                element_2.AppendChild(dpmt_origen);

                XmlElement mpio_origen = documento.CreateElement("mpio_origen");
                mpio_origen.AppendChild(documento.CreateTextNode(recorrido.Persona.Mpio_origen));
                element_2.AppendChild(mpio_origen);

                XmlElement fecha_nacimiento = documento.CreateElement("fecha_nacimiento");
                fecha_nacimiento.AppendChild(documento.CreateTextNode(recorrido.Persona.Fecha_nacimiento));
                element_2.AppendChild(fecha_nacimiento);

                XmlElement direccion_residencia = documento.CreateElement("direccion_residencia");
                direccion_residencia.AppendChild(documento.CreateTextNode(recorrido.Persona.Direccion_residencia));
                element_2.AppendChild(direccion_residencia);

                XmlElement barrio = documento.CreateElement("barrio");
                barrio.AppendChild(documento.CreateTextNode(recorrido.Persona.Barrio));
                element_2.AppendChild(barrio);

                XmlElement tele_contacto = documento.CreateElement("tele_contacto");
                tele_contacto.AppendChild(documento.CreateTextNode(recorrido.Persona.Tele_contacto));
                element_2.AppendChild(tele_contacto);

                XmlElement tele_movil = documento.CreateElement("tele_movil");
                tele_movil.AppendChild(documento.CreateTextNode(recorrido.Persona.Tele_movil));
                element_2.AppendChild(tele_movil);

                XmlElement correo = documento.CreateElement("correo");
                correo.AppendChild(documento.CreateTextNode(recorrido.Persona.Correo));
                element_2.AppendChild(correo);

                XmlElement fecha_registro = documento.CreateElement("fecha_registro");
                fecha_registro.AppendChild(documento.CreateTextNode(recorrido.Persona.Fecha_registro));
                element_2.AppendChild(fecha_registro);

                recorrido = recorrido.Siguiente;
            }
            DirectoryInfo di = new DirectoryInfo(@"..\..\DocumentosXml");
            string[] valores = nameFile.Split('.');
            documento.Save(di + "/"+ valores[0] + ".xml");
        }

        public void imprimir() //Metodo que permite imprimir
        {
            NodoPersona recorrido = cabeza;
            while (recorrido != null) //Recorre mientras el nodo != null
            {
                Console.Write(recorrido.Persona.ToString() + " ->"); //Imprime los nodos de la lista
                recorrido = recorrido.Siguiente; //Avanza con el siguiente nodo.
                Console.Write("*\n");
            }
            Console.WriteLine("*\n");
        }
    }
}
