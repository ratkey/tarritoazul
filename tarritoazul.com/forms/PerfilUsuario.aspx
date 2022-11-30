<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="tarritoazul.com.PerfilUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <table style="text-align:center" aling="center" border="1">
        <tr>
            <td style="width: 350px;">
                <%--Td de relleno para centrar la tabla pq no se--%>
            </td>
            <tr>
            <%--td de la imagen--%>
            <td style="max-width: 150px; overflow: hidden;">
                <iframe src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6CYfo7p4XPPIU74i7cBTuirx751i1tnm0Xw5fND8Qad2Y6BYOYdapnDXlcQvFVru9mfA&usqp=CAU" height="250" width="200"> </iframe>
                <br />
                <asp:FileUpload ID="Perfil" runat="server" /><br />
            
            </td>



            <%--td de los labels y botones--%>
            <td>
                <asp:Label ID="LbNombre" runat="server" Text="Nombre"></asp:Label>
                
                <asp:Label ID="LbApPaterno" runat="server" Text="Apellido1"></asp:Label>
                
                <asp:Label ID="LbApMaterno" runat="server" Text="Apellido2"></asp:Label>
                <br /><br />
                <asp:Label ID="LbNacimiento" runat="server" Text="Fecha de nacer"></asp:Label>
                <br /><br />
                <asp:Label ID="LbTelefono" runat="server" Text="Fecha de telefono"></asp:Label>
                <br /><br />
                <asp:Label ID="LbCorreo" runat="server" Text="Fecha de email"></asp:Label>
                <br /><br />
                <asp:Label ID="LbDireccion" runat="server" Text="Dirección (recordemos que tener más de 3 direcciónes es motivo de demanda legal segun el articulo 56° de la constitución"></asp:Label>
                <br /><br />
                 <asp:Button ID="BtnEditar" runat="server" Text="Editar las fechas de mi perfil" CssClass="btn btn-solid-green" />
                <br /><br />
              
            </td>
        </tr>
        <asp:ValidationSummary 
                              id="Summary" 
                              runat="server"/>
    </table>
     

        
</asp:Content>

