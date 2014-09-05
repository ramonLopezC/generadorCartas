using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace cartasCREDITO
{
    class AdminSing1
    {
        public static int actualizar(Sing2 c)
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
                        comando.CommandText = string.Format("update sing1 set encabezado='{0}',saludo='{1}',meses='{2}',anio='{3}',pie='{4}',asesor='{5}',cantidad='{6}',cantidadL='{7}',fecha='{8}' where id={9}",
                        c.encabezado, c.saludo, c.meses, c.anio, c.pie, c.asesor, c.cantidad, c.cantidadL, string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(c.fecha)), c.id);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static int registrar(Sing2 c)
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
                        comando.CommandText = string.Format("insert into sing1 values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                        c.encabezado, c.saludo, c.meses, c.anio, c.pie, c.asesor, c.cantidad, c.cantidadL, string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(c.fecha)), c.id, c.idCliente);
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
                        comando.CommandText = string.Format("delete from sing1 where id='{0}'", id);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static DataTable buscaSing1()
        {
            DataTable tabla = new dataCredito.sing2DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select * from sing1";
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
        public static DataTable buscaDatosSing1()
        {
            DataTable tabla = new dataCredito.datosSing2DataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select * from datosSing1";
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
                        fila["encabezado"] = lector.GetString(10);
                        fila["fecha"] = lector.GetDateTime(11);
                        fila["meses"] = lector.GetString(12);
                        fila["pie"] = lector.GetString(13);
                        fila["saludo"] = lector.GetString(14);
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
                    comando.CommandText = string.Format("select * from datosSing1 where nombre like '%{0}%' ",nombre);
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
                        fila["encabezado"] = lector.GetString(10);
                        fila["fecha"] = lector.GetDateTime(11);
                        fila["meses"] = lector.GetString(12);
                        fila["pie"] = lector.GetString(13);
                        fila["saludo"] = lector.GetString(14);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static int totalSing1()
        {
            int total = 0;
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select count(*) from sing1";
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
                    comando.CommandText = string.Format("select * from datosSing1 where id='{0}' ", id);
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
                        fila["encabezado"] = lector.GetString(10);
                        fila["fecha"] = lector.GetDateTime(11);
                        fila["meses"] = lector.GetString(12);
                        fila["pie"] = lector.GetString(13);
                        fila["saludo"] = lector.GetString(14);
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
                    comando.CommandText = string.Format("select * from datosSing11 where nombre like '%{0}%' ", nombre);
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
