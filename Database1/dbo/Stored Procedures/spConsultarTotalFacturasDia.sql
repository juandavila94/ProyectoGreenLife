CREATE  PROCEDURE [dbo].[spConsultarTotalFacturasDia]
(  
@fecha date 
)
AS
BEGIN
SELECT SUM(total) as 'Total del dia @fecha'
FROM Factura
WHERE fecha= @fecha 
GROUP BY fecha
END
