CREATE TABLE [dbo].[Boards]
(
	--Columns
	[BoardId] INT IDENTITY NOT NULL,
	[BoardName] VARCHAR(64) NOT NULL,
	[BoardHeight] TINYINT NOT NULL,
	[BoardWidth] TINYINT NOT NULL

	--Keys
	CONSTRAINT PK_Boards PRIMARY KEY (BoardId)

	--Constraints
)
