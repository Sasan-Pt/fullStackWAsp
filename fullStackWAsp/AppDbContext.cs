using fullStackWAsp.Classes;
using fullStackWAsp.Dtos.Media;
using Microsoft.EntityFrameworkCore;

namespace fullStackWAsp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<MediaEntity> Medias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MediaEntity>()
                .Property(x => x.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<MediaEntity>()
    .HasMany(m => m.Seasons)
    .WithOne(s => s.Media)
    .HasForeignKey(s => s.MediaId);

            modelBuilder.Entity<SeasonEntity>()
                .HasMany(s => s.Episodes)
                .WithOne(e => e.Season)
                .HasForeignKey(e => e.SeasonId);
        }

    }
}