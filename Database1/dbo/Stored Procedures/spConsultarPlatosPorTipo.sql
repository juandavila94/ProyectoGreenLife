CREATE  PROCEDURE [dbo].[spConsultarPlatosPorTipo]
(  
@tipo VARCHAR (50)
)
AS
BEGIN
SELECT * FROM dbo.Plato WHERE tipo=@tipo
END
