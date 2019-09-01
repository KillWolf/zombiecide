using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CustomZombicide.API.Models
{
    public partial class CustomZombicideContext : DbContext
    {
        public CustomZombicideContext()
        {
        }

        public CustomZombicideContext(DbContextOptions<CustomZombicideContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BoardTiles> BoardTiles { get; set; }
        public virtual DbSet<Boards> Boards { get; set; }
        public virtual DbSet<Tiles> Tiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CustomZombicide;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BoardTiles>(entity =>
            {
                entity.HasKey(e => e.BoardTileId)
                    .HasName("PK__BoardTil__1481BAD384E83FF2");

                entity.Property(e => e.TileId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Board)
                    .WithMany(p => p.BoardTiles)
                    .HasForeignKey(d => d.BoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardTiles_BoardId");

                entity.HasOne(d => d.Tile)
                    .WithMany(p => p.BoardTiles)
                    .HasForeignKey(d => d.TileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardTiles_TileId");
            });

            modelBuilder.Entity<Boards>(entity =>
            {
                entity.HasKey(e => e.BoardId)
                    .HasName("PK__Boards__F9646BF27130CE3C");

                entity.Property(e => e.BoardName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tiles>(entity =>
            {
                entity.HasKey(e => e.TileId)
                    .HasName("PK__Tiles__7FCB7AE0A52F4C6D");

                entity.Property(e => e.TileId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });
        }
    }
}
