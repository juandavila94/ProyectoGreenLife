CREATE  PROCEDURE [dbo].[spConsultarClientesPorNombre]
(  
@nombre VARCHAR (100)
)
AS
BEGIN
SELECT * FROM dbo.Cliente WHERE nombre like '%'+@nombre+'%'
END
