<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="addProducto.aspx.cs" Inherits="tarritoazul.com.forms.addProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../styles/addProducto.css" />
    <title>Producto</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <section class="formulario">
        <div class="add_product">
            <h2 class="titulo">Añadir producto</h2>
            <div class="item1">
                <div class="nombre">
                    <p>Nombre:</p>
                    <asp:TextBox ID="tbNombre" runat="server" CssClass="input"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredNombre" runat="server" ControlToValidate="tbNombre"
                        text="*" CssClass="error" ErrorMessage="Ingrese nombre del producto 😒">
                    </asp:RequiredFieldValidator>
                </div>
                <div class="descripcion">
                    <p>Descripcion:</p>
                    <asp:TextBox ID="tbDescripcion" runat="server" CssClass="input_descripcion" TextMode="MultiLine"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredDescripcion" runat="server" ControlToValidate="tbDescripcion"
                        text="*" CssClass="error" ErrorMessage="Ingrese una descripción para el producto 😒">
                    </asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="item2">

                <div class="precio">
                    <p>Precio:</p>
                    <asp:TextBox ID="tbPrecio" runat="server" CssClass="input">99</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularPrecio" runat="server"
                        ControlToValidate="tbPrecio" ValidationExpression="^[0-9\s]*$" CssClass="error"
                        text="*" ErrorMessage="El precio solo acepta numeros 😒">
                    </asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredPrecio" runat="server" ControlToValidate="tbPrecio"
                        text="*" CssClass="error" ErrorMessage="Ingrese un precio para el producto 😒">
                    </asp:RequiredFieldValidator>
                </div>

                <div class="cantidad">
                    <p>Cantidad:</p>
                    <asp:TextBox ID="tbCantidad" runat="server" CssClass="input" TextMode="Number" Text="1"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularCantidad" runat="server"
                        ControlToValidate="tbCantidad" ValidationExpression="^[0-9\s]*$" CssClass="error"
                        text="*" ErrorMessage="La cantidad solo acepta numeros 😒">
                    </asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredCantidad" runat="server" ControlToValidate="tbCantidad"
                        text="*" CssClass="error" ErrorMessage="Ingrese la cantidad del producto 😒">
                    </asp:RequiredFieldValidator>
                </div>

                <div class="disponibilidad">
                    <p>Disponibilidad:</p>
                    <asp:DropDownList ID="ddlDisponibilidad" runat="server" CssClass="input">
                        <asp:ListItem id="liDisponible" runat="server" Text="Disponible"></asp:ListItem>
                        <asp:ListItem id="liAgotado" runat="server" Text="Agotado"></asp:ListItem>
                        <asp:ListItem id="liOculto" runat="server" Text="Oculto"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="categoria">
                    <p>Categoria:</p>
                    <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="input" DataSourceID="CategoriasConnectionString" DataTextField="nombre" DataValueField="id_categoria"></asp:DropDownList>
                </div>

                <div class="etiquetas">
                    <p>Etiquetas:</p>
                    <asp:TextBox ID="tbEtiquetas" runat="server" CssClass="input" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
            <div class="file_up">
                <h2 class="titulo">Imagenes</h2>
                <asp:FileUpload ID="FileUpload_Control" runat="server" AllowMultiple="true" />
                <br />
                <asp:Label ID="FileUpload_Msg" runat="server" Text=""></asp:Label>
            </div>
        </div>


        <div class="botones">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-solid-green btnGuardar" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-solid-red btnEliminar" OnClick="btnEliminar_Click" />
        </div>


        <asp:Label ID="FileUploadStatus" runat="server"></asp:Label>
        <asp:ValidationSummary ID="summary" runat="server" />

    </section>
    <br>
    <asp:SqlDataSource ID="CategoriasConnectionString" runat="server" ConnectionString="<%$ ConnectionStrings:TAConnectionString %>" SelectCommand="SELECT * FROM [CATEGORIAS]"></asp:SqlDataSource>
</asp:Content>
