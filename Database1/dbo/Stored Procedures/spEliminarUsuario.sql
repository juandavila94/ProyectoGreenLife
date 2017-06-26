CREATE  PROCEDURE [dbo].[spEliminarUsuario]
(
@usuario VARCHAR (50)             
)
AS
BEGIN
DELETE FROM  dbo.Usuario
WHERE 
Usuario= @usuario
END
