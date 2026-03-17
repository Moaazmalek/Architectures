namespace VideoGameApiVerticleSliceArchitecture.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Genre { get; set; } = default!;
        public int ReleaseYear { get; set; } = default!;
    }
}
