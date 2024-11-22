using KoraaPlus.Models;
using System.ComponentModel.DataAnnotations;

namespace KoraaPlus.Areas.Customer.ViewModels
{
    public class TicketVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Match Name")]
        public int MatchId { get; set; }
        [Required]
        [Display(Name = "Ticket Category")]
        public int TicketCategoryId { get; set; }
        [Required]
        public string? SeatNumber { get; set; }  // Unique for each match
    }
}
