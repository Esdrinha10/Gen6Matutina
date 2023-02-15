<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos_admin.aspx.cs" Inherits="probandoando.Alumnos_admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container">
        <div class="row">
            <div class="col-1"></div>
            <div class="col-10">
                <div class="card">
                    <div class="card-header">Alumnos</div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-6">
                                <label>Primer Nombre:</label>
                                <label style="color: red" id="lblPrimerNomAst" runat="server">*</label>
                                <input type="text" runat="server" id="txtPrimerNombre" class="form-control" required="required"/>
                            </div>
                            <div class="col-6">
                                <label>Segundo Nombre:</label>
                                <label style="color: red" id="lblSegundoNomAst" runat="server">*</label>
                                <input type="text" runat="server" id="txtSegundoNombre" class="form-control" />
                            </div>
                            <div class="col-6 mt-3">
                                <label>Primer Apellido:</label>
                                <label style="color: red" id="lblPrimerApeAst" runat="server">*</label>
                                <input type="text" runat="server" id="txtPrimerApellido" class="form-control" required="required"/>
                            </div>
                            <div class="col-6 mt-3">
                                <label>Segundo Apellido:</label>
                                <label style="color: red" id="lblSegundoApeAst" runat="server">*</label>
                                <input type="text" runat="server" id="txtSegundoApellido" class="form-control" />
                            </div>
                            <div class="col-6 mt-3">
                                <label>Fecha de Nacimiento:</label>
                                <label style="color: red" id="lblNacAst" runat="server">*</label>
                                <input type="date" runat="server" id="txtNacimiento" class="form-control" required="required"/>
                            </div>
                            <div class="col-6 mt-3">
                                <label>Grado:</label>
                                <label style="color: red" id="lblGradoAst" runat="server">*</label>
                                <asp:DropDownList id="ddlGrado" CssClass="form-control" runat="server">

                                </asp:DropDownList>
                            </div>
                            <div class="col-6 mt-3">
                                <label>Sexo:</label>
                                <label style="color: red" id="lblSexoAst" runat="server">*</label>
                                <br />
                                <input type="radio" runat="server" id="rbF" name="rbSexo" class="mt-2" value="F"/> F    
                                <input type="radio" runat="server" id="rbM" name="rbSexo" class="mt-2" value="M"/> M
                            </div>
                            <div class="col-6 mt-3">
                                <label>Departamento:</label>
                                <label style="color: red" id="lblDepAst" runat="server">*</label>
                                <asp:DropDownList id="ddlDepartamentos" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDepartamentos_SelectedIndexChanged">

                                </asp:DropDownList>
                            </div>
                            <div class="col-6 mt-3">
                                <label>Municipio:</label>
                                <label style="color: red" id="lblMunAst" runat="server">*</label>
                                <asp:DropDownList id="ddlMunicipios" CssClass="form-control" runat="server">

                                </asp:DropDownList>
                            </div>
                        </div>
                        <input type="button" class="btn btn-primary mt-3" runat="server" id="btnInsert" value="Agregar" onserverclick="btnInsert_ServerClick"/>
                          <input type="button" class="btn btn-warning mt-3" runat="server" id="btnEditar" value="Editar" />
                        <input type="button" class="btn btn-danger mt-3" runat="server" id="btnCancelar" value="Cancelar" onserverclick="btnCancelar_ServerClick"/>
                    </div>
                </div> 
            </div>

        </div>
    </div>
</asp:Content>
