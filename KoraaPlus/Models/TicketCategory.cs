namespace KoraaPlus.Models
{
    public class TicketCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int AvailableTickets { get; set; }
        public decimal Price  { get; set; }

    }
}
