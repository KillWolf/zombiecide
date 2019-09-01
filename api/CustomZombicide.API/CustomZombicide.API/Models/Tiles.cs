using System;
using System.Collections.Generic;

namespace CustomZombicide.API.Models
{
    public partial class Tiles
    {
        public Tiles()
        {
            BoardTiles = new HashSet<BoardTiles>();
        }

        public string TileId { get; set; }

        public virtual ICollection<BoardTiles> BoardTiles { get; set; }
    }
}
