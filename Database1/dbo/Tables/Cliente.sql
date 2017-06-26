CREATE TABLE [dbo].[Cliente] (
    [idCliente] INT           IDENTITY (1, 1) NOT NULL,
    [cedula]    VARCHAR (13)  NOT NULL,
    [nombre]    VARCHAR (100) NOT NULL,
    [direccion] VARCHAR (100) NOT NULL,
    [telefono]  VARCHAR (10)  NOT NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([idCliente] ASC),
    CONSTRAINT [CK_cedulaDiez] CHECK ((len([cedula])=(10) OR len([cedula])=(13)) AND isnumeric([cedula])=(1)),
    CONSTRAINT [CK_NumeroTelefono] CHECK (isnumeric([telefono])=(1)),
    CONSTRAINT [UQ__Cliente__415B7BE55644CE57] UNIQUE NONCLUSTERED ([cedula] ASC)
);

