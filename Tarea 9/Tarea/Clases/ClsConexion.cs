using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tarea.Clases
{
    public class ClsConexion
    {
        Conexion Conectionc = new Conexion();

        public DataTable MostrarDatos()
        {
            SqlDataAdapter datosU = new SqlDataAdapter("SP_MOSTRARtb_alumnos",Conectionc.LeerCadena());
            datosU.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            datosU.Fill(dt);
            return dt;
        }

    }
}
