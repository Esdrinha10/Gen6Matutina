using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace probandoando.Clases
{
    public class cnxBaseDeDatos
    {
        SqlConnection cnx = new SqlConnection();
        string con = "";

        public void Conexion()
        {
            con = @"data source = DESKTOP-D91QQLL\SQLEXPRESS; initial catalog = Escuela; user id = ECERNA; password = ECERNA";
            cnx.ConnectionString = con;
        }

        public SqlConnection ObtenerCnx()
        {
            Conexion();
            return cnx;
        }
    }
}