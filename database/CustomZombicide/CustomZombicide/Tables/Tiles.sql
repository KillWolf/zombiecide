CREATE TABLE [dbo].[Tiles]
(
	--Columns
	[TileId] CHAR(2) NOT NULL 
	
	--Keys
	CONSTRAINT PK_Tiles PRIMARY KEY (TileId),
	
	--Constraints
	CONSTRAINT CHK_Tiles_TileId CHECK (TileId LIKE '[1-9][A-Z]') 
)
