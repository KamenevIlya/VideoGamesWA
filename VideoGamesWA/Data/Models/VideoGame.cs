namespace VideoGamesWA.Data.Models
{
    public class VideoGame
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string StudioDeveloper { get; set; } = string.Empty;

        public List<Genre> Genres { get; set; } = new List<Genre>();
    }
}
