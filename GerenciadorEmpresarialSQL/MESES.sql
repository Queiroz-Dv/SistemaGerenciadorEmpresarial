CREATE TABLE [dbo].[MESES] (
    [MesesID]        INT          IDENTITY (1, 1) NOT NULL,
    [MesNome] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Meses] PRIMARY KEY CLUSTERED ([MesesID] ASC)
);