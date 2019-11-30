CREATE TABLE [dbo].[Ticket]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [FirmaId] INT NOT NULL, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(150) NOT NULL, 
    [Detail] NVARCHAR(MAX) NOT NULL
)
