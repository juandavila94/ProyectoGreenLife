﻿CREATE  PROCEDURE [dbo].[spInsertarFactura]
(                  
@idUsuario int,
@idCliente int,
@fecha date,
@metodoDePago varchar(50),
@subtotal decimal(20, 15),
@iva decimal(20, 15),
@total decimal(20, 15),
@validez bit
)
AS
BEGIN
set @validez=1
INSERT INTO dbo.factura values(
 @idUsuario ,
 @idCliente ,
 @fecha ,
@metodoDePago ,
@subtotal ,
@iva ,
@total,
@validez )
END
