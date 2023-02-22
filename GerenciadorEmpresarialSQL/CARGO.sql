CREATE TABLE [dbo].[CARGO] (
    [CargoID]           INT          IDENTITY (1, 1) NOT NULL,
    [CargoNome] VARCHAR (50) NOT NULL,
    [DepartamentoID] INT          NOT NULL,
    CONSTRAINT [PK_CARGO] PRIMARY KEY CLUSTERED ([CargoID] ASC)
);

--GO
--create trigger delete_position on POSITION after delete as 
--BEGIN
--declare @id int
--select @id = ID from deleted 
--delete from EMPLOYEE where PositionID=@id
--END