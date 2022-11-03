<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addProducto.aspx.cs" Inherits="tarritoazul.com.forms.addProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- links -->
    <link rel="stylesheet" href="../styles/style.css">
    <link rel="stylesheet" href="../styles/addProducto.css">

    <title>Agregar producto</title>
</head>
<body>
<form id="form1" runat="server">
    <div class="container">
        <div class="item1">
            <div class="nombre">
                <p>Nombre:</p>
                <asp:TextBox ID="tbNombre" runat="server" CssClass="input"></asp:TextBox>
            </div>
            <div class="descripcion">
                <p>Descripcion:</p>
                <asp:TextBox id="tbDescripcion" runat="server" CssClass="input descripcion"></asp:TextBox>
            </div>
        </div>
        <div class="item2">
            <div class="precio">
                <p>Precio:</p>
                <asp:TextBox id="tbPrecio" runat="server" CssClass="input"></asp:TextBox>
            </div>
            <div class="cantidad">
                <p>Cantidad:</p>
                <asp:TextBox id="tbCantidad" runat="server" CssClass="input" TextMode="Number" text="0"></asp:TextBox>
            </div>
            <div class="disponibilidad">
                <p>Disponibilidad:</p>
                <asp:DropDownList id="ddlDisponibilidad" runat="server" CssClass="input">
                    <asp:ListItem id="liDisponible" runat="server" Text="Disponible"></asp:ListItem>
                    <asp:ListItem id="liAgotado" runat="server" Text="Agotado"></asp:ListItem>
                    <asp:ListItem id="liOculto" runat="server" Text="Oculto"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="categoria">
                <p>Categoria:</p>
                <!-- categoria placeholder -->
                <!-- conectar con tabla CATEGORIAS -->
                <asp:DropDownList id="dlCategoria" runat="server" CssClass="input">
                    <asp:ListItem id="liCat1" runat="server" Text="Aretes"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="etiquetas">
                <p>Etiquetas:</p>
                <asp:TextBox id="tbEtiquetas" runat="server" CssClass="input" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>
        
    </div>
    
    <br>
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
</form>
</body>
</html>
