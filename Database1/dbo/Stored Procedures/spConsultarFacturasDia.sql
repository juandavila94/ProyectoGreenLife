CREATE  PROCEDURE [dbo].[spConsultarFacturasDia]
(  
@fecha date 
)
AS
BEGIN

SELECT * FROM dbo.Factura where CAST(fecha as DATE) = @fecha
END
