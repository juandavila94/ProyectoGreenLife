CREATE  PROCEDURE [dbo].[spConsultarClientesPorCedula]
(  
@cedula VARCHAR (10)
)
AS
BEGIN
SELECT * FROM dbo.Cliente WHERE cedula=@cedula
END
