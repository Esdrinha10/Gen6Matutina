<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos_index.aspx.cs" Inherits="probandoando.Alumnos_index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div class="row">
            <div class="col-7">
                <input type="button" runat="server" id="btnNuevo" value="Nuevo" onserverclick="btnNuevo_ServerClick" class="btn btn-success"/>
       
            </div>
            <div class="col-4">
                <input type="text" runat="server" id="txtBusqueda" class="form-control"/>
            </div>
            <input type="button" runat="server" id="btnBuscar" value="Buscar" onserverclick="btnBuscar_ServerClick" class="btn btn-primary"/>
        </div>
    </div>
    <br />


        <asp:GridView ID="gvAlumnos" runat="server" AllowPaging="true" AutoGenerateColumns="false" OnPageIndexChanging="gvAlumnos_PageIndexChanging" CssClass="table table-striped">
           
               <headerstyle backcolor="Black"
                forecolor="White"/>
            <Columns>

               <asp:BoundField DataField="alum_Id" HeaderText="Id Alumno" />
               <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
               <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
               <asp:BoundField DataField="Edad" HeaderText="Edad" />
               <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                <asp:TemplateField HeaderText="Editar">
                    <ItemTemplate>
                        <a class="fa fa-pencil btn btn-warning shiny" style="color:black" onclick="Editar('<%# Eval("alum_Id")%>')">Editar</a>
                    </ItemTemplate>
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Eliminar">
                   <ItemTemplate>
                        <a class="fa fa-trash btn btn-danger shiny" style="color:black"   onclick="Eliminar('<%# Eval("alum_Id")%>')">Eliminar</a>
                    </ItemTemplate>
                    
                </asp:TemplateField>

                 

           </Columns>
       </asp:GridView>
   
</asp:Content>
