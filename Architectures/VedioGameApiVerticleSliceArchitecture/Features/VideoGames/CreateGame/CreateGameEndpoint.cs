using Microsoft.AspNetCore.Mvc;

namespace VideoGameApiVerticleSliceArchitecture.Features.VideoGames.CreateGame
{
    [ApiController]
    [Route("api/games")]
    public class CreateGameEndpoint(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<CreateGameResponse>> CreateGame(CreateGameCommand command)
        {
            var response = await sender.Send(command);
            return Created($"/api/games/{response.Id}", response);
        }
    }
}
