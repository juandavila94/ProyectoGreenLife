CREATE  PROCEDURE [dbo].[spConsultarFacturasPorCliente]
(  
@idCliente int
)
AS
BEGIN
SELECT * FROM dbo.Factura WHERE idCliente = @idCliente
END
