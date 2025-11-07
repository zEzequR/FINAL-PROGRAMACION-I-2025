using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROGRAMACIÓN_I.Utilidades
{
    internal class Conexion
    {
        private static string strConn = "Data Source=EZE\\SQLEXPRESS;Initial Catalog=Comercio;User ID=sa;Password=45505886";
        private static SqlConnection connection = new SqlConnection(strConn);
        private SqlCommand cmd = new SqlCommand();

        public SqlConnection Connect()
        {
            if (Conexion.connection.State == ConnectionState.Open)
            {
                return Conexion.connection;
            }

            try
            {
                Conexion.connection.Open();
                cmd.Connection = connection;
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
