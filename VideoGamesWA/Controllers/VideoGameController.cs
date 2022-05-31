using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoGamesWA.Data.Models;
using VideoGamesWA.Services.VideoGamesService;

namespace VideoGamesWA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        private readonly IVideoGamesService _videoGamesService;

        public VideoGameController(IVideoGamesService videoGamesService)
        {
            _videoGamesService = videoGamesService;
        }

        [HttpGet]
        public ActionResult<List<VideoGame>> GetAllVideoGames(Genre genre)
        {
            var videoGames = _videoGamesService.GetAllVideoGames();
            return Ok(videoGames);
        }

        [HttpGet]
        public ActionResult<VideoGame> GetVideoGameById(Guid id)
        {
            var videoGame = _videoGamesService.GetVideoGameById(id);
            if (videoGame == null)
            {
                return NotFound(videoGame);
            }
            return Ok(videoGame);
        }

        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGamesByGenre(Genre genre)
        {
            var videoGames = _videoGamesService.GetVideoGamesByGenre(genre);
            return Ok(videoGames);
        }

        [HttpPost]
        public ActionResult PostVideoGame(VideoGame videoGame)
        {
            _videoGamesService.CreateVideoGame(videoGame);
            return Ok();
        }

        [HttpPut]
        public ActionResult PutVideoGame(Guid id, VideoGame newVideoGame)
        {
            _videoGamesService.UpdateVideoGame(id, newVideoGame);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteVideoGame(Guid id)
        {
            _videoGamesService.DeleteVideoGame(id);
            return Ok();
        }
    }
}
