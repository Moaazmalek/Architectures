namespace VideoGameApiVerticleSliceArchitecture.Features.VideoGames.GetAllGames
{


    public record GetAllGamesQuery() : IRequest<IEnumerable<GetAllGamesResponse>>;
}
