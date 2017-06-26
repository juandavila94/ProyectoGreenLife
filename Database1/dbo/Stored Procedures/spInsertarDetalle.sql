--------------------------------------------------------------------------------------
CREATE  PROCEDURE [dbo].[spInsertarDetalle]
(
@idFactura int,                   
@idPlato int,    
@cantidad int,
@precio decimal(20, 15)
)
AS
BEGIN
INSERT INTO dbo.Detalle values (@idFactura , @idPlato , @cantidad ,@precio )
END
