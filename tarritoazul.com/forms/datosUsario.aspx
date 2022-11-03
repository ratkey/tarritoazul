<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datosUsario.aspx.cs" Inherits="tarritoazul.com.DatosUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <p>Nombres</p>
                </td>
                <td>
                    <asp:TextBox ID="tbNombres" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="requiredNombres" runat="server" ControlToValidate="tbNombres" ErrorMessage="-El Nombre es campo obligatorio" Text="*"></asp:RequiredFieldValidator><br />
                    <asp:RegularExpressionValidator ID="regularNombres" runat="server" ControlToValidate="tbNombres" ErrorMessage="-El  nombre solo puede contener letras y espacio en blanco" Text="*" ValidationExpression="^[a-zA-Z\s]*$"></asp:RegularExpressionValidator><br 
                </td>
            </tr>

            <tr>
                <td>
                    <p>Apellido Paterno:</p>
                </td>
                <td>
                    <asp:TextBox ID="tbPaterno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <p>Apellido Materno:</p>
                </td>
                <td>
                    <asp:TextBox ID="tbMaterno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>


                <td>
                    <p>Sexo:</p>
                </td>
                <td>
                    <asp:DropDownList ID="ddlSexo" runat="server">
                        <asp:ListItem Value="F">Femenino</asp:ListItem>
                        <asp:ListItem Value="M">Masculino</asp:ListItem>

                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <p>Telefono:</p>
                </td>
                <td>
                    <asp:TextBox ID="tbTelefono" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <p>Fecha de nacimiento:</p>
                </td>
                <td>
                    <asp:TextBox ID="tbFechaDeNac" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
