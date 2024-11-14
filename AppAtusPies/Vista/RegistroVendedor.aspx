<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/MaestraAdmin.Master" AutoEventWireup="true" CodeBehind="RegistroVendedor.aspx.cs" Inherits="AppAtusPies.Vista.RegistroVendedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/FormRegistro.css" rel="stylesheet" />
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/sweetalert2@11/dist/sweetalert2.min.css">
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
   <br/><br/><br/>
    <h3 style="color:black">Registrar Nuevo Vendedor</h3>
    <form id="formRegistrarVendedor" runat="server"><br/>
    <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre del Vendedor"></asp:TextBox><br/><br/>
    <asp:TextBox ID="txtDocumento" runat="server" placeholder="Documento del Vendedor"></asp:TextBox><br/><br/>
    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email del Vendedor"></asp:TextBox><br/><br/>
    <asp:TextBox ID="txtTelefono" runat="server" placeholder="Telefono del Vendedor"></asp:TextBox><br/><br/> 
        <asp:DropDownList ID="dllEstado" runat="server">
            <asp:ListItem>Activo</asp:ListItem>


        </asp:DropDownList>
     <div class="form-group">
     <asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
 </div>
    <asp:Button ID="btnRegistrar" class="buttons" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" /> <br /><br />

    </form>
</asp:Content>