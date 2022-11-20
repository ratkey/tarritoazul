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
                    <td> <p>Estado:</p> </td>
                    <td><asp:TextBox ID="TbEstado" runat="server"></asp:TextBox></td>
                     <td>
                        <asp:RequiredFieldValidator ID="RfvEstado" runat="server" ControlToValidate="TbEstado" Text="*" ErrorMessage="-El campo estado es obligatorio" ></asp:RequiredFieldValidator><br />
                    </td>
                </tr>
                <tr>
                    <td> <p>Municipio:</p> </td>
                    <td><asp:TextBox ID="TbMunicipio" runat="server"></asp:TextBox></td>
                     <td>
                        <asp:RequiredFieldValidator ID="RfvMunicipio" runat="server" ControlToValidate="TbMunicipio" Text="*" ErrorMessage="-El campo municipio es obligatorio" ></asp:RequiredFieldValidator><br />
                    </td>
                </tr>
                <tr>
                    <td> <p>Calle:</p> </td>
                    <td><asp:TextBox ID="TbCalle" runat="server"></asp:TextBox></td>
                     <td>
                        <asp:RequiredFieldValidator ID="RfvCalle" runat="server" ControlToValidate="TbCalle" Text="*" ErrorMessage="-El campo calle es obligatorio" ></asp:RequiredFieldValidator><br />
                    </td>
                </tr>
                <tr>
                    <td> <p>Entre calles:</p></td>
                </tr>
                <tr>
                    <td>Calle 1:</td>
                    <td><asp:TextBox ID="TbCalle1" runat="server"></asp:TextBox></td>
                     <td>
                        <asp:RequiredFieldValidator ID="RfvCalle1" runat="server" ControlToValidate="TbCalle1" Text="*" ErrorMessage="-El campo calle 1 es obligatorio" ></asp:RequiredFieldValidator><br />
                    </td>
                    <td>Calle 2:</td>
                    <td><asp:TextBox ID="TbCalle2" runat="server"></asp:TextBox></td>
                     <td>
                        <asp:RequiredFieldValidator ID="RfvCalle2" runat="server" ControlToValidate="TbCalle2" Text="*" ErrorMessage="-El campo calle 2 es obligatorio" ></asp:RequiredFieldValidator><br />
                    </td>
                </tr>
                <tr>
                    <td><p>Numero Interior:</p></td>
                    <td><asp:TextBox ID="TbNumInt" runat="server"></asp:TextBox></td>
                      <td>
                    </td>
                </tr>
                <tr>
                    <td><p>Numero Exterior:</p></td>
                    <td><asp:TextBox ID="TbNumExt" runat="server"></asp:TextBox></td>
                      <td>
                        <asp:RequiredFieldValidator ID="RfvNumExt" runat="server" ControlToValidate="TbNumExt" Text="*" ErrorMessage="-El campo numero exterior es obligatorio" ></asp:RequiredFieldValidator><br />
                    </td>
                </tr>
                <tr>
                    <td><p>Codigo Postal:</p></td>
                    <td><asp:TextBox ID="TbCP" runat="server"></asp:TextBox></td>
                      <td>
                        <asp:RequiredFieldValidator ID="RfvCP" runat="server" ControlToValidate="TbCP" Text="*" ErrorMessage="-El campo codigo postal obligatorio" ></asp:RequiredFieldValidator><br />
                        <asp:RegularExpressionValidator ID="RevCP" runat="server" ControlToValidate="TbCP" Text="*" ErrorMessage="-Ingrese un codigo postal valido" ValidationExpression="^[0-9]{5}$"></asp:RegularExpressionValidator><br />
                    </td>
                </tr>
                <tr>
                    <td><p>Descripción del domicilio:</p></td>
                    <td><asp:TextBox ID="TbDesc" runat="server"></asp:TextBox></td>
                    <td>
                    <asp:RequiredFieldValidator ID="RfvDesc" runat="server" ControlToValidate="TbDesc" Text="*" ErrorMessage="-Debes añadir una descripción del domicilio" ></asp:RequiredFieldValidator><br />
                    </td>
                </tr>
                <tr>
                    <td><asp:Button ID="BtnGuardar" runat="server" Text="Guardar"/></td>
                </tr>
                
            </table>
            <asp:ValidationSummary ID="summary" runat="server" />
        </div>
    </form>
</body>
</html>
