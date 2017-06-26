CREATE  PROCEDURE [dbo].[spConsultarFacturasPorUsuario]
(  
@idUsuario int
)
AS
BEGIN
SELECT * FROM dbo.Factura WHERE idUsuario = @idUsuario
END
