<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Domicilio.aspx.cs" Inherits="tarritoazul.com.forms.Domicilio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td> <p>Calle:</p> </td>
                    <td><asp:TextBox ID="TbCalle" runat="server"></asp:TextBox></td>
                     <td>
                        <asp:RequiredFieldValidator ID="RfvCalle" runat="server" ControlToValidate="TbCalle" ErrorMessage="-El campo obligatorio" ></asp:RequiredFieldValidator><br />
                    </td>
                </tr>
                <tr>
                    <td><p>Numero Interior:</p></td>
                    <td><asp:TextBox ID="TbNumInt" runat="server"></asp:TextBox></td>
                      <td>
                        <asp:RequiredFieldValidator ID="RfvNumInt" runat="server" ControlToValidate="TbNumInt" ErrorMessage="-El campo obligatorio" ></asp:RequiredFieldValidator><br />
                    </td>
                </tr>
                <tr>
                    <td><p>Numero Exterior:</p></td>
                    <td><asp:TextBox ID="TbNumExt" runat="server"></asp:TextBox></td>
                      <td>
                        <asp:RequiredFieldValidator ID="RfvNumExt" runat="server" ControlToValidate="TbNumExt" ErrorMessage="-El campo obligatorio" ></asp:RequiredFieldValidator><br />
                    </td>
                </tr>
                <tr>
                    <td><p>Codigo Postal:</p></td>
                    <td><asp:TextBox ID="TbCP" runat="server"></asp:TextBox></td>
                      <td>
                        <asp:RequiredFieldValidator ID="RfvCP" runat="server" ControlToValidate="TbCP" ErrorMessage="-El campo obligatorio" ></asp:RequiredFieldValidator><br />
                        <asp:RegularExpressionValidator ID="RevCP" runat="server" ControlToValidate="TbCP" ErrorMessage="-Ingrese un codigo postal valido" ValidationExpression="^[0-9]{5}$"></asp:RegularExpressionValidator><br />
                    </td>
                </tr>
                <tr>
                    <td><p>Descripción del domicilio:</p></td>
                    <td><asp:TextBox ID="TbDesc" runat="server"></asp:TextBox></td>
                    <td>
                    <asp:RequiredFieldValidator ID="RfvDesc" runat="server" ControlToValidate="TbDesc" ErrorMessage="-El campo obligatorio" ></asp:RequiredFieldValidator><br />
                    </td>
                </tr>
                <tr>
                    <td><asp:Button ID="BtnGuardar" runat="server" Text="Guardar"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
