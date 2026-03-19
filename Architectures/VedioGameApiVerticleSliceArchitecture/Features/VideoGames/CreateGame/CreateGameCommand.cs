namespace VideoGameApiVerticleSliceArchitecture.Features.VideoGames.CreateGame
{
    public record CreateGameCommand(string Title, string Genre , int ReleaseYear) : IRequest<CreateGameResponse>;
}
