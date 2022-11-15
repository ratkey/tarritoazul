<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="tarritoazul.com.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- Metadatos -->
    <meta charset="utf-8" />
    <meta name="description" content="Tienda de joyeria artesanal de porcelana" />
    <meta name="keywords" content="Aretes, Tienda, Artesanal, Porcelana, Joyeria" />
    <meta name="author" content="Code breakers.sa" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <!--Bootstrap-->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />

    <!-- Links -->
    <link rel="icon" type="image/png" href="imgs/favicon.ico" />
    <link rel="stylesheet" href="styles/style.css" />
    <link rel="stylesheet" href="styles/index.css" />

    <title>Tarritoazul</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <header>
        <img class="logo" src="imgs/logo.png" />
    </header>

    <!--Navbar-->
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <a class="navbar-brand" href="#">Tarritoazul</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="index.html">Inicio <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="contacto.html">Contacto</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="faq.html">FAQs</a>
                </li>
            </ul>
            <form class="form-inline my-2 my-lg-0">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="carrito.aspx">🛒Carrito</a>
                    </li>
                </ul>
                <button type="button" class="btn btn-outline-secondary" onclick="window.location.href = 'forms/registro.aspx';" style="margin-right: 5px">Registrarse</button>
                <button type="button" class="btn btn-primary" onclick="window.location.href = 'forms/login.aspx';">Iniciar seción</button>
            </form>
        </div>
    </nav>
    <br/>
    <nav class="navbar justify-content-between">
        <a class="navbar-brand"></a>
        <form class="form-inline">
            <input class="form-control mr-sm-2" type="search" placeholder="Aretes de sandía" aria-label="Search" />
            <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Buscar</button>
        </form>
    </nav>
    <div class="catalogo">
        <div class="card">
            <img src="imgs/producto/arete01.jpg" alt="Denim Jeans" style="width:100%">
            <h1>Waflitos</h1>
            <p class="price">$299</p>
            <p class="descripcion">Pack de 4 aretes con forma de wafles con moras y fresas</p>
            <p><button>Añadir al carrito</button></p>
        </div>
        <div class="card">
            <img src="imgs/producto/arete02.jpg" alt="Denim Jeans" style="width:100%">
            <h1>Güacamolitos</h1>
            <p class="price">$299</p>
            <p class="descripcion">Aretes con forma de molcajetes con güacamole y totopos</p>
            <p><button>Añadir al carrito</button></p>
        </div>
        <div class="card">
            <img src="imgs/producto/arete03.jpg" alt="Denim Jeans" style="width:100%">
            <h1>Sandías</h1>
            <p class="price">$299</p>
            <p class="descripcion">Aretes con forma de rebanadas de sandía</p>
            <p><button>Añadir al carrito</button></p>
        </div>
        <div class="card">
            <img src="imgs/producto/arete04.jpg" alt="Denim Jeans" style="width:100%">
            <h1>Ranitas</h1>
            <p class="price">$299</p>
            <p class="descripcion">Aretes con forma de ranitas sobre hojas de flor de loto</p>
            <p><button>Añadir al carrito</button></p>
        </div>
        <div class="card">
            <img src="imgs/producto/arete05.jpg" alt="Denim Jeans" style="width:100%">
            <h1>Limoncitos</h1>
            <p class="price">$299</p>
            <p class="descripcion">Aretes con forma de gajos de gajitos de limón</p>
            <p><button>Añadir al carrito</button></p>
        </div>
        <asp:Label ID="label1" runat="server"></asp:Label>
    </div>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"
        integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"
        crossorigin="anonymous">
    </script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js"
        integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"
        crossorigin="anonymous">
    </script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js"
        integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"
        crossorigin="anonymous">
    </script>
</body>
</html>
