<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datosUsuario.aspx.cs" Inherits="tarritoazul.com.DatosUsuarios" %>

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
                    <asp:RegularExpressionValidator ID="regularNombres" runat="server" ControlToValidate="tbNombres" ErrorMessage="-El  nombre solo puede contener letras y espacio en blanco" Text="*" ValidationExpression="^[a-zA-Z\s]*$"></asp:RegularExpressionValidator><br />
                </td>
            </tr>

            <tr>
                <td>
                    <p>Apellido Paterno:</p>
                </td>
                <td>
                    <asp:TextBox ID="tbPaterno" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredPaterno" runat="server" ControlToValidate="tbPaterno" ErrorMessage="-El apellido paterno es campo obligatorio" Text="*"></asp:RequiredFieldValidator><br />
                    <asp:RegularExpressionValidator ID="RegPaterno" runat="server" ControlToValidate="tbPaterno" ErrorMessage="-El  apellido paterno solo puede contener letras y espacio en blanco" Text="*" ValidationExpression="^[a-zA-Z\s]*$"></asp:RegularExpressionValidator><br />
                </td>
            </tr>
            <tr>
                <td>
                    <p>Apellido Materno:</p>
                </td>
                <td>
                    <asp:TextBox ID="tbMaterno" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredMaterno" runat="server" ControlToValidate="tbMaterno" ErrorMessage="-El apellido materno es campo obligatorio" Text="*"></asp:RequiredFieldValidator><br />
                    <asp:RegularExpressionValidator ID="RegMaterno" runat="server" ControlToValidate="tbMaterno" ErrorMessage="-El  apellido materno solo puede contener letras y espacio en blanco" Text="*" ValidationExpression="^[a-zA-Z\s]*$"></asp:RegularExpressionValidator><br />
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
                    <asp:TextBox ID="tbTelefono" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="requiredTelefono" runat="server" ControlToValidate="tbTelefono" ErrorMessage="El telefono es un campo obligatorio" Text="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="regularTelefono" runat="server" ControlToValidate="tbTelefono" ValidationExpression="^[0-9]{3}-[0-9]{7}$" Text="*" ErrorMessage="Formato de Telefono no valido xxx-xxxxxxx"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <p>Fecha de nacimiento:</p>
                </td>
                <td>
                    <asp:TextBox ID="tbFechadenac" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbFechadenac" ErrorMessage="Le fecha de nacimiento es un campo obligatorio" Text="*"></asp:RequiredFieldValidator>
                </td>

            </tr>
            <tr>


                <td>
                    <asp:Button ID="btGuardar" runat="server" Text="Guardar" OnClick="btGuardar_Click" />
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="Summary" runat="server" />
    </form>

</body>
</html>
