<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="tarritoazul.com.forms.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Meta -->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    
    <!-- Links -->
    <link rel="icon" type="image/png" href="../imgs/favicon.ico" />
    <link rel="stylesheet" href="../styles/style.css" />
    <link rel="stylesheet" href="../styles/login.css">

    <title>Login</title>
</head>
<body>
    <div class="login_box">
        <div class="logo_fondo">
            <img class="logo" src="../imgs/logo.png" />
        </div>
        <br />
        <t1>Iniciar sesión</t1>
        <br />
        <br />
        <form id="form1" runat="server">
            <table>
                <tr>
                    <td><asp:Label ID="LbUsuario" runat="server" Text="Usuario:"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TbUsuario" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="LbContrasenia" runat="server" Text="Contraseña:"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TbContrasenia" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br>
            <asp:Button ID="BtLogin" runat="server" Text="Iniciar sesión" />
            <br>
        </form>
    </div>
    
</body>
</html>
