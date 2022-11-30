<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="tarritoazul.com.forms.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../styles/formulario.css" />
    <link rel="stylesheet" href="../styles/login.css" />
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="formulario">
        <div class="seccion-narrow">
            <div class="logo_fondo">
                <img class="form_logo" src="../imgs/logosmall_nobg.png" />
            </div>

            <h1 class="titulo">Iniciar sesión</h1>
            <table>
                <tr>
                    <td>
                        <span class="txt">Usuario:</span>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TbUsuario" ErrorMessage="El campo Usuario es obligatorio" CssClass="error" Text="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TbUsuario" runat="server" CssClass="input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="txt">Contraseña:</span>
                        <asp:RequiredFieldValidator ID="RfvUsuario" runat="server" ControlToValidate="TbContrasenia" ErrorMessage="El campo Contraseña es obligatorio" CssClass="error" Text="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TbContrasenia" runat="server" TextMode="Password" CssClass="input"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="BtLogin" runat="server" Text="Iniciar sesión" CssClass="btn btn-primario" />
            <p style="font-size: 12pt;" class="centrar">
                ¿Aún no tienes una cuenta?
            <asp:HyperLink ID="linkIniciarSecionForm" runat="server" NavigateUrl="~/forms/registro.aspx">Regístrate aquí</asp:HyperLink>
        </div>
        <asp:ValidationSummary ID="summary" runat="server" CssClass="error"/>
    </div>
</asp:Content>
