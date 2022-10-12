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
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbConfirmarEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LbContraseña" runat="server" Text="Contraseña"></asp:Label>
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
    </form>
</body>
</html>
