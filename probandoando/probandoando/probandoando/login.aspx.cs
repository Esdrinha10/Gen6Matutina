using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace probandoando
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.RemoveAll();
            lblUsuAst.Visible = false;
            lblPassAst.Visible = false;
        }

        Clases.Utilitarios util = new Clases.Utilitarios();
        protected void btnLogin_ServerClick(object sender, EventArgs e)
        {
            if (txtUsuario.Value != "" && txtPass.Value != "")
            {
                DataSet ds = new DataSet();

                ds = util.ObtenerDS("EXEC UDP_tbUsuarios_EncriptacionPassword '" + txtUsuario.Value + "', '" + txtPass.Value + "'", "T");

                if(ds.Tables["T"].Rows.Count == 1)
                {
                    Session["Usuario"] = ds.Tables["T"].Rows[0]["usu_Nombre"].ToString();

                    //string nombre = Session["Usuario"];

                    Response.Redirect("Inicio.aspx");
                }
            }
            else
            {
                if (txtUsuario.Value == "")
                {
                    lblUsuAst.Visible = true;
                }

                if (txtPass.Value == "")
                {
                    lblPassAst.Visible = true;
                }
            }
        }
    }
}