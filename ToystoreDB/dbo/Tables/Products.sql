CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [ProductName] NCHAR(40) NULL, 
    [Price] MONEY NULL, 
    [Description] NCHAR(255) NULL, 
    [mageUrl] NCHAR(1024) NULL
)
