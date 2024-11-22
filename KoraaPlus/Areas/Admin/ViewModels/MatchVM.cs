using KoraaPlus.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace KoraaPlus.Areas.Admin.ViewModels
{
    public class MatchVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Date Time")]
        public DateTime DateTime { get; set; }
        [Required]
        [Display(Name = "Stadium Name")]
        [MinLength(3,ErrorMessage = "Stadium Name length must be greater than 3 letters")]
        public string? Stadium { get; set; }
        [Required]
        [Display(Name = "Team Home Name")]
        public int TeamAId { get; set; }
        [Required]
        [Display(Name = "Team Away Name")]
        public int TeamBId { get; set; }
        [Required]
        [Display(Name = "League Name")]
        public int LeagueId { get; set; }
        [ValidateNever]
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
