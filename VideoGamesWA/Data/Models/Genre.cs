namespace VideoGamesWA.Data.Models
{
    public class Genre
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<VideoGame> VideoGames { get; set; } = new List<VideoGame>();
    }
}
