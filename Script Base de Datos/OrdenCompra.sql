alter PROCEDURE GuardarOrdenCompra
    @RUC char(11),
    @Fecha date,
    @Productos varchar(MAX)
AS
BEGIN Transaction
    SET NOCOUNT ON;

    DECLARE @CodOrdCompra int;

    -- Insertar en la tabla OrdenCompra
    INSERT INTO OrdenCompra (RUC, Fecha)
    VALUES (@RUC, @Fecha);

    -- Obtener el último ID insertado
    SET @CodOrdCompra = SCOPE_IDENTITY();

    -- Insertar los productos en la tabla OrdenCompraProducto
    INSERT INTO OrdenCompraProducto (CodOrdCompra, CodPro, Cantidad, Precio)
    SELECT @CodOrdCompra, CodPro, Cantidad, Precio
    FROM (
        SELECT 
            CAST('<p>' + REPLACE(REPLACE(@Productos, '|', '</p><p>'), ',', '</p><p>') + '</p>' AS XML).value('/p[1]', 'int') AS CodPro,
            CAST('<p>' + REPLACE(REPLACE(@Productos, '|', '</p><p>'), ',', '</p><p>') + '</p>' AS XML).value('/p[2]', 'int') AS Cantidad,
            CAST('<p>' + REPLACE(REPLACE(@Productos, '|', '</p><p>'), ',', '</p><p>') + '</p>' AS XML).value('/p[3]', 'decimal(10,2)') AS Precio
    ) AS productos;

    -- Actualizar el PrecioTotal en la tabla OrdenCompraProducto
    UPDATE ocp
    SET PrecioTotal = ocp.Cantidad * ocp.Precio
    FROM OrdenCompraProducto ocp
    WHERE ocp.CodOrdCompra = @CodOrdCompra;

    -- Confirmar la transacción
    COMMIT Transaction;
END

select * from OrdenCompra
select * from OrdenCompraProducto