<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index_placeholder.aspx.cs" Inherits="tarritoazul.com.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="~/styles/index.css" />

    <title>Tarritoazul</title>
</head>
<body>

    <header>
        <img class="logo" src="imgs/logo.png" />
    </header>

    <!--Navbar-->
    <form id="form1" runat="server">
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
                <div class="form-inline my-2 my-lg-0">
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item">
                            <a class="nav-link" href="carrito.aspx">🛒Carrito</a>
                        </li>
                    </ul>
                    <asp:Button ID="btnAdmin" runat="server" Text="Administrar" CssClass="btn btn-solid-orange" PostBackUrl="~/forms/administracion.aspx" Style="margin-right: 5px" />
                    <asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" CssClass="btn btn-outline-green" PostBackUrl="~/forms/registro.aspx" Style="margin-right: 5px" />
                    <asp:Button ID="btnIniciarSecion" runat="server" Text="Iniciar seción" CssClass="btn btn-solid-green" PostBackUrl="~/forms/registro.aspx" />
                </div>
            </div>
        </nav>
        <br />

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
    </form>

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
