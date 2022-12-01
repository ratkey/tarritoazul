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


    <div id="fb-root"></div>
<script async defer crossorigin="anonymous" src="https://connect.facebook.net/es_LA/sdk.js#xfbml=1&version=v15.0" nonce="pTSDo9EG"></script>

<table>
	<tr>
		<td>
		<div class="fb-page" data-href="https://www.facebook.com/profile.php?id=100067099912931" data-tabs="timeline" data-width="" data-height="" data-small-header="false" data-adapt-container-width="true" data-hide-cover="false" data-show-facepile="true"><blockquote cite="https://www.facebook.com/profile.php?id=100067099912931" class="fb-xfbml-parse-ignore"><a href="https://www.facebook.com/profile.php?id=100067099912931">Aretes artesanales</a></blockquote></div>
		</td>
		<td>
		<blockquote class="twitter-tweet"><p lang="es" dir="ltr">Ya contamos con página web @tarrito_azul <a href="https://t.co/kqa0Oi7RdB">https://t.co/kqa0Oi7RdB</a></p>&mdash; cruz (@cruz02249127) <a href="https://twitter.com/cruz02249127/status/1598183160071671809?ref_src=twsrc%5Etfw">December 1, 2022</a></blockquote> <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
		</td>
	</tr>
</table>
    
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
