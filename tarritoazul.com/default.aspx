<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="tarritoazul.com.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="styles/index.css" />
    <title>Tarritoazul</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="catalogo">
            <!-- <div class="card">
                <img src="imgs/producto/arete01.jpg" alt="Denim Jeans" style="width: 100%" />
                <h1>Waflitos</h1>
                <p class="price">$299</p>
                <p class="descripcion">Pack de 4 aretes con forma de wafles con moras y fresas</p>
                <p>
                    <button>Añadir al carrito</button>
                </p>
            </div> -->
            <asp:Panel ID="pnlProductos" runat="server">
            </asp:Panel>
        </div>
</asp:Content>
