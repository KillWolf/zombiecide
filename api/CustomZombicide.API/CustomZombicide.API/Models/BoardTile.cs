using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomZombicide.API.Models
{
    public class BoardTile
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Board")]
        public int BoardId { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Tile")]
        public string TileId { get; set; }

        //[Range(1,???)]
        public int HorizontalLocation { get; set; }

        //[Range(1,???)]
        public int VerticalLocation { get; set; }

        [RegularExpression(@"^(0|90|180|270)$")]
        public int Rotation { get; set; }


        public virtual Tile Tile { get; set; }

        public virtual Board Board { get; set; }
    }
}
