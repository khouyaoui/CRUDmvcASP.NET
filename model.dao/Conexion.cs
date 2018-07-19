using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.dao
{
    public class Conexion
    {
        //implementatndo singleton
        private static Conexion objConexion = null;
        private SqlConnection con;

        private Conexion()
        {
            con = new SqlConnection(recursodao.conexion);

        }
        public static Conexion saberEstado()
        {
            if (objConexion == null)
            {
                objConexion = new Conexion();
            }
            return objConexion;
        }
        public SqlConnection getCon()
        {
            return con;
        }
        public void cerrarConexion()
        {
            objConexion = null;
        }
    }
}
