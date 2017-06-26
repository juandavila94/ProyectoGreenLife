create  PROCEDURE [dbo].[spConsultarTotalFacturasPorMetodoDia]
(  
@fecha date,
@metodoPago varchar(50)
)
AS
BEGIN
SELECT SUM(total) as 'total del dia'
FROM Factura
WHERE fecha= @fecha and metodoDePago=@metodoPago
GROUP BY fecha
END
----------
