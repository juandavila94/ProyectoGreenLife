CREATE TABLE [dbo].[Detalle] (
    [idDetalle] INT              IDENTITY (1, 1) NOT NULL,
    [idFactura] INT              NOT NULL,
    [idPlato]   INT              NOT NULL,
    [cantidad]  INT              NOT NULL,
    [precio]    DECIMAL (20, 15) NOT NULL,
    CONSTRAINT [PK_Detalle] PRIMARY KEY CLUSTERED ([idDetalle] ASC),
    CONSTRAINT [FK_Detalle_Factura] FOREIGN KEY ([idFactura]) REFERENCES [dbo].[Factura] ([idFactura]),
    CONSTRAINT [FK_Detalle_Plato] FOREIGN KEY ([idPlato]) REFERENCES [dbo].[Plato] ([idPlato])
);

