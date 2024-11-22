using System.ComponentModel.DataAnnotations;

namespace KoraaPlus.Areas.Admin.ViewModels
{
    public class TicketCategoryVM
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Ticket Category Name length must be greater than 1 letter")]
        public string? Name { get; set; }
        [Required]
        [Range(1,10000,ErrorMessage ="price must be greater than 0")]
        public decimal Price { get; set; }
    }
}
