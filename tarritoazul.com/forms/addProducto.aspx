<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addProducto.aspx.cs" Inherits="tarritoazul.com.forms.addProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

    <!-- links -->
    <link rel="stylesheet" href="../styles/style.css" />
    <link rel="stylesheet" href="../styles/addProducto.css" />

    <title>Agregar producto</title>
</head>
<body class="bgGradient">
<form id="form1" runat="server">

    <div class="container">
        <h2 class="titulo">Añadir producto</h2>
        <div class="item1">
            <div class="nombre">
                <p>Nombre:</p>
                <asp:TextBox ID="tbNombre" runat="server" CssClass="input"></asp:TextBox>
            </div>
            <div class="descripcion">
                <p>Descripcion:</p>
                <asp:TextBox id="tbDescripcion" runat="server" CssClass="input_descripcion" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>
        <div class="item2">
            <div class="precio">
                <p>Precio:</p>
                <asp:TextBox id="tbPrecio" runat="server" CssClass="input">99</asp:TextBox>
            </div>
            <div class="cantidad">
                <p>Cantidad:</p>
                <asp:TextBox id="tbCantidad" runat="server" CssClass="input" TextMode="Number" text="1"></asp:TextBox>
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
                <asp:DropDownList id="ddlCategoria" runat="server" CssClass="input" DataSourceID="CategoriasConnectionString" DataTextField="nombre" DataValueField="id_categoria"></asp:DropDownList>
            </div>
            <div class="etiquetas">
                <p>Etiquetas:</p>
                <asp:TextBox id="tbEtiquetas" runat="server" CssClass="input" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>
        
    </div>
    <br />
    <div class="file_up">
        <h2 class="titulo">Imagenes</h2>
        <asp:FileUpload ID="FileUpload_Control" runat="server" AllowMultiple="true" />
        <br />
        <asp:Label ID="FileUpload_Msg" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="button_accept" OnClick="btnGuardar_Click"/>
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="button_cancel" OnClick="btnEliminar_Click" />
    <br />
     
    <asp:Label ID="FileUploadStatus" runat="server"></asp:Label>
    <asp:SqlDataSource ID="CategoriasConnectionString" runat="server" ConnectionString="<%$ ConnectionStrings:TAConnectionString %>" SelectCommand="SELECT * FROM [CATEGORIAS]"></asp:SqlDataSource>
</form>

</body>
</html>
