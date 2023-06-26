create procedure spRegistroTipoProducto(
	@Nombre varchar(20),
	@Descripcion varchar(20)
) as
begin
insert into TipoProducto (Nombre, Descripcion) values (@Nombre, @Descripcion)
end

create procedure spActualizarTipoProducto(
	@CodTipPro int,
	@Nombre varchar(20),
	@Descripcion varchar(60)
)as
begin
update TipoProducto set
	Nombre = @Nombre,
	Descripcion = @Descripcion
	where CodtipPro = @CodTipPro
end

create procedure spListaTipoProducto
as
	select CodTipPro, Nombre, Descripcion from TipoProducto

create procedure spEliminarTipoProducto(
	@CodTipPro int,
	@Nombre varchar(20),
	@Descripcion varchar(60)
)as
begin
	delete from TipoProducto where CodTipPro = @CodTipPro
end

create procedure spListaTipoProductoCombobox
as
	Select * from TipoProducto
go