CREATE TABLE [dbo].[TAREFAS] (
    [TarefaID]               INT           IDENTITY (1, 1) NOT NULL,
    [ColaboradorID]       INT           NOT NULL,
    [TarefaTitulo]        VARCHAR (50)  NOT NULL,
    [TarefaConteudo]      VARCHAR (MAX) NULL,
    [TarefaDataInicial]    DATE          NULL,
    [TarefaDataEntrega] DATE          NULL,
    [TarefaEstado]        INT           NOT NULL,
    CONSTRAINT [PK_TAREFAS] PRIMARY KEY CLUSTERED ([TarefaID] ASC)
);

