﻿CREATE TABLE [dbo].[UsersTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(20) NOT NULL UNIQUE, 
    [Password] NVARCHAR(64) NOT NULL UNIQUE
)
