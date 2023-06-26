create procedure spRegistroProveedores(
	@RUC char(11),
	@RazonSocial varchar(60),
	@Direccion varchar(100),
	@Telefono char(9),
	@Contacto varchar(50),
	@Correo varchar(60),
	@FechaInicio date,
	@Estado bit
)as
begin
insert into Proveedores(RUC, RazonSocial, Direccion, Telefono, 
Contacto,Correo,FechaInicio,Estado) values (@RUC, @RazonSocial, @Direccion,
@Telefono, @Contacto, @Correo, @FechaInicio, @Estado)
end

create procedure spActualizarProveedores(
	@RUC char(11),
	@RazonSocial varchar(60),
	@Direccion varchar(100),
	@Telefono char(9),
	@Contacto varchar(50),
	@Correo varchar(60),
	@FechaInicio date,
	@Estado bit
)as
begin
update Proveedores set
	Direccion = @Direccion,
	Telefono = @Telefono,
	Contacto = @Contacto,
	Correo = @Correo,
	FechaInicio = @FechaInicio,
	Estado = @Estado
	where RUC = @RUC
end

create procedure spDeshabilitaProveedores(
	@RUC char(11)
)as
begin 
	update  Proveedores set 
	Estado = 0
	where RUC = @RUC
end

create procedure spListaProveedores
as
	select RUC, RazonSocial, Direccion, Telefono, Contacto, Correo, FechaInicio, Estado from Proveedores 
	where Estado = '1'
