using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomZombicide.API.Models
{
    public class Board
    {
        [Key]
        public int BoardId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        //[Range(1,???)]
        public int Height { get; set; }

        //[Range(1,???)]
        public int Width { get; set; }


        public virtual ICollection<BoardTile> BoardTiles { get; set; }
    }
}
