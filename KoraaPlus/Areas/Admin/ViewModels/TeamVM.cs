using KoraaPlus.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace KoraaPlus.Areas.Admin.ViewModels
{
    public class TeamVM
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2,ErrorMessage ="Team Name length must be greater than 1 letter")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="League")]
        public int LeagueId { get; set; }

        [ValidateNever]
        public string LogoUrl { get; set; }
        [ValidateNever]
        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}
