<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="tarritoazul.com.contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body{
            text-align:center;
        }
        #map{
            width: 100%;
            height: 400px;
            background-color: gray;
        }
        .center {
            margin: auto;
            width: 95%;
            padding: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="center">
        <h1>Tarritoazul</h1>
        <h2>Eres bienvenido a nuestra fabrica</h2>
        <div id="map"></div>
    </div>
    
    <script>
        //Funcion para inicializar y colocar el mapa en la pagina
        function initMap() {
            //Declarar una variable que se le asigne la longitud y latitud de las oficinas de tarritoazul
            var tarrito = { lat: 21.23970946747837, lng: - 104.90079329614177 };//Ubicacion de las oficinas de tarritoazul
            //Declarar variable para ubicar tarritoazul
            var map = new google.maps.Map(document.getElementById('map'), { zoom: 15, center: tarrito });
            //Posicionar el marcador en el mapa
            var marker = new google.maps.Marker({ position: tarrito, map: map });
        }
    </script>
    <script async defer 
            src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBS4fB3Wb8JS1lwkNBcUNKzvWMVTssyP4E&callback=initMap">

    </script>
</asp:Content>
