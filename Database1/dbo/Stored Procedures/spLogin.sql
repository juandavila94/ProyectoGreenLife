create  PROCEDURE [dbo].[spLogin]
(  
@user VARCHAR (100),
@password VARCHAR (100)
)
AS
BEGIN
if exists (SELECT * FROM dbo.Usuario WHERE usuario=@user and password=@password)
begin
select * from Usuario where usuario=@user
end
END