using Prj_Ftp_JG_SV.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Ftp_JG_SV.Utils
{
    class NodoPersona
    {
        private Persona persona;
        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        private NodoPersona siguiente;
        public NodoPersona Siguiente //Se encapsula
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
