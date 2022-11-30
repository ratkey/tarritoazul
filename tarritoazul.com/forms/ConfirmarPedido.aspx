<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ConfirmarPedido.aspx.cs" Inherits="tarritoazul.com.ConfirmarPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <table style="text-align:center" aling="center" border="1">
        <tr>
            <td style="width: 350px;">
                <%--Td de relleno para centrar la tabla pq no se--%>
            </td>
            </tr>
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
                <asp:Label ID="LbPrecio" runat="server" Text="Total $(100 peso)"></asp:Label>
                <h5>Domicilio:</h5>
                <asp:Label ID="LbCP" runat="server" Text="Codigo Postal: (11111)"></asp:Label>
                <br /><br />
                <asp:Label ID="LbColonia" runat="server" Text="Colonia: (colonia1)"></asp:Label>
                <asp:Label ID="LbCalle" runat="server" Text=", Calle: (calle0)"></asp:Label>
                <asp:Label ID="LbExt" runat="server" Text=", Num. Exterior: (15)"></asp:Label>
                <br /><br />

                <h5>Entre calles</h5>
                <asp:Label ID="LbCalle1" runat="server" Text=" Calle 1: "></asp:Label>
                <asp:Label ID="LbCalle2" runat="server" Text=", Calle 2: "></asp:Label>
                <br /><br />
                <asp:Label ID="LbDescripcionDomicilio" runat="server" Text="Descripción del domicilio (Casa azul con 27 ventanas) "></asp:Label>                
                <br /><br />
                <asp:Label ID="LbMunicipio" runat="server" Text="Municipio"></asp:Label>
                <asp:Label ID="LbEstado" runat="server" Text=", Estado "></asp:Label>
                <br /><br />
                <h5>Cliente</h5>
                <asp:Label ID="LbNombreCliente" runat="server" Text="Nombre del cliente"></asp:Label>
                
                <asp:Label ID="LbTelefono" runat="server" Text=", Telefono "></asp:Label>
                <br /><br /> 
                <asp:Button ID="BtnComprar" runat="server" Text="Comprar" CssClass="btn btn-solid-green" />
                <br /><br />
              
            </td>
        </tr>
       
    </table>
</asp:Content>
