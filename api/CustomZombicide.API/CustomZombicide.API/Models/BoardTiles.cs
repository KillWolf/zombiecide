using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomZombicide.API.Models
{
    public partial class BoardTiles
    {
        [Key]
        public int BoardTileId { get; set; }
        public int BoardId { get; set; }
        public string TileId { get; set; }
        public byte TileRow { get; set; }
        public byte TileColumn { get; set; }
        public short TileRotation { get; set; }

        //https://docs.microsoft.com/en-us/ef/core/modeling/relationships
        [ForeignKey("BoardId")]
        public virtual Boards Board { get; set; }

        public virtual Tiles Tile { get; set; }
    }
}
