using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace cartasCREDITO
{
    class AdminSing5
    {
        public static int actualizar(Sing5 c)
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
                        comando.CommandText = string.Format("update sing5 set encabezado='{0}',saludo='{1}',pie='{2}',asesor='{3}',cantidad='{4}',fecha='{5}' where id={6}",
                        c.encabezado, c.saludo, c.pie, c.asesor,c.cantidad,string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(c.fecha)), c.id);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static int registrar(Sing5 c)
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
                        comando.CommandText = string.Format("insert into sing5 values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                        c.encabezado, c.saludo, c.pie, c.asesor,c.cantidad, string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(c.fecha)), c.id, c.idCliente);
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
                        comando.CommandText = string.Format("delete from sing5 where id='{0}'", id);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static DataTable buscaSing5()
        {
            DataTable tabla = new dataCredito.sing5DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select * from sing5";
                    comando.Connection = con;
                    con.Open();
                    SQLiteDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        DataRow fila = tabla.NewRow();
                        fila["encabezado"] = lector.GetString(0);
                        fila["saludo"] = lector.GetString(1);
                        fila["pie"] = lector.GetString(2);
                        fila["asesor"] = lector.GetString(3);
                        fila["cantidad"] = lector.GetString(4);
                        fila["fecha"] = lector.GetDateTime(5);
                        fila["id"] = lector.GetString(6);
                        fila["idCliente"] = lector.GetInt32(7);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static DataTable buscaDatosSing5()
        {
            DataTable tabla = new dataCredito.datosSing5DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select * from datosSing5";
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
                        fila["cantidad"] = lector.GetString(7);
                        fila["encabezado"] = lector.GetString(8);
                        fila["fecha"] = lector.GetDateTime(9);
                        fila["pie"] = lector.GetString(10);
                        fila["saludo"] = lector.GetString(11);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static int totalSing5()
        {
            int total = 0;
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select count(*) from sing5";
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
        public static DataTable consultaPorId(string id)
        {
            DataTable tabla = new dataCredito.datosSing2DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = string.Format("select * from datosSing5 where id='{0}' ", id);
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
                        fila["cantidad"] = lector.GetString(7);
                        fila["encabezado"] = lector.GetString(8);
                        fila["fecha"] = lector.GetDateTime(9);
                        fila["pie"] = lector.GetString(10);
                        fila["saludo"] = lector.GetString(11);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static DataTable consulta(string nombre)
        {
            DataTable tabla = new dataCredito.datosSing2DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = string.Format("select * from datosSing5 where nombre like '%{0}%' ", nombre);
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
                        fila["cantidad"] = lector.GetString(7);
                        fila["encabezado"] = lector.GetString(8);
                        fila["fecha"] = lector.GetDateTime(9);
                        fila["pie"] = lector.GetString(10);
                        fila["saludo"] = lector.GetString(11);
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
                    comando.CommandText = string.Format("select * from datosSing55 where nombre like '%{0}%' ", nombre);
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
