CREATE  PROCEDURE [dbo].[spConsultarFacturasPorCliente]
(  
@idCliente int
)
AS
BEGIN
SELECT * FROM dbo.Factura WHERE idCliente = @idCliente and validez=1
END
