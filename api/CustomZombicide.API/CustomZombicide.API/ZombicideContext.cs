using CustomZombicide.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomZombicide.API
{
    public class ZombicideContext : DbContext
    {
        public ZombicideContext() : base()
        {
        }

        public DbSet<Tile> Tile { get; set; }
        public DbSet<Board> Board { get; set; }
        public DbSet<BoardTile> BoardTile { get; set; }
    }
}
