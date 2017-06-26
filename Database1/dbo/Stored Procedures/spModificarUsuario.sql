CREATE  PROCEDURE [dbo].[spModificarUsuario]
(
@idUsuario int,
@usuario VARCHAR (50),                   --Input parameter ,  Studentid of the student
@password VARCHAR (50),   
@nombre VARCHAR (100),   
@rol int  
)
AS
BEGIN
UPDATE  dbo.Usuario
SET
usuario=@usuario, 
password=@password,
nombre=@nombre,
rol=@rol
WHERE
idUsuario=@idUsuario
END
