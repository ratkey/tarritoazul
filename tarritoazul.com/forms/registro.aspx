<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="tarritoazul.com.forms.registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../styles/registro.css" />
    <script type="text/javascript">
        function ValidateCheckBox(sender, args) {
            if (
                document.getElementById("<%=Cbprivacidad.ClientID %>").checked == true
            ) {
                args.IsValid = true;
            } else {
                args.IsValid = false;
            }
        }
    </script>
    <title>Registro de usuario</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="registro_box">
        <div class="logo_fondo">
            <img class="logo" src="../imgs/logo.png" />
        </div>
        <br />
        <t1>Crear una cuenta</t1>
        <br />
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="LbNombre" runat="server" Text="Nombre:"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredNombre" runat="server" ControlToValidate="TbNombre"
                        CssClass="error" Text="*" ErrorMessage="Nombre es un campo obligatorio 😧">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularNombre" runat="server"
                        ControlToValidate="tbNombre" ValidationExpression="^[A-Za-z\s]*$" CssClass="error"
                        Text="*" ErrorMessage="Nombre solo admite letras 😒"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbNombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LbEmail" runat="server" Text="Email:"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" ControlToValidate="TbEmail"
                        CssClass="error" Text="*" ErrorMessage="Email es un campo obligatorio 😧">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RevEmail" runat="server" ControlToValidate="TbEmail"
                        CssClass="error" Text="*" ErrorMessage="Email no valido 💌"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                    </asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LbConfirmarEmail" runat="server" Text="Confirmar Email:"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredConfirmarEmail" runat="server"
                        ControlToValidate="TbConfirmarEmail" CssClass="error" Text="*"
                        ErrorMessage="Confirmar Email es un campo obligatorio 😧"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RevConfirmarEmail" runat="server"
                        ControlToValidate="TbConfirmarEmail" CssClass="error" Text="*"
                        ErrorMessage="Email no valido 💌"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                    </asp:RegularExpressionValidator>
                    <asp:CompareValidator ID="CompareEmail" runat="server" ControlToValidate="TbConfirmarEmail"
                        ControlToCompare="TbEmail" CssClass="error" Text="*"
                        ErrorMessage="Los Emails no coinciden 📧"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbConfirmarEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LbContrasena" runat="server" Text="Contraseña:"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredContrasena" runat="server"
                        ControlToValidate="TbContrasena" CssClass="error" Text="*"
                        ErrorMessage="Contraseña es un campo obligatorio 😧"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbContrasena" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LbConfirmarContraseña" runat="server" Text="Confirmar contraseña:">
                    </asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredConfirmarContrasena" runat="server"
                        ControlToValidate="TbConfirmarContrasena" CssClass="error" Text="*"
                        ErrorMessage="Confirmar contraseña es un campo obligatorio 😧">
                    </asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareContrasena" runat="server"
                        ControlToValidate="TbConfirmarContrasena" ControlToCompare="TbContrasena"
                        CssClass="error" Text="*" ErrorMessage="Las contraseñas no coinciden 😟">
                    </asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbConfirmarContrasena" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
        </table>
        <p style="font-size: 9pt;">
            <asp:CheckBox ID="Cbprivacidad" runat="server" Text=" " />
            Acepto las <a href="" target="_blank">Condiciones de uso</a> y el
                <a href="" target="_blank">Aviso de privacidad</a>
            <asp:CustomValidator ID="CustomValidator1" runat="server" CssClass="error" Text="*"
                ErrorMessage="Debes a ceptar las condiciones de uso 👮‍♀️"
                ClientValidationFunction="ValidateCheckBox"></asp:CustomValidator>
        </p>
        <asp:Button ID="BtContinuar" runat="server" Text="Continuar" OnClick="BtContinuar_Click" CssClass="btn btn-solid-green"/>
        <br />
        <p style="font-size: 12pt;">
            ¿Ya tienes una cuenta? <asp:HyperLink ID="linkIniciarSecionForm" runat="server" NavigateUrl="~/forms/login.aspx">Inicie Sesión</asp:HyperLink>
        </p>
        <asp:ValidationSummary ID="summary" runat="server" />
    </div>
</asp:Content>
