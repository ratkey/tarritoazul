<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="administracion.aspx.cs" Inherits="tarritoazul.com.forms.administracion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- links -->
    <link rel="stylesheet" href="../styles/style.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnAddProducto" runat="server" Text="Nuevo producto" CssClass="button_accept" PostBackUrl="~/forms/addProducto.aspx" />
        <div>
            <asp:GridView ID="productosGridView" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id_producto" DataSourceID="productosDataSource" ForeColor="Black" GridLines="Horizontal" OnRowEditing="GridView1_RowEditing" Width="100%">
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
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView> 
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
        </div>
    </form>
</body>
</html>
