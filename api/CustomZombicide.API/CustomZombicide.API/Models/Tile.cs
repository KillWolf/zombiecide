using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomZombicide.API.Models
{
    public class Tile
    {
        [Key]
        [StringLength(2)]
        [MinLength(2)]
        public string TileId { get; set; }


        public virtual ICollection<BoardTile> BoardTiles { get; set; }
    }
}
