<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addProducto.aspx.cs" Inherits="tarritoazul.com.forms.addProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="propiedades">
            <div class="nombre">
                <asp:Label id="lbNombre" runat="server" Text="Nombre:"></asp:Label>
                <br>
                <asp:TextBox ID="tbNombre" runat="server" CssClass="input"></asp:TextBox>
            </div>
            <br>
            <div class="descripcion">
                <asp:Label id="lbDescripcion" runat="server" text="Descripción:"></asp:Label>
                <br>
                <asp:TextBox id="tbDescripcion" runat="server" CssClass="input"></asp:TextBox>
            </div>
            <br>
            <div class="precio">
                <asp:Label id="lbPrecio" runat="server" text="Precio:"></asp:Label>
                <br>
                <asp:TextBox id="tbPrecio" runat="server" CssClass="input"></asp:TextBox>
            </div>
            <br>
            <div class="cantidad">
                <asp:Label id="lbCantidad" runat="server" text="Cantidad:"></asp:Label>
                <br>
                <asp:TextBox id="tbCantidad" runat="server" CssClass="input" TextMode="Number" text="0"></asp:TextBox>
            </div>
            <br>
            <div class="disponibilidad">
                <asp:Label id="tbDisponibilidad" runat="server" text="Disponibilidad:"></asp:Label>
                <br>
                <asp:DropDownList id="ddlDisponibilidad" runat="server" CssClass="input">
                    <asp:ListItem id="liDisponible" runat="server" Text="Disponible"></asp:ListItem>
                    <asp:ListItem id="liAgotado" runat="server" Text="Agotado"></asp:ListItem>
                    <asp:ListItem id="liOculto" runat="server" Text="Oculto"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <br>
            <div class="categoria">
                <asp:Label id="lbCategoria" runat="server" text="Categoria:"></asp:Label>
                <br>
                <asp:DropDownList id="dlCategoria" runat="server" CssClass="input"></asp:DropDownList>
            </div>
            <br>
            <div class="etiquetas">
                <asp:Label id="lbEtiquetas" runat="server" text="Etiquetas:"></asp:Label>
                <br>
                <asp:TextBox id="tbEtiquetas" runat="server" CssClass="input"></asp:TextBox>
            </div>
        </div>
        
        <br>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
    </form>
</body>
</html>
