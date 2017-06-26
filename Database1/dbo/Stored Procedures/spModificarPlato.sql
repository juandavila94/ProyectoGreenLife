CREATE  PROCEDURE [dbo].[spModificarPlato]
(
@id int,    
@nombre VARCHAR (50),                
@precio MONEY,   
@tipo VARCHAR (50)
)
AS
BEGIN
UPDATE  dbo.Plato
SET
nombre=@nombre,
precio=precio,
tipo=@tipo
WHERE
idPlato=@id
END
