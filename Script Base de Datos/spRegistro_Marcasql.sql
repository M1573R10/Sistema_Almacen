DROP PROCEDURE spRegistroMarca;
CREATE PROCEDURE spRegistroMarca
    @CodMarca INT,
    @Nombre VARCHAR(20),
    @Descripcion VARCHAR(60)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar la nueva marca en la tabla Marca
    INSERT INTO Marca (CodMarca, Nombre, Descripcion)
    VALUES (@CodMarca, @Nombre, @Descripcion);
END