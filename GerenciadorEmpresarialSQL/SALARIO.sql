CREATE TABLE [dbo].[SALARIO] (
    [SalarioID]         INT IDENTITY (1, 1) NOT NULL,
    [ColaboradorID] INT NOT NULL,
    [Quantidade]     INT NOT NULL,
    [Ano]       INT NOT NULL,
    [MesID]    INT NOT NULL,
    CONSTRAINT [PK_SALARIO] PRIMARY KEY CLUSTERED ([SalarioID] ASC)
);