CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(50) NULL, 
    [bio] NVARCHAR(250) NULL, 
    CONSTRAINT [FK_Table_ToTable] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn])
)
