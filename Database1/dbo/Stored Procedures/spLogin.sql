CREATE  PROCEDURE [dbo].[spLogin]
(  
@user VARCHAR (100),
@password VARCHAR (100)
)
AS
BEGIN
SELECT * FROM dbo.Usuario WHERE usuario=@user and password=@password

END