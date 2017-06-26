CREATE  PROCEDURE [dbo].[spConsultarTotalFacturasMes]
(  
@mes int 
)
AS
BEGIN
SELECT SUM(total) as 'total del mes'
FROM Factura
WHERE MONTH(fecha)= @mes 
GROUP BY MONTH(fecha)
END
