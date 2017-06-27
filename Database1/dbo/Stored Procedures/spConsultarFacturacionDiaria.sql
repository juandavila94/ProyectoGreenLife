CREATE  PROCEDURE [dbo].[spConsultarFacturacionDiaria]
(  
@fecha date

)
AS
BEGIN
SELECT SUM(total) as 'tarjetas'
FROM Factura
WHERE fecha= @fecha and metodoDePago='tarjeta' and validez=1
GROUP BY fecha
SELECT SUM(total) as 'efectivo'
FROM Factura
WHERE fecha= @fecha and metodoDePago='efectivo'and validez=1
GROUP BY fecha
SELECT SUM(total) as 'TOTAL'
FROM Factura
WHERE fecha= @fecha and validez=1
GROUP BY fecha 
END
