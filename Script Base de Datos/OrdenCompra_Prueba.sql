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

    -- Obtener el c�digo de la orden de compra reci�n insertada
    DECLARE @CodOrdCompra int;
    SET @CodOrdCompra = SCOPE_IDENTITY();

    -- Insertar en la tabla OrdenCompraProducto
    INSERT INTO OrdenCompraProducto (CodOrdCompra, CodPro, Cantidad, Precio, PrecioTotal)
    VALUES (@CodOrdCompra, @CodPro, @Cantidad, @Precio, @PrecioTotal);

    -- Aqu� puedes agregar m�s inserciones en la tabla OrdenCompraProducto si tienes m�ltiples productos en la orden de compra

    -- Confirmar la transacci�n
    COMMIT;
END
