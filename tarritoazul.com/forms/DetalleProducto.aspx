<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="tarritoazul.com.forms.DetalleProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../styles/formulario.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="formulario">
        <div class="seccion-wide">
            <table style="width:100%">
                <tr>
                    <td style="width:350px">
                        <asp:Image ID="imgProducto" runat="server" style="width:300px" />
                    </td>

                    <%--td de los labels y botones--%>
                    <td>
                        <asp:Label ID="lbNombre" runat="server" Text="????" CssClass="titulo"></asp:Label>
                        <br />
                        <asp:Label ID="lbPrecio" runat="server" Text="?????"></asp:Label>
                        <br />
                        <asp:Label ID="lbDescripcion" runat="server" Text="??????????"></asp:Label>
                        <br />
                        <asp:Label ID="lbCantidad" runat="server" Text="Cantidad:"></asp:Label>
                        <asp:TextBox ID="TbCantidad" runat="server" TextMode="Number" Text="1" Width="50px"></asp:TextBox>
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
                        <asp:Button ID="BtnAgregar" runat="server" Text="Agregar al carrito" CssClass="btn btn-secundario" OnClick="BtnAgregar_Click" CausesValidation="False" />
                        <%--<br />
                        <br />
                        <asp:Button ID="BtnComprar" runat="server" Text="Comprar Ahora" CssClass="btn btn-primario" />--%>
                    </td>
                </tr>
                <asp:ValidationSummary
                    ID="Summary"
                    runat="server" />
            </table>
        </div>
    </div>
</asp:Content>
