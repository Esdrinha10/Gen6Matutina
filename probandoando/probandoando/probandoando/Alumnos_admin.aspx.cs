using probandoando.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace probandoando
{
    public partial class Alumnos_admin : System.Web.UI.Page
    {
        Alumnos alum = new Alumnos();
        Utilitarios util = new Utilitarios();

        bool canInsert;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Session.RemoveAll();
                Response.Redirect("login.aspx");
            }
            else
            {
                canInsert = true;
                lblPrimerNomAst.Visible = false;
                lblSegundoNomAst.Visible = false;
                lblPrimerApeAst.Visible = false;
                lblSegundoApeAst.Visible = false;
                lblNacAst.Visible = false;
                lblGradoAst.Visible = false;
                lblSexoAst.Visible = false;
                lblDepAst.Visible = false;
                lblMunAst.Visible = false;


                btnEditar.Visible = false;
                btnInsert.Visible = true;
                if (!IsPostBack)
                {
                    alum.DdlDepartamentos(ddlDepartamentos);
                    alum.DdlGrados(ddlGrado);
                    ddlMunicipios.Enabled = false;
                    canInsert = true;

                    string id = Session["Id_AlumEditar"].ToString();
                    if (id != "")
                    {
                        cargarDatos(id);
                        btnEditar.Visible = true;
                        btnInsert.Visible = false;
                    }
                    
                }
            }
            
        }

        public void cargarDatos(string id)
        {
            DataSet ds = new DataSet();
            ds = alum.CargarDatos(id);

            txtPrimerNombre.Value = ds.Tables["T"].Rows[0]["alum_PrimerNombre"].ToString();
            txtSegundoNombre.Value = ds.Tables["T"].Rows[0]["alum_SegundoNombre"].ToString();

            ddlGrado.SelectedValue = ds.Tables["T"].Rows[0]["grd_Id"].ToString();

           

            ddlMunicipios.Enabled = true;
            alum.DdlMunicipios(ddlMunicipios, "01");
            ddlMunicipios.SelectedValue = ds.Tables["T"].Rows[0]["mun_Id"].ToString();

        }
        protected void ddlDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlMunicipios.Enabled = true;
            alum.DdlMunicipios(ddlMunicipios, ddlDepartamentos.SelectedValue);
        }

        protected void btnInsert_ServerClick(object sender, EventArgs e)
        {

            if(txtPrimerNombre.Value == "")
            {
                lblPrimerNomAst.Visible = true;
                canInsert = false;
            }

            if (txtPrimerApellido.Value == "")
            {
                lblPrimerApeAst.Visible = true;
                canInsert = false;
            }

            if (txtNacimiento.Value == "")
            {
                lblNacAst.Visible = true;
                canInsert = false;
            }

            if (ddlGrado.SelectedValue == "0")
            {
                lblGradoAst.Visible = true;
                canInsert = false;
            }

            if (!rbM.Checked && !rbF.Checked)
            {
                lblSexoAst.Visible = true;
                canInsert = false;
            }

            if (ddlDepartamentos.SelectedValue == "0")
            {
                lblDepAst.Visible = true;
                canInsert = false;
            }

            if (ddlMunicipios.SelectedValue == "0")
            {
                lblMunAst.Visible = true;
                canInsert = false;
            }

            if (canInsert)
            {
                string sexo;
                if (rbM.Checked)
                    sexo = rbM.Value;
                else
                    sexo = rbF.Value;

                DataSet ds = new DataSet();
                util.ObtenerDS("EXEC UDP_tbAlumnos_Insert '" + txtPrimerNombre.Value + "', '" + txtSegundoNombre.Value + "'," +
                    " '" + txtPrimerApellido.Value + "', '" + txtSegundoApellido.Value + "', '" + txtNacimiento.Value + "', '" + ddlGrado.SelectedValue + "', '" + sexo + "', '" + ddlMunicipios.SelectedValue + "', '" + Session["Usuario"] + "'", "T");

                Response.Redirect("Alumnos_admin.aspx");
            }
        }

        protected void btnCancelar_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Alumnos_admin.aspx");
        }
    }
}