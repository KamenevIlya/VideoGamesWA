using VideoGamesWA.Data.Models;
using VideoGamesWA.Repositories.VideoGameRepository;

namespace VideoGamesWA.Services.VideoGamesService
{
    public class VideoGamesService : IVideoGamesService
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public VideoGamesService(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }

        public List<VideoGame> GetAllVideoGames()
        {
            return _videoGameRepository.GetAll();
        }

        public VideoGame? GetVideoGameById(Guid id)
        {
            return _videoGameRepository.GetById(id);
        }

        public List<VideoGame> GetVideoGamesByGenre(Genre genre)
        {
            return _videoGameRepository.GetVideoGamesByGenre(genre);
        }

        public void CreateVideoGame(VideoGame videoGame)
        {
            _videoGameRepository.Add(videoGame);
        }

        public void UpdateVideoGame(Guid id, VideoGame newVideoGame)
        {
            _videoGameRepository.Update(id, newVideoGame);
        }

        public void DeleteVideoGame(Guid id)
        {
            _videoGameRepository.Delete(id);
        }
    }
}
