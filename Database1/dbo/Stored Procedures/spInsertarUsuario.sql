CREATE  PROCEDURE [dbo].[spInsertarUsuario]
(
@usuario VARCHAR (50),                   --Input parameter ,  Studentid of the student
@password VARCHAR (50),   
@nombre VARCHAR (100),   
@rol int  
)
AS
BEGIN
INSERT INTO dbo.Usuario values (@usuario,@password,@nombre,@rol)
END
