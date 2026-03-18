using Microsoft.AspNetCore.Mvc;

namespace VideoGameApiVerticleSliceArchitecture.Features.VideoGames.GetAllGames
{
    [ApiController]
    [Route("api/games")]
    public class VideoGamesController (ISender sender): ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllGamesResponse>>> GetAllGames()
        {
            var response = await sender.Send(new GetAllGamesQuery());
            return Ok(response);

        }
    }
}
