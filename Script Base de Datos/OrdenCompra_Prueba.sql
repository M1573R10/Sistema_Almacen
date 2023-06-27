CREATE PROCEDURE GuardarOrdenCompra
(
    @RUC char(11),
    @Fecha date,
    @CodPro int,
    @Cantidad int,
    @Precio decimal(10,2),
    @PrecioTotal decimal(10,2)
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar en la tabla OrdenCompra
    INSERT INTO OrdenCompra (RUC, Fecha)
    VALUES (@RUC, @Fecha);

    -- Obtener el código de la orden de compra recién insertada
    DECLARE @CodOrdCompra int;
    SET @CodOrdCompra = SCOPE_IDENTITY();

    -- Insertar en la tabla OrdenCompraProducto
    INSERT INTO OrdenCompraProducto (CodOrdCompra, CodPro, Cantidad, Precio, PrecioTotal)
    VALUES (@CodOrdCompra, @CodPro, @Cantidad, @Precio, @PrecioTotal);

    -- Aquí puedes agregar más inserciones en la tabla OrdenCompraProducto si tienes múltiples productos en la orden de compra

    -- Confirmar la transacción
    COMMIT;
END
