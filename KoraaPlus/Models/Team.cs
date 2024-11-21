namespace KoraaPlus.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LogoUrl { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; } = null!;
        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}
