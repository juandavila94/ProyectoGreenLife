CREATE TABLE [dbo].[Usuario] (
    [idUsuario] INT           IDENTITY (1, 1) NOT NULL,
    [usuario]   VARCHAR (50)  NOT NULL,
    [password]  VARCHAR (50)  NOT NULL,
    [nombre]    VARCHAR (100) NOT NULL,
    [rol]       INT           NOT NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([idUsuario] ASC)
);

