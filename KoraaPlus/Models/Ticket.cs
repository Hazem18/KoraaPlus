namespace KoraaPlus.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; } = null!;
        public int TicketCategoryId { get; set; }
        public TicketCategory TicketCategory { get; set; } = null!;
        public string? SeatNumber { get; set; }  // Unique for each match
    }
}
