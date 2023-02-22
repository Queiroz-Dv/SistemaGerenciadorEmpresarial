CREATE TABLE [dbo].[AUTORIZACAO] (
    [AutorizacaoID]         INT           IDENTITY (1, 1) NOT NULL,
    [ColaboradorID]            INT           NOT NULL,
    [AutorizacaoDataInicial]   DATE          NOT NULL,
    [AutorizacaoDataFinal]     DATE          NOT NULL,
    [AutorizacaoEstado]       INT           NOT NULL,
    [AutorizacaoDescricao] VARCHAR (MAX) NULL,
    [AutorizacaoDia]         INT           NOT NULL,
    CONSTRAINT [PK_AUTORIZACAO] PRIMARY KEY CLUSTERED ([AutorizacaoID] ASC)
);

