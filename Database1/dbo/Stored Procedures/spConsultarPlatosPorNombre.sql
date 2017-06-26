CREATE  PROCEDURE [dbo].[spConsultarPlatosPorNombre]
(  
@nombre VARCHAR (100)
)
AS
BEGIN
SELECT * FROM dbo.Plato WHERE nombre like '%'+@nombre+'%'
END
