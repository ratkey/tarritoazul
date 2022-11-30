<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="administracion.aspx.cs" Inherits="tarritoazul.com.forms.administracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../styles/administracion.css" />

    <title>Administracion</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h1>Productos
        <asp:Button ID="btnAddProducto" runat="server" Text="Nuevo producto" CssClass="btn btn-primario" OnClick="btnAddProducto_Click" /></h1>
    <asp:GridView ID="productosGridView" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="productosDataSource" OnRowEditing="GridView1_RowEditing" CssClass="tabla" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowEditButton="True" ButtonType="Button" DeleteText="Eliminar" EditText="Editar" CancelText="Cancelar" ShowHeader="False" HeaderText="Controles">
                <ControlStyle CssClass="btn btn-secundario"></ControlStyle>
            </asp:CommandField>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
            <asp:BoundField DataField="Disponibilidad" HeaderText="Disponibilidad" SortExpression="Disponibilidad" />
            <asp:BoundField DataField="Categoría" HeaderText="Categoría" SortExpression="Categoría" />
            <asp:BoundField DataField="Código" HeaderText="Código" SortExpression="Código" />
            <asp:BoundField DataField="Descripción" HeaderText="Descripción" SortExpression="Descripción" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="productosDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:TAConnectionString %>" DeleteCommand="DELETE FROM PRODUCTOS WHERE id_producto = @ID" SelectCommand="SELECT PRODUCTOS.id_producto AS ID, PRODUCTOS.codigo_producto AS Código, PRODUCTOS.nombre AS Nombre, PRODUCTOS.precio AS Precio, PRODUCTOS.cantidad AS Cantidad, PRODUCTOS.disponibilidad AS Disponibilidad, PRODUCTOS.descripcion AS Descripción, CATEGORIAS.nombre AS 'Categoría' FROM PRODUCTOS INNER JOIN CATEGORIAS ON CATEGORIAS.id_categoria = PRODUCTOS.id_categoria" UpdateCommand="UPDATE PRODUCTOS SET codigo_producto =, nombre =, descripcion =, precio =, cantidad =, disponibilidad =, id_categoria ="></asp:SqlDataSource>

    <h1>Categorias</h1>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="id_categoria" DataSourceID="categoriasDataSource" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="id_categoria" HeaderText="id_categoria" InsertVisible="False" ReadOnly="True" SortExpression="id_categoria" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <asp:SqlDataSource ID="categoriasDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:TAConnectionString %>" DeleteCommand="DELETE FROM [CATEGORIAS] WHERE [id_categoria] = @id_categoria" InsertCommand="INSERT INTO [CATEGORIAS] ([nombre]) VALUES (@nombre)" SelectCommand="SELECT * FROM [CATEGORIAS]" UpdateCommand="UPDATE [CATEGORIAS] SET [nombre] = @nombre WHERE [id_categoria] = @id_categoria">
        <DeleteParameters>
            <asp:Parameter Name="id_categoria" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="nombre" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="nombre" Type="String" />
            <asp:Parameter Name="id_categoria" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
