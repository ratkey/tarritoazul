<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="administracion.aspx.cs" Inherits="tarritoazul.com.forms.administracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Administracion</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h1>Productos</h1>
    <asp:GridView ID="productosGridView" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="id_producto" DataSourceID="productosDataSource" ForeColor="Black" GridLines="Vertical" OnRowEditing="GridView1_RowEditing" Width="100%">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="id_producto" HeaderText="id_producto" InsertVisible="False" ReadOnly="True" SortExpression="id_producto" />
            <asp:BoundField DataField="codigo_producto" HeaderText="codigo_producto" SortExpression="codigo_producto" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="descripcion" HeaderText="descripcion" SortExpression="descripcion" />
            <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
            <asp:BoundField DataField="cantidad" HeaderText="cantidad" SortExpression="cantidad" />
            <asp:BoundField DataField="disponibilidad" HeaderText="disponibilidad" SortExpression="disponibilidad" />
            <asp:BoundField DataField="id_categoria" HeaderText="id_categoria" SortExpression="id_categoria" />
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
    <br />
    <center>
        <asp:Button ID="btnAddProducto" runat="server" Text="Nuevo producto" CssClass="btn btn-solid-green" OnClick="btnAddProducto_Click" /></center>
    <asp:SqlDataSource ID="productosDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:TAConnectionString %>" DeleteCommand="DELETE FROM [PRODUCTOS] WHERE [id_producto] = @id_producto" InsertCommand="INSERT INTO [PRODUCTOS] ([codigo_producto], [nombre], [descripcion], [precio], [cantidad], [disponibilidad], [id_categoria]) VALUES (@codigo_producto, @nombre, @descripcion, @precio, @cantidad, @disponibilidad, @id_categoria)" SelectCommand="SELECT * FROM [PRODUCTOS]" UpdateCommand="UPDATE [PRODUCTOS] SET [codigo_producto] = @codigo_producto, [nombre] = @nombre, [descripcion] = @descripcion, [precio] = @precio, [cantidad] = @cantidad, [disponibilidad] = @disponibilidad, [id_categoria] = @id_categoria WHERE [id_producto] = @id_producto">
        <DeleteParameters>
            <asp:Parameter Name="id_producto" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="codigo_producto" Type="String" />
            <asp:Parameter Name="nombre" Type="String" />
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="precio" Type="Double" />
            <asp:Parameter Name="cantidad" Type="Int32" />
            <asp:Parameter Name="disponibilidad" Type="String" />
            <asp:Parameter Name="id_categoria" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="codigo_producto" Type="String" />
            <asp:Parameter Name="nombre" Type="String" />
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="precio" Type="Double" />
            <asp:Parameter Name="cantidad" Type="Int32" />
            <asp:Parameter Name="disponibilidad" Type="String" />
            <asp:Parameter Name="id_categoria" Type="Int32" />
            <asp:Parameter Name="id_producto" Type="Int32" />
        </UpdateParameters>
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
