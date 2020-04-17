using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Ftp_JG_SV.Classes
{
    class Persona
    {
        string soli_id,tipo_documento, documento, lugar_expedicion, genero, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, estado_civil, pais_origen, dpmt_origen, mpio_origen
               , fecha_nacimiento, direccion_residencia, barrio, tele_contacto, tele_movil, correo, fecha_registro;
    
        /*public string Soli_id
        {
            get { return soli_id; }
            set { this.soli_id = Soli_id; }
        }
        public string Tipo_documento
        {
            get { return tipo_documento; }
            set { this.tipo_documento = Tipo_documento; }
        }
        public string Documento
        {
            get { return documento; }
            set { this.documento = Documento; }
        }
        public string Lugar_expedicion
        {
            get { return lugar_expedicion; }
            set { this.lugar_expedicion = Lugar_expedicion; }
        }
        public string Genero
        {
            get { return genero; }
            set { this.genero = Genero; }
        }
        public string Primer_nombre
        {
            get { return primer_nombre; }
            set { this.primer_nombre = Primer_nombre; }
        }
        public string Segundo_nombre
        {
            get { return segundo_nombre; }
            set { this.segundo_nombre = Segundo_nombre; }
        }
        public string Primer_apellido
        {
            get { return primer_apellido; }
            set { this.primer_apellido = Primer_apellido; }
        }
        public string Segundo_apellido
        {
            get { return segundo_apellido; }
            set { this.segundo_apellido = Segundo_apellido; }
        }
        public string Estado_civil
        {
            get { return estado_civil; }
            set { this.estado_civil = Estado_civil; }
        }
        public string Pais_origen
        {
            get { return pais_origen; }
            set { this.pais_origen = Pais_origen; }
        }
        public string Dpmt_origen
        {
            get { return dpmt_origen; }
            set { this.dpmt_origen = Dpmt_origen; }
        }
        public string Mpio_origen
        {
            get { return mpio_origen; }
            set { this.mpio_origen = Mpio_origen; }
        }
        public string Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { this.fecha_nacimiento = Fecha_nacimiento; }
        }
        public string Direccion_residencia
        {
            get { return direccion_residencia; }
            set { this.direccion_residencia = Direccion_residencia; }
        }
        public string Barrio
        {
            get { return barrio; }
            set { this.barrio = Barrio; }
        }
        public string Tele_contacto
        {
            get { return tele_contacto; }
            set { this.tele_contacto = Tele_contacto; }
        }
        public string Tele_movil
        {
            get { return tele_movil; }
            set { this.tele_movil = Tele_movil; }
        }
        public string Correo
        {
            get { return correo; }
            set { this.correo = Correo; }
        }
        public string Fecha_registro
        {
            get { return fecha_registro; }
            set { this.fecha_registro = Fecha_registro; }
        }*/

        public string Soli_id { get => soli_id; set => soli_id = value; }
        public string Tipo_documento { get => tipo_documento; set => tipo_documento = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Lugar_expedicion { get => lugar_expedicion; set => lugar_expedicion = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
        public string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
        public string Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
        public string Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
        public string Estado_civil { get => estado_civil; set => estado_civil = value; }
        public string Pais_origen { get => pais_origen; set => pais_origen = value; }
        public string Dpmt_origen { get => dpmt_origen; set => dpmt_origen = value; }
        public string Mpio_origen { get => mpio_origen; set => mpio_origen = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Direccion_residencia { get => direccion_residencia; set => direccion_residencia = value; }
        public string Barrio { get => barrio; set => barrio = value; }
        public string Tele_contacto { get => tele_contacto; set => tele_contacto = value; }
        public string Tele_movil { get => tele_movil; set => tele_movil = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public override string ToString()
        {
            return "Solicitud Id: " + this.Soli_id + " Tipo_documento: " + this.Tipo_documento + " Documento: " + this.Documento + " Lugar_expedicion: " + this.Lugar_expedicion
                + " Genero: " + this.Genero + " Primer_nombre: " + this.Primer_nombre + " Segundo_nombre: " + this.Segundo_nombre + " Primer_apellido: " + this.Primer_apellido
                + " Segundo_apellido: " + this.Segundo_apellido + " Estado_civil: " + this.Estado_civil + " Pais_origen: " + this.Pais_origen + " Dpmt_origen: " + this.Dpmt_origen
                + " Mpio_origen: " + this.Mpio_origen + " Fecha_nacimiento: " + this.Fecha_nacimiento + " Direccion_residencia: " + this.Direccion_residencia + " Barrio: " + this.Barrio
                + " Tele_contacto: " + this.Tele_contacto + " Tele_movil: " + this.Tele_movil + " Correo: " + this.Correo + " Fecha_registro: " + this.Fecha_registro;
        }
    }
}
