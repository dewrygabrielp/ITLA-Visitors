using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static string Cn = Properties.Settings.Default.cn;

        private SqlConnection SqlCon = new SqlConnection(Cn);

        public SqlConnection Abrirconexion()
        {
            if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
            return SqlCon;
        }
        public SqlConnection Cerrarconexion()
        {
            if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            return SqlCon;

        }

    }
}
