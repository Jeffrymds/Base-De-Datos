using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Estudiante
{
    class conexionesdb
    {

        public string cadenaconexion = ConfigurationManager.ConnectionStrings["conexiones"].ConnectionString.ToString();

        public void conectar(string sql)
        {
            SqlConnection cnx = new SqlConnection(cadenaconexion);
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();

            }
            else
            {
                cnx.Open();
            }

            SqlCommand command = new SqlCommand(sql,cnx);
             command.ExecuteNonQuery();

        }

        public DataTable Consulta(string sql)
        {
            DataTable tbresul = new DataTable();
            SqlConnection cnx = new SqlConnection(cadenaconexion);
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();

            }
            else
            {
                cnx.Open();
            }

            SqlDataAdapter command = new SqlDataAdapter(sql, cnx);
            command.Fill(tbresul);
            return tbresul;

        }

    }
}
