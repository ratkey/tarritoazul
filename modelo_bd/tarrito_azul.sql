create database tarrito_azul
use tarrito_azul

create table cliente(
id_cliente int primary key identity(1,1),
nombre varchar(50),
appaterno varchar(50),
apmaterno varchar(50),
telefono int,
fecha_nacimiento date
)

create table producto(
id_producto int primary key identity(1,1),
nombre varchar(50),
material varchar(50),
tipo varchar(50),
precio int,
stock int,
descripcion varchar(200),
codigo_producto varchar (20)
)

create table envios(
id_envio int primary key identity(1,1),
fecha_envio date,
estatus varchar(20),
comentario varchar(200)
)

create table domicilio(
id_domicilio int primary key identity(1,1),
id_envio int,
id_cliente int,
calle varchar(50),
numero_interior int,
numero_exterior int,
codigo_postal int,
descripcion_domicilio varchar(200),
constraint fk_envio foreign key (id_envio) references envios(id_envio),
constraint fk_cliente foreign key (id_cliente) references cliente(id_cliente)
)

create table venta(
id_venta int primary key identity(1,1),
id_producto int,
id_cliente int,
id_envio int,
precio_articulo int,
fecha_venta date,
constraint fk_producto foreign key (id_producto) references producto(id_producto),
constraint fk_clientes foreign key (id_cliente) references cliente(id_cliente),
constraint fk_envios foreign key (id_envio) references envios(id_envio)
)

create table detalle_venta(
id_detalle_venta int primary key identity(1,1),
id_venta int,
cantidad int,
total int,
constraint fk_venta foreign key (id_venta) references venta(id_venta)
)

create table registro(
id_registro int primary key identity(1,1),
usuario varchar(50) not null,
correo varchar(50) not null,
contrasena varchar(50) not null
)