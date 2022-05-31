using VideoGamesWA.Data.Models;

namespace VideoGamesWA.Services.VideoGamesService
{
    public interface IVideoGamesService
    {
        public List<VideoGame> GetAllVideoGames();

        public VideoGame? GetVideoGameById(Guid id);

        public List<VideoGame> GetVideoGamesByGenre(Genre genre);

        public void CreateVideoGame(VideoGame videoGame);

        public void UpdateVideoGame(Guid id, VideoGame newVideoGame);

        public void DeleteVideoGame(Guid id);
    }
}
