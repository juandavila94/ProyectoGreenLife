create procedure spAnularFactura
(  
@idFactura int
)
AS
BEGIN
UPDATE  dbo.Factura
SET
validez=0
WHERE
idFactura=@idFactura

END