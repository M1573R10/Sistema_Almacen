alter procedure spRegistroMarca
    @Nombre VARCHAR(20),
    @Descripcion VARCHAR(60)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar la nueva marca en la tabla Marca
   insert into Marca (Nombre, Descripcion)
    values (@Nombre, @Descripcion);
END

create procedure spActualizarMarca(
	@CodMarca int,
	@Nombre varchar(20),
	@Descripcion varchar(60)
) as
begin
update Marca set
	Nombre = @Nombre,
	Descripcion = @Descripcion
	where CodMarca = @CodMarca
end

create procedure spListaMarca
as
	select CodMarca, Nombre, Descripcion from Marca

create procedure spEliminaMarca(
	@CodMarca int,
	@Nombre varchar(20),
	@Descripcion varchar(60)
)as
begin
	delete from Marca where CodMarca = @CodMarca
end

select * from Marca