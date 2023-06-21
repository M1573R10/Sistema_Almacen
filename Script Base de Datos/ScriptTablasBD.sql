create database Sistema_Almacen

use Sistema_Almacen

create table Proveedores(
	RUC char(11) primary key identity(1,1),
	RazonSocial varchar(60) not null,
	Direccion varchar(100) not null,
	Telefono char(9) not null,
	Contacto varchar(50) not null,
	Correo varchar(60) not null,
	FechaInicio date not null,
	Estado bit not null
)

create table TipoProducto(
	CodTipPro int primary key identity(1,1)
	Nombre varchar(20) not null,
	Descripcion varchar(60) not null
)

create table Marca(
	CodMarca int primary key identity(1,1),
	Nombre varchar(20) not null,
	Descripcion varchar(60) not null
)

create table Producto(
	CodPro int primary key identity(1,1),
	Nombre varchar(30) not null,
	Descripcion varchar(50) not null,
	CodTipPro int not null,
	foreign key (CodTipPro) references TipoProducto(CodTipPro),
	CodMarca int not null,
	foreign key (CodMarca) references Marca(CodMarca),
	stock int not null default 0 --Agregamos el campo 0 para controlar el inventario
)

create table OrdenCompra(
	CodOrdCompra int primary key identity(1,1),
	RUC char(11) not null,
	foreign key(RUC) references Proveedores(RUC),
	Fecha date not null
)

/* No es necesario crear llave primaria aca debido a que estamos
   creando la orden de compra con las dos tablas que tenemos */

create table OrdenCompraProducto(
	CodOrdCompra int not null,
	CodPro int not null,
	Cantidad int not null,
	precio decimal(10,2) not null,
	foreign key (CodOrdCompra) references OrdenCompra(CodOrdCompra),
	foreign key (CodPro) references Producto(CodPro)
)

create table RecepcionMercaderia(
	CodRecMer int primary key identity(1,1),
	Factura char(10) not null,
	RUC char(11) not null,
	foreign key(RUC) references Proveedores(RUC)
)

create table RecepcionMercaderiaProducto(
	CodRecMer int not null,
	CodPro int not null,
	item int not null,
	Cantidad int not null,
	foreign key (CodRecMer) references RecepcionMercaderia(CodRecMer),
	foreign key (CodPro) references Producto(CodPro)
)


create table SalidaMercaderia(
	CodSalMer int primary key identity(1,1),
	DNICliente char(8) not null,
	Nombre varchar(50) not null
)

create table SalidaMercaderiaProducto(
	CodSalMer int not null,
	CodPro int not null,
	item int not null,
	Cantidad int not null,
	foreign key (CodSalMer) references RecepcionMercaderia(CodRecMer),
)