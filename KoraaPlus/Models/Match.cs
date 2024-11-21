using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KoraaPlus.Models
{
    public class Match
    {

        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string? Stadium { get; set; }

        public int TeamAId { get; set; }
        public Team TeamA { get; set; } = null!;

        public int TeamBId { get; set; }
        public Team TeamB { get; set; } = null!;

        public int LeagueId { get; set; } 
        public League League { get; set; } = null!;
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
