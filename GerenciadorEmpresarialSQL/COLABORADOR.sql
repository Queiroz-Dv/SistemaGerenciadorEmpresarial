CREATE TABLE [dbo].[COLABORADOR] (
    [ColaboradorID]           INT           IDENTITY (1, 1) NOT NULL,
    [NumeroUsuario]       INT           NOT NULL,
    [Nome]         VARCHAR (50)  NOT NULL,
    [Sobrenome]      VARCHAR (50)  NOT NULL,
    [CaminhoImagem]    VARCHAR (MAX) NOT NULL,
    [DepartamentoID] INT           NOT NULL,
    [CargoID]   INT           NOT NULL,
    [Salario]       INT           NOT NULL,
    [DtNascimento]     DATE          NULL,
    [Endereco]       VARCHAR (MAX) NULL,
    [Senha]     VARCHAR (20)  NULL,
    [isAdmin]      BIT           NULL,
    CONSTRAINT [PK_COLABORADOR] PRIMARY KEY CLUSTERED ([ColaboradorID] ASC)
);


--GO
--create trigger delete_employee on EMPLOYEE
--after delete as 
--BEGIN
--declare @id int 
--select @id=ID from deleted
--delete from TASK where EmployeeID=@id
--delete from SALARY where EmployeeID=@id
--delete from PERMISSION where EmployeeID=@id
--END