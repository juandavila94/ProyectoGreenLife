CREATE TABLE [dbo].[Factura] (
    [idFactura]    INT              IDENTITY (1, 1) NOT NULL,
    [idUsuario]    INT              NULL,
    [idCliente]    INT              NOT NULL,
    [fecha]        DATE             NOT NULL,
    [metodoDePago] VARCHAR (50)     NOT NULL,
    [subtotal]     DECIMAL (20, 15) NOT NULL,
    [iva]          DECIMAL (20, 15) NOT NULL,
    [total]        DECIMAL (20, 15) NOT NULL,
    [validez]      BIT              CONSTRAINT [DF_Validez] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED ([idFactura] ASC),
    CONSTRAINT [CK_efectivo_o_Tarjeta] CHECK ([metodoDePago]='tarjeta' OR [metodoDePago]='efectivo'),
    CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY ([idCliente]) REFERENCES [dbo].[Cliente] ([idCliente]),
    CONSTRAINT [FK_Factura_Usuario] FOREIGN KEY ([idUsuario]) REFERENCES [dbo].[Usuario] ([idUsuario])
);



