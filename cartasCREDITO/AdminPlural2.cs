using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace cartasCREDITO
{
    class AdminPlural2
    {
        public static int actualizar(Plural2 c)
        {
            int res = 0;
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                con.Open();
                using (SQLiteTransaction tr = con.BeginTransaction())
                {
                    using (SQLiteCommand comando = new SQLiteCommand())
                    {
                        comando.Transaction = tr;
                        comando.CommandText = string.Format("update plural2 set meses='{0}',anio='{1}',pie='{2}',asesor='{3}',cantidad='{4}',cantidadL='{5}',fecha='{6}' where id={7}",
                        c.meses, c.anio, c.pie, c.asesor, c.cantidad, c.cantidadL, string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(c.fecha)), c.id);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static int registrar(Plural2 c)
        {
            int res = 0;
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                con.Open();
                using (SQLiteTransaction tr = con.BeginTransaction())
                {
                    using (SQLiteCommand comando = new SQLiteCommand())
                    {
                        comando.Transaction = tr;
                        comando.CommandText = string.Format("insert into plural2 values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                        c.meses, c.anio, c.pie, c.asesor, c.cantidad, c.cantidadL, string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(c.fecha)), c.id, c.idCliente);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static int eliminar(string id)
        {
            int res = 0;
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                con.Open();
                using (SQLiteTransaction tr = con.BeginTransaction())
                {
                    using (SQLiteCommand comando = new SQLiteCommand())
                    {
                        comando.Transaction = tr;
                        comando.CommandText = string.Format("delete from plural2 where id='{0}'", id);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static DataTable buscaPlural2()
        {
            DataTable tabla = new dataCredito.sing2DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select * from plural2";
                    comando.Connection = con;
                    con.Open();
                    SQLiteDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        DataRow fila = tabla.NewRow();
                        fila["encabezado"] = lector.GetString(0);
                        fila["saludo"] = lector.GetString(1);
                        fila["meses"] = lector.GetString(2);
                        fila["anio"] = lector.GetInt32(3);
                        fila["pie"] = lector.GetString(4);
                        fila["asesor"] = lector.GetString(5);
                        fila["cantidad"] = lector.GetString(6);
                        fila["cantidadL"] = lector.GetString(7);
                        fila["fecha"] = lector.GetDateTime(8);
                        fila["id"] = lector.GetString(9);
                        fila["idCliente"] = lector.GetInt32(10);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static DataTable buscaDatosPlural2()
        {
            DataTable tabla = new dataCredito.datosSing2DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select * from datosPlural2";
                    comando.Connection = con;
                    con.Open();
                    SQLiteDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        DataRow fila = tabla.NewRow();
                        fila["nombre"] = lector.GetString(0);
                        fila["direccion"] = lector.GetString(1);
                        fila["direccion2"] = lector.GetString(2);
                        fila["ciudad"] = lector.GetString(3);
                        fila["id"] = lector.GetString(4);
                        fila["idCliente"] = lector.GetInt32(5);
                        fila["anio"] = lector.GetInt32(6);
                        fila["asesor"] = lector.GetString(7);
                        fila["cantidad"] = lector.GetString(8);
                        fila["cantidadL"] = lector.GetString(9);
                        fila["fecha"] = lector.GetDateTime(10);
                        fila["meses"] = lector.GetString(11);
                        fila["pie"] = lector.GetString(12);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static int totalPlural2()
        {
            int total = 0;
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select count(*) from plural2";
                    comando.Connection = con;
                    con.Open();
                    SQLiteDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        total = lector.GetInt32(0);
                    }
                }
                con.Close();
            }
            return (total);
        }
        public static DataTable consulta(string nombre)
        {
            DataTable tabla = new dataCredito.datosSing2DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = string.Format("select * from datosPlural2 where nombre like '%{0}%' ", nombre);
                    comando.Connection = con;
                    con.Open();
                    SQLiteDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        DataRow fila = tabla.NewRow();
                        fila["nombre"] = lector.GetString(0);
                        fila["direccion"] = lector.GetString(1);
                        fila["direccion2"] = lector.GetString(2);
                        fila["ciudad"] = lector.GetString(3);
                        fila["id"] = lector.GetString(4);
                        fila["idCliente"] = lector.GetInt32(5);
                        fila["anio"] = lector.GetInt32(6);
                        fila["asesor"] = lector.GetString(7);
                        fila["cantidad"] = lector.GetString(8);
                        fila["cantidadL"] = lector.GetString(9);
                        fila["fecha"] = lector.GetDateTime(10);
                        fila["meses"] = lector.GetString(11);
                        fila["pie"] = lector.GetString(12);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static DataTable consultaPorId(string id)
        {
            DataTable tabla = new dataCredito.datosSing2DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = string.Format("select * from datosPlural2 where id='{0}' ", id);
                    comando.Connection = con;
                    con.Open();
                    SQLiteDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        DataRow fila = tabla.NewRow();
                        fila["nombre"] = lector.GetString(0);
                        fila["direccion"] = lector.GetString(1);
                        fila["direccion2"] = lector.GetString(2);
                        fila["ciudad"] = lector.GetString(3);
                        fila["id"] = lector.GetString(4);
                        fila["idCliente"] = lector.GetInt32(5);
                        fila["anio"] = lector.GetInt32(6);
                        fila["asesor"] = lector.GetString(7);
                        fila["cantidad"] = lector.GetString(8);
                        fila["cantidadL"] = lector.GetString(9);
                        fila["fecha"] = lector.GetDateTime(10);
                        fila["meses"] = lector.GetString(11);
                        fila["pie"] = lector.GetString(12);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static DataTable consulta2(string nombre)
        {
            DataTable tabla = new dataCredito.datosSing2DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = string.Format("select * from datosPlural22 where nombre like '%{0}%' ", nombre);
                    comando.Connection = con;
                    con.Open();
                    SQLiteDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        DataRow fila = tabla.NewRow();
                        fila["nombre"] = lector.GetString(0);
                        fila["direccion"] = lector.GetString(1);
                        fila["direccion2"] = lector.GetString(2);
                        fila["ciudad"] = lector.GetString(3);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
    }
}
