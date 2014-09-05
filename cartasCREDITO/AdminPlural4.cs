using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace cartasCREDITO
{
    class AdminPlural4
    {
        public static int actualizar(Plural4 c)
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
                        comando.CommandText = string.Format("update plural4 set pie='{0}',asesor='{1}',fecha='{2}' where id={3}",
                        c.pie, c.asesor,string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(c.fecha)), c.id);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static int registrar(Plural4 c)
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
                        comando.CommandText = string.Format("insert into plural4 values('{0}','{1}','{2}','{3}','{4}')",
                        c.pie, c.asesor,string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(c.fecha)), c.id, c.idCliente);
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
                        comando.CommandText = string.Format("delete from plural4 where id='{0}'", id);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static DataTable buscaPlural4()
        {
            DataTable tabla = new dataCredito.sing5DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select * from plural4";
                    comando.Connection = con;
                    con.Open();
                    SQLiteDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        DataRow fila = tabla.NewRow();
                        fila["pie"] = lector.GetString(0);
                        fila["asesor"] = lector.GetString(1);
                        fila["fecha"] = lector.GetDateTime(2);
                        fila["id"] = lector.GetString(3);
                        fila["idCliente"] = lector.GetInt32(4);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static DataTable buscaDatosPlural4()
        {
            DataTable tabla = new dataCredito.datosSing5DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select * from datosPlural4";
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
                        fila["asesor"] = lector.GetString(6);
                        fila["fecha"] = lector.GetDateTime(7);
                        fila["pie"] = lector.GetString(8);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static int totalPlural4()
        {
            int total = 0;
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select count(*) from plural4";
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
                    comando.CommandText = string.Format("select * from datosPlural4 where nombre like '%{0}%' ", nombre);
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
                        fila["asesor"] = lector.GetString(6);
                        fila["fecha"] = lector.GetDateTime(7);
                        fila["pie"] = lector.GetString(8);
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
                    comando.CommandText = string.Format("select * from datosPlural4 where id='{0}' ", id);
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
                        fila["asesor"] = lector.GetString(6);
                        fila["fecha"] = lector.GetDateTime(7);
                        fila["pie"] = lector.GetString(8);
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
                    comando.CommandText = string.Format("select * from datosPlural44 where nombre like '%{0}%' ", nombre);
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
