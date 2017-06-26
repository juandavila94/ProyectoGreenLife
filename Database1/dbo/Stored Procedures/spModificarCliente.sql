CREATE  PROCEDURE [dbo].[spModificarCliente]
(
@cedulaAntigua VARCHAR (50),       
@cedulaNueva VARCHAR (50),                
@nombre VARCHAR (50),   
@direccion VARCHAR (100),   
@telefono int  
)
AS
BEGIN
UPDATE  dbo.Cliente
SET
cedula=@cedulaNueva, 
nombre=@nombre,
direccion=@direccion,
telefono=@telefono
WHERE
cedula=@cedulaAntigua
END
