CREATE  PROCEDURE [dbo].[spEliminarPlato]
(
@id int            
)
AS
BEGIN
DELETE FROM  dbo.Plato
WHERE 
idPlato= @id
END
