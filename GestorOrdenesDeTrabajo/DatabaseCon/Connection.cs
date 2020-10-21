using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorOrdenesDeTrabajo.DatabaseCon
{
    class Connection
    {
        string Cadena;
        protected SqlConnection connection = new SqlConnection();

        //public Conexion()
        //{
        //    Cadena = "Data Source=192.168.1.234\\SQLEXPRESS;Initial Catalog=BD_Restaurante; User id = 'BD_Owner'; Password = '123'";
        //    con.ConnectionString = Cadena;
        //}

        protected Connection()
        {
            Cadena = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=Prueba; Integrated Security=True";
            connection.ConnectionString = Cadena;
        }

        protected bool Open()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexion abierta");
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error en conexion con el/la servidor/base de datos \n" + ex.Message);
                return false;
            }
        }

        protected void Close()
        {
            connection.Close();
            Console.WriteLine("Conexion cerrada");
        }
    }
}
