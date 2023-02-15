using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace probandoando
{
    public partial class Alumnos_index : System.Web.UI.Page
    {
        Alumnos alum = new Alumnos();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Id_AlumEditar"] = "";
            if (Session["Usuario"] == null)
            {
                Session.RemoveAll();
                Response.Redirect("login.aspx");
            }

            if (!IsPostBack)
            {
                alum.CargarGrid(gvAlumnos, txtBusqueda.Value);
            }
            else
            {
                string eventtarget = Request["__EVENTTARGET"];
                string eventargument = Request["__EVENTARGUMENT"];

                if (eventtarget == "Editar")
                {
                    Editar(eventargument);

                }
            }




        }

        public void Editar(string id)
        {
            Session["Id_AlumEditar"] = id;
            Response.Redirect("Alumnos_admin.aspx");
        }

        protected void btnBuscar_ServerClick(object sender, EventArgs e)
        {

        }

        protected void gvAlumnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAlumnos.PageIndex = e.NewPageIndex;
            alum.CargarGrid(gvAlumnos, txtBusqueda.Value);
        }

        protected void btnNuevo_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Alumnos_admin.aspx");
        }
    }
}