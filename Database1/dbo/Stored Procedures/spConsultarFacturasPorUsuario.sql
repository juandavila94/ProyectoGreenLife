CREATE  PROCEDURE [dbo].[spConsultarFacturasPorUsuario]
(  
@idUsuario int
)
AS
BEGIN
SELECT * FROM dbo.Factura WHERE idUsuario = @idUsuario and validez=1
END
