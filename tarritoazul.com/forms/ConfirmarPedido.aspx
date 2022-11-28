<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ConfirmarPedido.aspx.cs" Inherits="tarritoazul.com.ConfirmarPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <table style="text-align:center" aling="center" border="1">
        <tr>
            <td style="width: 350px;">
                <%--Td de relleno para centrar la tabla pq no se--%>
            </td>
            <tr>
            <%--td de la imagen--%>
            <td style="max-width: 150px; overflow: hidden;">
                <iframe src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6CYfo7p4XPPIU74i7cBTuirx751i1tnm0Xw5fND8Qad2Y6BYOYdapnDXlcQvFVru9mfA&usqp=CAU" height="250" width="200"> </iframe>
            </td>

            <%--td de los labels y botones--%>
            <td>
                <asp:Label ID="LbNombre" runat="server" Text="Nombre del coso"></asp:Label>
                <br /><br />
                <asp:Label ID="LbDescripcion" runat="server" Text="Descripción del coso"></asp:Label>
                <br /><br />
                <asp:Label ID="LbPrecio" runat="server" Text="Total $"></asp:Label>
             
                <br /><br />
                <asp:Label ID="LbDomicilio" runat="server" Text="Domicilio"></asp:Label>
                <br /><br />
                <asp:Label ID="LbCP" runat="server" Text="Codigo Postal: "></asp:Label>
                <br /><br />
                <asp:Label ID="LbCalle" runat="server" Text="Calle: "></asp:Label>
                <br /><br />
                <asp:Label ID="LbExt" runat="server" Text="Num Exterior: "></asp:Label>
                <br /><br />
                <p>Entre calle</p>
                <asp:Label ID="LbCalle1" runat="server" Text="Calle 1: "></asp:Label>
                <p> y calle</p>
                <asp:Label ID="LbCalle2" runat="server" Text=" Calle 2: "></asp:Label>
                <br /><br />
                <asp:Label ID="LbDescripcionDomicilio" runat="server" Text="Descripción del domicilio: "></asp:Label>
                <br /><br />
                <asp:Label ID="LbColonia" runat="server" Text="Colonia: "></asp:Label>
                <br /><br />
                <asp:Label ID="LbMunicipio" runat="server" Text="Municipio:"></asp:Label>
                <br /><br />
                <asp:Label ID="LbEstado" runat="server" Text="Estado: "></asp:Label>
                <br /><br />
                <asp:Label ID="LbNombreCliente" runat="server" Text="Nombre del cliente: "></asp:Label>
                <br /><br />
                <asp:Label ID="LbTelefono" runat="server" Text="Telefono: "></asp:Label>
                <br /><br /> 
                <asp:Button ID="BtnComprar" runat="server" Text="Comprar" CssClass="btn btn-solid-green" />
                <br /><br />
              
            </td>
        </tr>
        <asp:ValidationSummary 
                              id="Summary" 
                              runat="server"/>
    </table>
</asp:Content>
