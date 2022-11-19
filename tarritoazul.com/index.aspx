<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="tarritoazul.com.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="styles/index.css" />
    <title>Tarritoazul</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="catalogo">
            <div class="card">
                <img src="imgs/producto/arete01.jpg" alt="Denim Jeans" style="width: 100%" />
                <h1>Waflitos</h1>
                <p class="price">$299</p>
                <p class="descripcion">Pack de 4 aretes con forma de wafles con moras y fresas</p>
                <p>
                    <button>Añadir al carrito</button>
                </p>
            </div>
            <div class="card">
                <img src="imgs/producto/arete02.jpg" alt="Denim Jeans" style="width: 100%" />
                <h1>Güacamolitos</h1>
                <p class="price">$299</p>
                <p class="descripcion">Aretes con forma de molcajetes con güacamole y totopos</p>
                <p>
                    <button>Añadir al carrito</button>
                </p>
            </div>
            <div class="card">
                <img src="imgs/producto/arete03.jpg" alt="Denim Jeans" style="width: 100%" />
                <h1>Sandías</h1>
                <p class="price">$299</p>
                <p class="descripcion">Aretes con forma de rebanadas de sandía</p>
                <p>
                    <button>Añadir al carrito</button>
                </p>
            </div>
            <div class="card">
                <img src="imgs/producto/arete04.jpg" alt="Denim Jeans" style="width: 100%" />
                <h1>Ranitas</h1>
                <p class="price">$299</p>
                <p class="descripcion">Aretes con forma de ranitas sobre hojas de flor de loto</p>
                <p>
                    <button>Añadir al carrito</button>
                </p>
            </div>
            <div class="card">
                <img src="imgs/producto/arete05.jpg" alt="Denim Jeans" style="width: 100%" />
                <h1>Limoncitos</h1>
                <p class="price">$299</p>
                <p class="descripcion">Aretes con forma de gajos de gajitos de limón</p>
                <p>
                    <button>Añadir al carrito</button>
                </p>
            </div>
        </div>
</asp:Content>
