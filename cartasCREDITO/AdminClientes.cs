using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace cartasCREDITO
{
    class AdminClientes
    {
        public static int actualizar(Clientes c)
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
                        comando.CommandText = string.Format("update clientes set nombre='{0}',direccion='{1}',direccion2='{2}',ciudad='{3}' where id={4}",
                        c.nombre,c.direccion,c.direccion2,c.ciudad,c.id);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static int registrar(Clientes c)
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
                        comando.CommandText = string.Format("insert into clientes values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                        c.id,c.fecha,c.nombre,c.direccion,c.direccion2,c.ciudad,c.tipo);
                        res = comando.ExecuteNonQuery();
                        tr.Commit();
                    }
                }
                con.Close();
            }
            return (res);
        }
        public static List<Clientes> buscaClientes()
        {
            List<Clientes> tabla = new List<Clientes>();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select * from clientes";
                    comando.Connection = con;
                    con.Open();
                    SQLiteDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Clientes fila = new Clientes();
                        fila.id = lector.GetInt32(0);
                        fila.fecha = lector.GetString(1);
                        fila.nombre = lector.GetString(2);
                        fila.direccion = lector.GetString(3);
                        fila.direccion2= lector.GetString(4);
                        fila.ciudad = lector.GetString(5);
                        fila.tipo = lector.GetString(6);
                        tabla.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static DataTable buscaClientes1()
        {
            DataTable tabla = new dataCredito.clientesDataTable();
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select * from clientes";
                    comando.Connection = con;
                    con.Open();
                    SQLiteDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        DataRow fila = tabla.NewRow();
                        fila["id"] = lector.GetInt32(0);
                        fila["fecha"] = lector.GetString(1);
                        fila["nombre"] = lector.GetString(2);
                        fila["direccion"] = lector.GetString(3);
                        fila["direccion2"] = lector.GetString(4);
                        fila["ciudad"] = lector.GetString(5);
                        fila["tipo"] = lector.GetString(6);
                        tabla.Rows.Add(fila);
                    }
                }
                con.Close();
            }
            return (tabla);
        }
        public static int totalClientes()
        {
            int total = 0;
            using (SQLiteConnection con = new SQLiteConnection(Datos.conexion))
            {
                using (SQLiteCommand comando = new SQLiteCommand())
                {
                    comando.CommandText = "select count(*) from clientes";
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
    }

}
