<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="tarritoazul.com.PerfilUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../styles/perfil.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <table style="text-align: center" aling="center">
        <tr>
            <td style="width: 350px;">
                <%--Td de relleno para centrar la tabla pq no se--%>
            </td>
            <tr>
                <%--td de la imagen--%>
                <td style="max-width: 200px;">
                    <asp:Image ID="imgPerfil" runat="server" ImageUrl="~/imgs/producto/placeholder.jpg" CssClass="imgPerfil" />
                    <br />
                    <asp:FileUpload ID="fileUp" runat="server" />
                    <asp:Button ID="btnSubirimg" runat="server" Text="Subir" CssClass="btn btn-primario" OnClick="btnSubirimg_Click" />
                    <br />

                </td>

                <%--td de los labels y botones--%>
                <td>
                    <p>Nombre:</p>
                    <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>

                    <p>Apellido paterno:</p>
                    <asp:Label ID="lbApPaterno" runat="server" Text="Apellido1"></asp:Label>

                    <p>Apellido materno:</p>
                    <asp:Label ID="lbApMaterno" runat="server" Text="Apellido2"></asp:Label>

                    <p>Fecha de nacimiento:</p>
                    <asp:Label ID="lbNacimiento" runat="server" Text="Fecha de nacer"></asp:Label>

                    <p>Telefono:</p>
                    <asp:Label ID="lbTelefono" runat="server" Text="Fecha de telefono"></asp:Label>
                    <br />
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-primario" PostBackUrl="~/forms/addUsuario.aspx?update=true" />
                    <br />
                    <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesion" CssClass="btn btn-peligro" Width="131" CausesValidation="False" OnClick="btnCerrarSesion_Click" />
                </td>
            </tr>
    </table>



</asp:Content>

