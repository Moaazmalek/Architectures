namespace VideoGameApiVerticleSliceArchitecture.Features.VideoGames.GetAllGames
{
    public class GetAllGamesHandler(
        VideoGameDbContext context) : IRequestHandler<GetAllGamesQuery, IEnumerable<GetAllGamesResponse>>
    {
        public async Task<IEnumerable<GetAllGamesResponse>> Handle(GetAllGamesQuery request, CancellationToken cancellationToken)
        {
            var videoGames = await context.VideoGames.ToListAsync(cancellationToken);
            return videoGames.Select(vg => new GetAllGamesResponse(vg.Id, vg.Title, vg.Genre, vg.ReleaseYear));
        }
    }
}
