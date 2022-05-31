using VideoGamesWA.Data;
using VideoGamesWA.Data.Models;

namespace VideoGamesWA.Repositories.VideoGameRepository
{
    public class VideoGameRepository : BaseRepository<VideoGame>, IRepository<VideoGame>
    {
        private readonly DataContext _context;

        protected VideoGameRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override List<VideoGame> GetAll()
        {
            return base.GetAll().ToList();
        }

        public override VideoGame? GetById(Guid id)
        {
            return base.GetById(id);
        }

        public List<VideoGame> GetVideoGamesByGenre(Genre genre)
        {
            var result = _context.VideoGames.
                Where(v => v.Genres.Contains(genre)).
                ToList();

            return result;
        }

        public override void Add(VideoGame videoGame)
        {
            base.Add(videoGame);
        }

        public override void Update(Guid id, VideoGame newVideoGame)
        {
            base.Update(id, newVideoGame);
        }

        public override void Delete(Guid id)
        {
            base.Delete(id);
        }
    }
}
