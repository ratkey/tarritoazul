<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="tarritoazul.com.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="styles/catalogo.css" />
    <title>Tarritoazul</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="catalogo">
            <asp:Panel ID="pnlProductos" runat="server">
            </asp:Panel>
        </div>
</asp:Content>
