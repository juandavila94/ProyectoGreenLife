CREATE TABLE [dbo].[Plato] (
    [idPlato] INT            IDENTITY (1, 1) NOT NULL,
    [nombre]  VARCHAR (50)   NOT NULL,
    [precio]  DECIMAL (5, 2) NOT NULL,
    [tipo]    VARCHAR (50)   NOT NULL,
    [foto]    IMAGE          NULL,
    CONSTRAINT [PK_Plato] PRIMARY KEY CLUSTERED ([idPlato] ASC)
);



