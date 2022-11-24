<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="tarritoazul.com.PerfilUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <table style="text-align:center" aling="center" border="1">
        <tr>
            <td style="width: 350px;">
                <%--Td de relleno para centrar la tabla pq no se--%>
            </td>
            <%--td de la imagen--%>
            <td style="max-width: 150px; overflow: hidden;">
                <iframe src="https://m.media-amazon.com/images/I/71fCb8S9dtL._SY500_.jpg" height="600" width="510"> </iframe>
            </td>

            <%--td de los labels y botones--%>
            <td>
                <asp:Label ID="LbProducto" runat="server" Text="AretesCoso"></asp:Label>
                <br /> <br />
                <asp:Label ID="LbPrecio" runat="server" Text="15$"></asp:Label>
                <br /> <br />
                <asp:Label ID="LbDescripcion" runat="server" Text="Aretes con forma de coso que huelen a lima"></asp:Label>
                <br /> <br />
                <asp:Label ID="LbCantidad" runat="server" Text="Cantidad:"></asp:Label>
                <asp:TextBox ID="TbCantidad" runat="server" TextMode="Number" Text="1" width="10px"></asp:TextBox>
	 <asp:RangeValidator id="RangeCantidad"
          	 ControlToValidate="TbCantidad"
          	 MinimumValue="0"
          	 MaximumValue="999"
          	 Type="Integer"
          	 EnableClientScript="false"
          	 Text="*"
          	 runat="server"/>
                <br /><br />
                 <asp:Button ID="BtnAgregar" runat="server" Text="Agregar al carrito" CssClass="btn btn-solid-green" />
                <br /><br />
                 <asp:Button ID="BtnComprar" runat="server" Text="Comprar Ahora" CssClass="btn btn-solid-green" />
            </td>
        </tr>
        <asp:ValidationSummary 
                              id="Summary" 
                              runat="server"/>
    </table>
</asp:Content>
