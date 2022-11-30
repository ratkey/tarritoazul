<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="addUsuario.aspx.cs" Inherits="tarritoazul.com.forms.addUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../styles/formulario.css" />
    <title>Usuario</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="formulario">
        <div class="seccion-narrow">
            <table>
                <tr>
                    <td>
                        <span class="txt">Nombres</span>
                        <asp:RequiredFieldValidator ID="requiredNombres" runat="server" ControlToValidate="tbNombres" ErrorMessage="-El Nombre es campo obligatorio" Text="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regularNombres" runat="server" ControlToValidate="tbNombres" ErrorMessage="-El  nombre solo puede contener letras y espacio en blanco" Text="*" ValidationExpression="^[a-zA-Z\s]*$"></asp:RegularExpressionValidator>
                        <asp:TextBox ID="tbNombres" runat="server" CssClass="input"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <span class="txt">Apellido Paterno:</span>
                        <asp:RequiredFieldValidator ID="RequiredPaterno" runat="server" ControlToValidate="tbPaterno" ErrorMessage="-El apellido paterno es campo obligatorio" Text="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegPaterno" runat="server" ControlToValidate="tbPaterno" ErrorMessage="-El  apellido paterno solo puede contener letras y espacio en blanco" Text="*" ValidationExpression="^[a-zA-Z\s]*$"></asp:RegularExpressionValidator>
                        <asp:TextBox ID="tbPaterno" runat="server" CssClass="input"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="txt">Apellido Materno:</span>
                        <asp:RegularExpressionValidator ID="RegMaterno" runat="server" ControlToValidate="tbMaterno" ErrorMessage="-El  apellido materno solo puede contener letras y espacio en blanco" Text="*" ValidationExpression="^[a-zA-Z\s]*$"></asp:RegularExpressionValidator>
                        <asp:TextBox ID="tbMaterno" runat="server" CssClass="input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="txt">Sexo:</span>
                        <asp:DropDownList ID="ddlSexo" runat="server" CssClass="input">
                            <asp:ListItem Value="F">Femenino</asp:ListItem>
                            <asp:ListItem Value="M">Masculino</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="txt">Telefono:</span>
                        <asp:RequiredFieldValidator ID="requiredTelefono" runat="server" ControlToValidate="tbTelefono" ErrorMessage="El telefono es un campo obligatorio" Text="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regularTelefono" runat="server" ControlToValidate="tbTelefono" ValidationExpression="^[0-9]{10}$" Text="*" ErrorMessage="Telefono con formato incorrecto"></asp:RegularExpressionValidator>
                        <asp:TextBox ID="tbTelefono" runat="server" CssClass="input" TextMode="Phone"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="txt">Fecha de nacimiento:</span>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbFechadenac" ErrorMessage="Le fecha de nacimiento es un campo obligatorio" Text="*"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="tbFechadenac" runat="server" TextMode="Date" CssClass="input"></asp:TextBox>
                    </td>

                </tr>
            </table>

            <table class="botones">
                <tr class="centrar">
                    <td>
                        <asp:Button ID="btGuardar" runat="server" Text="Guardar" OnClick="btGuardar_Click" CssClass="btn btn-primario" Width="100%"/>
                    </td>
                </tr>
            </table>
        </div>

    </div>
    <asp:ValidationSummary ID="Summary" runat="server" />
</asp:Content>
