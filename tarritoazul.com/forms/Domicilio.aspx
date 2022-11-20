<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="domicilio.aspx.cs" Inherits="tarritoazul.com.forms.Domicilio" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="../styles/formulario.css" />
        <title>Domicilio</title>
    </asp:Content>

    <asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
        <div class="formulario">
            <div class="seccion">
                <h1 class="titulo">Domicilio</h1>
                <table>
                    <tr>
                        <td>
                            <span class="txt">Estado:</span>
                            <asp:RequiredFieldValidator ID="RfvEstado" runat="server" ControlToValidate="TbEstado"
                                 Text="*" CssClass="error" ErrorMessage="El campo estado es obligatorio"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="TbEstado" runat="server" CssClass="input"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span class="txt">Ciudad/Municipio:</span>
                            <asp:RequiredFieldValidator ID="RfvMunicipio" runat="server" ControlToValidate="TbMunicipio"
                                 Text="*" CssClass="error" ErrorMessage="El campo municipio es obligatorio"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="TbMunicipio" runat="server" CssClass="input"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span class="txt">Calle:</span>
                            <asp:RequiredFieldValidator ID="RfvCalle" runat="server" ControlToValidate="TbCalle"
                                 Text="*" CssClass="error" ErrorMessage="El campo calle es obligatorio"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="TbCalle" runat="server" CssClass="input"></asp:TextBox>
                        </td>
                    </tr>
                    <tr class="centrar">
                        <td>
                            <p>Entre calles:</p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span class="txt">Calle 1:</span>
                            <asp:RequiredFieldValidator ID="RfvCalle1" runat="server" ControlToValidate="TbCalle1"
                                 Text="*" CssClass="error" ErrorMessage="El campo calle 1 es obligatorio"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="TbCalle1" runat="server" CssClass="input"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span class="txt">Calle 2:</span>
                            <asp:RequiredFieldValidator ID="RfvCalle2" runat="server" ControlToValidate="TbCalle2"
                                 Text="*" CssClass="error" ErrorMessage="El campo calle 2 es obligatorio"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="TbCalle2" runat="server" CssClass="input"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span class="txt">Numero Interior (opcional):</span>
                            <asp:TextBox ID="TbNumInt" runat="server" CssClass="input"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span class="txt">Numero Exterior:</span>
                            <asp:RequiredFieldValidator ID="RfvNumExt" runat="server" ControlToValidate="TbNumExt"
                                 Text="*" CssClass="error" ErrorMessage="El campo numero exterior es obligatorio">
                            </asp:RequiredFieldValidator>
                            <asp:TextBox ID="TbNumExt" runat="server" CssClass="input"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span class="txt">Codigo Postal:</span>
                            <asp:RequiredFieldValidator ID="RfvCP" runat="server" ControlToValidate="TbCP" 
                                Text="*" CssClass="error" ErrorMessage="El campo codigo postal obligatorio"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RevCP" runat="server" ControlToValidate="TbCP" 
                                Text="*" CssClass="error" ErrorMessage="Ingrese un codigo postal valido" ValidationExpression="^[0-9]{5}$">
                            </asp:RegularExpressionValidator>
                            <asp:TextBox ID="TbCP" runat="server" CssClass="input"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span class="txt">Descripción adicional:</span>
                            <asp:RequiredFieldValidator ID="RfvDesc" runat="server" ControlToValidate="TbDesc" 
                                Text="*" CssClass="error" ErrorMessage="Debes añadir una descripción del domicilio"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="TbDesc" runat="server" CssClass="input"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <!-- seccion -->
            </div>
            <table class="botones">
                <tr class="centrar">
                    <td>
                        <asp:Button ID="BtnGuardar" runat="server" Text="Guardar"
                            CssClass="btn btn-solid-green btnGuardar" />
                    </td>
                    <td>
                        <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar"
                            CssClass="btn btn-solid-red btnEliminar" />
                    </td>
                </tr>
            </table>
            <asp:ValidationSummary ID="summary" runat="server" class="error" />
        </div>
        <br />
    </asp:Content>