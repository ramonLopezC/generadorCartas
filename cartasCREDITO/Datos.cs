using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using System.IO;


namespace cartasCREDITO
{
    class Datos
    {        
        public static bool res { get; set; }
        public static int fila { get; set; }
        public static DataTable sing1 { get; set; }
        public static DataTable sing2 { get; set; }
        public static DataTable sing3 { get; set; }
        public static DataTable sing4 { get; set; }
        public static DataTable sing5 { get; set; }
        public static DataTable cartaSing2 { get; set; }
        public static DataTable clientes { get; set; }
        public static DataTable datosSing1 { get; set; }
        public static DataTable datosSing2 { get; set; }
        public static DataTable datosSing3 { get; set; }
        public static DataTable datosSing4 { get; set; }
        public static DataTable datosSing5 { get; set; }
        public static DataTable datosPlural1 { get; set; }
        public static DataTable datosPlural2 { get; set; }
        public static DataTable datosPlural3 { get; set; }
        public static DataTable datosPlural4 { get; set; }
        public static DataTable datosPlural5 { get; set; }
        public static DataTable plural1 { get; set; }
        public static DataTable plural2 { get; set; }
        public static DataTable plural3 { get; set; }
        public static DataTable plural4 { get; set; }
        public static DataTable plural5 { get; set; }
        public static DataTable bCliente { get; set; }
        public static DataTable bSing { get; set; }
        public static string rutaControl = Directory.GetCurrentDirectory() + @"\control.xml";
        public static string rutaBD()
        {
            XElement codigoxml = XElement.Load(rutaControl);
            string ruta = codigoxml.Attribute("ruta").Value;
            return (ruta);
        }
        public static string conexion = @"Data Source=credito.db;";
    }
}
