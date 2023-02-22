CREATE TABLE [dbo].[DEPARTAMENTO] (
    [DepartamentoID]             INT          IDENTITY (1, 1) NOT NULL,
    [DepartamentoNome] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_DEPARTAMENTO] PRIMARY KEY CLUSTERED ([DepartamentoID] ASC)
);

--GO
--create trigger delete_departamento on DEPARTAMENTO after delete as 
--BEGIN
--declare @id int 
--select @id =DepartamentoID from deleted 
--delete from COLABORADOR where DepartamentoID=@id
--delete from CARGO where DepartamentoID=@id 
--END