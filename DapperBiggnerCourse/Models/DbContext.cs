using Microsoft.EntityFrameworkCore;

namespace DapperBiggnerCourse.Models
{
    public class VideoGameDbContext : DbContext
    {
        public VideoGameDbContext(DbContextOptions<VideoGameDbContext>options): base(options)
        {
        }
        public DbSet<VideoGame> VideoGames{ get; set; }
    }
}
