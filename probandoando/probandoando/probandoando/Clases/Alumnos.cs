using probandoando.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace probandoando
{
    public class Alumnos
    {
        Utilitarios util = new Utilitarios();

        public void CargarGrid(GridView gv, string busqueda)
        {
            DataSet ds = util.ObtenerDS("EXEC UDP_Alumnos_Buscar '" + busqueda + "'", "T");
            gv.DataSource = ds.Tables["T"];
            gv.DataBind();
        }

        public void DdlGrados(DropDownList ddl)
        {
            string sql = "SELECT [grd_Id], [grd_Nombre] FROM [dbo].[tbGrados]";
            util.CargarDdl(sql, null, ddl);
        }

        public void DdlDepartamentos(DropDownList ddl)
        {
            string sql = "SELECT [dep_Id], [dep_Nombre] FROM [dbo].[tbDepartamentos]";
            util.CargarDdl(sql, null, ddl);
        }

        public void DdlMunicipios(DropDownList ddl, string dep)
        {
            string sql = "SELECT [mun_Id], [mun_Nombre] FROM [dbo].[tbMunicipios] WHERE dep_Id = '" + dep + "'";
            util.CargarDdl(sql, null, ddl);
        }

        public DataSet CargarDatos(string id)
        {
            DataSet ds = new DataSet();
            ds = util.ObtenerDS("SELECT * FROM [dbo].[tbAlumnos] WHERE [alum_Id] = " + int.Parse(id), "T");

            return ds;
        }

        //PRUEBA GITHUB
    }
}