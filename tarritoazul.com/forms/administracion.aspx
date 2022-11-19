<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="administracion.aspx.cs" Inherits="tarritoazul.com.forms.administracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Administracion</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h1>Productos <asp:Button ID="btnAddProducto" runat="server" Text="Nuevo producto" CssClass="btn btn-solid-green" OnClick="btnAddProducto_Click" /></h1>
    <asp:GridView ID="productosGridView" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="ID" DataSourceID="productosDataSource" OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:CommandField ShowEditButton="True" ButtonType="Button" DeleteText="Eliminar" EditText="Editar" ControlStyle-CssClass="btn btn-solid-green" CancelText="Cancelar" ShowHeader="False" HeaderText="Controles">
<ControlStyle CssClass="btn btn-solid-green"></ControlStyle>
            </asp:CommandField>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID"/>
            <asp:BoundField DataField="Código" HeaderText="Código" SortExpression="Código"  />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
            <asp:BoundField DataField="Disponibilidad" HeaderText="Disponibilidad" SortExpression="Disponibilidad"/>
            <asp:BoundField DataField="Descripción" HeaderText="Descripción" SortExpression="Descripción" />
            <asp:BoundField DataField="Categoría" HeaderText="Categoría" SortExpression="Categoría" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="productosDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:TAConnectionString %>" DeleteCommand="DELETE FROM PRODUCTOS WHERE id_producto = @ID" SelectCommand="SELECT PRODUCTOS.id_producto AS ID, PRODUCTOS.codigo_producto AS Código, PRODUCTOS.nombre AS Nombre, PRODUCTOS.precio AS Precio, PRODUCTOS.cantidad AS Cantidad, PRODUCTOS.disponibilidad AS Disponibilidad, PRODUCTOS.descripcion AS Descripción, CATEGORIAS.nombre AS 'Categoría' FROM PRODUCTOS INNER JOIN CATEGORIAS ON CATEGORIAS.id_categoria = PRODUCTOS.id_categoria" UpdateCommand="UPDATE PRODUCTOS SET codigo_producto =, nombre =, descripcion =, precio =, cantidad =, disponibilidad =, id_categoria =">
    </asp:SqlDataSource>

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
