using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomZombicide.API.Models
{
    public partial class Boards
    {
        public Boards()
        {
            BoardTiles = new HashSet<BoardTiles>();
        }
        [Key]
        public int BoardId { get; set; }
        public string BoardName { get; set; }
        public byte BoardHeight { get; set; }
        public byte BoardWidth { get; set; }

        public virtual ICollection<BoardTiles> BoardTiles { get; set; }
    }
}
