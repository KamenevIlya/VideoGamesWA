using VideoGamesWA.Data.Models;

namespace VideoGamesWA.Repositories.VideoGameRepository
{
    public interface IVideoGameRepository : IRepository<VideoGame>
    {
        List<VideoGame>GetVideoGamesByGenre(Genre genre);
    }
}
