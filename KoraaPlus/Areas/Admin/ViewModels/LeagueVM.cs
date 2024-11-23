using KoraaPlus.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace KoraaPlus.Areas.Admin.ViewModels
{
    public class LeagueVM
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "League Name length must be greater than 1 letter")]
        public string Name { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Description length must be greater than 1 letter")]
        public string Description { get; set; }
        [ValidateNever]
        public string LogoUrl { get; set; }

        [ValidateNever]
        public ICollection<Team> Teams { get; set; } = new List<Team>();
        [ValidateNever]
        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}
