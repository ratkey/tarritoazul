<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="tarritoazul.com.forms.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../styles/login.css" />
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="login_box">
        <div class="logo_fondo">
            <img class="form_logo" src="../imgs/logo.png" />
        </div>
        <br />

        <t1>Iniciar sesión</t1>
        <br />
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="LbUsuario" runat="server" Text="Usuario:"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LbContrasenia" runat="server" Text="Contraseña:"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbContrasenia" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="BtLogin" runat="server" Text="Iniciar sesión" CssClass="btn btn-primario" />
        <br />
        <p style="font-size: 12pt;">
            ¿Aún no tienes una cuenta?
            <asp:HyperLink ID="linkIniciarSecionForm" runat="server" NavigateUrl="~/forms/registro.aspx">Regístrate aquí</asp:HyperLink>
        </p>
    </div>
</asp:Content>
