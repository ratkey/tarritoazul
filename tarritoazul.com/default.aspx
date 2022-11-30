<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="tarritoazul.com.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="styles/catalogo.css" />
    <title>Tarritoazul</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="buscarCatalogo">
        <asp:TextBox ID="tbBuscar" runat="server" TextMode="Search" OnTextChanged="tbBuscar_TextChanged" CssClass="btn-outline-primario"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="🔎Buscar" OnClick="btnBuscar_Click" CssClass="btn btn-outline-exito"/>
    </div>
    <div class="catalogo">
            <asp:Panel ID="pnlProductos" runat="server">
            </asp:Panel>
        </div>
</asp:Content>
