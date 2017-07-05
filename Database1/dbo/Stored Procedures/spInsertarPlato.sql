CREATE  PROCEDURE [dbo].[spInsertarPlato]
(                  
@nombre VARCHAR (100),   
@precio MONEY,   
@tipo VARCHAR (50),
@foto image =null
)
AS
BEGIN
IF (@foto is null)
begin
INSERT INTO dbo.Plato values (@nombre,@precio ,@tipo,null)
end
else
begin
INSERT INTO dbo.Plato values (@nombre,@precio ,@tipo,@foto)
end
END
