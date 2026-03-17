
namespace VideoGameApiVerticleSliceArchitecture.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options)
        :DbContext(options)
    {
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();
    }
}
