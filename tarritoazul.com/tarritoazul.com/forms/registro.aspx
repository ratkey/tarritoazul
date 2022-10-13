<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="tarritoazul.com.forms.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <caption style="width: 123px">
            <t1>
                Crear una cuenta
            </t1>
        </table>
        <table>

            <tr>
                <td>
                    <asp:Label ID="LbNombre" runat="server" Text="Nombre"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredNombre" runat="server" ControlToValidate="TbNombre" CssClass="error" Text="*" ErrorMessage="Nombre es un campo obligatorio 😧"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularNombre" runat="server" ControlToValidate="tbNombre" ValidationExpression="^[A-Za-z\s]*$" CssClass="error" Text="*" ErrorMessage="Nombre solo admite letras 😒"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbNombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LbEmail" runat="server" Text="Email"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" ControlToValidate="TbEmail" CssClass="error" Text="*" ErrorMessage="Email es un campo obligatorio 😧"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LbConfirmarEmail" runat="server" Text="Confirmar Email"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredConfirmarEmail" runat="server" ControlToValidate="TbConfirmarEmail" CssClass="error" Text="*" ErrorMessage="Confirmar Email es un campo obligatorio 😧"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbConfirmarEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LbContrasena" runat="server" Text="Contraseña"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredContrasena" runat="server" ControlToValidate="TbContrasena" CssClass="error" Text="*" ErrorMessage="Contraseña es un campo obligatorio 😧"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbContrasena" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LbConfirmarContraseña" runat="server" Text="Confirmar contraseña"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredConfirmarContrasena" runat="server" ControlToValidate="TbConfirmarContrasena" CssClass="error" Text="*" ErrorMessage="Confirmar contraseña es un campo obligatorio 😧"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbConfirmarContrasena" runat="server"></asp:TextBox>
                </td>
            </tr>

        </table>
        <asp:CheckBox ID="Cbprivacidad" runat="server" Text=" "/> 
        Acepto las <a>Condiciones de uso</a> y el <a>Aviso de privacidad</a><br />
        <asp:Button ID="BtContinuar" runat="server" Text="Continuar" OnClick="BtContinuar_Click" /> <br />
        <p>
            ¿Ya tienes una cuenta? <a>Inicie Sesión</a>
        </p>
        <asp:ValidationSummary ID="summary" runat="server" />
    </form>
</body>
</html>
