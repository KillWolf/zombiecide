CREATE TABLE [dbo].[BoardTiles]
(
	--Columns
	[BoardTileId] INT IDENTITY NOT NULL,
	[BoardId] INT NOT NULL,
	[TileId] CHAR(2) NOT NULL,
	[TileRow] TINYINT NOT NULL,
	[TileColumn] TINYINT NOT NULL,
	[TileRotation] SMALLINT NOT NULL

	--Keys
	CONSTRAINT PK_BoardTiles PRIMARY KEY (BoardTileId),
	CONSTRAINT FK_BoardTiles_BoardId FOREIGN KEY (BoardId) REFERENCES Boards(BoardId),
	CONSTRAINT FK_BoardTiles_TileId FOREIGN KEY (TileId) REFERENCES Tiles(TileId),

	--Constraints
	CONSTRAINT CHK_BoardTiles_Rotation CHECK (TileRotation IN (0,90,180,270))
)
