CREATE  PROCEDURE [dbo].[spInsertarCliente]
(
@cedula VARCHAR (13),                   
@nombre VARCHAR (100),   
@direccion VARCHAR (100),   
@telefono VARCHAR (10)
)
AS
BEGIN
INSERT INTO dbo.Cliente values (@cedula,@nombre,@direccion ,@telefono)
END
