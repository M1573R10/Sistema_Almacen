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

select * from Marca

select * from TipoProducto

select * from Proveedores