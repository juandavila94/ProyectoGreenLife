CREATE  PROCEDURE [dbo].[spEliminarCliente]
(
@cedula VARCHAR (10)             
)
AS
BEGIN
DELETE FROM  dbo.Cliente
WHERE 
cedula= @cedula
END
