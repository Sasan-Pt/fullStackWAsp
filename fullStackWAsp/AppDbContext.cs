using fullStackWAsp.Dtos.Media;
using Microsoft.EntityFrameworkCore;

namespace fullStackWAsp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<MediaEntity> Medias { get; set; }
    }
}
