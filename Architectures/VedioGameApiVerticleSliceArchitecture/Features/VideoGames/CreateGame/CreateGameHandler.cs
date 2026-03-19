namespace VideoGameApiVerticleSliceArchitecture.Features.VideoGames.CreateGame
{
    public class CreateGameHandler(
        VideoGameDbContext context)
        : IRequestHandler<CreateGameCommand, CreateGameResponse>
    {
        public async Task<CreateGameResponse> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            var videoGame = new VideoGame
            {
                Title=request.Title,
                Genre=request.Genre,
                ReleaseYear=request.ReleaseYear

            };
            context.VideoGames.Add(videoGame);
            await context.SaveChangesAsync(cancellationToken);
            return new CreateGameResponse(videoGame.Id, videoGame.Title, videoGame.Genre,videoGame.ReleaseYear);
        }
    }
}
