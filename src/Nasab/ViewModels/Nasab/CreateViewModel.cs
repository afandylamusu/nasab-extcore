using Nasab.Domain.Commands;
using System;
using System.ComponentModel.DataAnnotations;

namespace Nasab.ViewModels.Nasab
{
    public class CreateViewModel
    {
        [Display(Name = "Father")]
        [Required]
        public string FatherId { get; set; }

        [Display(Name = "Kabilah")]
        [Required]
        public string KabilahId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        internal void Map(out AddNasabByAdminCommand command)
        {
            command = new AddNasabByAdminCommand
            {
                FatherId = FatherId,
                KabilahId = KabilahId,
                PersonNames = new string[] { FirstName, LastName }
            };
        }
    }
}
