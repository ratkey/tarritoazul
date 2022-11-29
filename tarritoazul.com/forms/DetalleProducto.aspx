<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="tarritoazul.com.forms.DetalleProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <table style="text-align: center" aling="center" border="1">
        <tr>
            <td style="width: 350px;">
                <%--Td de relleno para centrar la tabla pq no se--%>
            </td>
            <%--td de la imagen--%>
            <td style="max-width: 150px; overflow: hidden;">
                <asp:Image ID="imgProducto" runat="server" />
            </td>

            <%--td de los labels y botones--%>
            <td>
                <asp:Label ID="lbNombre" runat="server" Text="????"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lbPrecio" runat="server" Text="?????"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lbDescripcion" runat="server" Text="??????????"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lbCantidad" runat="server" Text="Cantidad:"></asp:Label>
                <asp:TextBox ID="TbCantidad" runat="server" TextMode="Number" Text="1" Width="30px"></asp:TextBox>
                <asp:RangeValidator ID="RangeCantidad"
                    ControlToValidate="TbCantidad"
                    MinimumValue="0"
                    MaximumValue="99"
                    Type="Integer"
                    EnableClientScript="false"
                    Text="*"
                    runat="server" />
                <br />
                <br />
                <asp:Button ID="BtnAgregar" runat="server" Text="Agregar al carrito" CssClass="btn btn-primario" OnClick="BtnAgregar_Click" />
                <br />
                <br />
                <asp:Button ID="BtnComprar" runat="server" Text="Comprar Ahora" CssClass="btn btn-primario" />
            </td>
        </tr>
        <asp:ValidationSummary
            ID="Summary"
            runat="server" />
    </table>
</asp:Content>
