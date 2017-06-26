CREATE  PROCEDURE [dbo].[spInsertarPlato]
(                  
@nombre VARCHAR (100),   
@precio MONEY,   
@tipo VARCHAR (50),
@foto image
)
AS
BEGIN
INSERT INTO dbo.Plato values (@nombre,@precio ,@tipo,@foto)
END
