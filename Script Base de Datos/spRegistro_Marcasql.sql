create procedure spRegistroMarca
    @CodMarca INT,
    @Nombre VARCHAR(20),
    @Descripcion VARCHAR(60)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar la nueva marca en la tabla Marca
   insert into Marca (CodMarca, Nombre, Descripcion)
    values (@CodMarca, @Nombre, @Descripcion);
END