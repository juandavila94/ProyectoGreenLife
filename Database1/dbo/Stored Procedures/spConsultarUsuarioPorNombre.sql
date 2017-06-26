CREATE  PROCEDURE [dbo].[spConsultarUsuarioPorNombre]
(  
@nombre VARCHAR (100)
)
AS
BEGIN
SELECT * FROM dbo.Usuario WHERE nombre like '%'+@nombre+'%'
END
