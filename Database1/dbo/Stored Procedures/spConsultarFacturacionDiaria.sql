CREATE  PROCEDURE [dbo].[spConsultarFacturacionDiaria]
(  
@fecha date

)
AS
BEGIN
SELECT SUM(total) as 'tarjetas'
FROM Factura
WHERE fecha= @fecha and metodoDePago='tarjeta'
GROUP BY fecha
SELECT SUM(total) as 'efectivo'
FROM Factura
WHERE fecha= @fecha and metodoDePago='efectivo'
GROUP BY fecha
SELECT SUM(total) as 'TOTAL'
FROM Factura
WHERE fecha= @fecha 
GROUP BY fecha
END
