using Nasab.Domain.Commands;
using System;

namespace Nasab.ViewModels.Nasab
{
    public class CreateViewModel
    {
        public string FatherId { get; set; }
        public string KabilahId { get; set; }
        public string[] PersonNames { get; set; }

        internal void Map(out AddNasabByAdminCommand command)
        {
            command = new AddNasabByAdminCommand
            {
                FatherId = FatherId,
                KabilahId = KabilahId,
                PersonNames = PersonNames
            };
        }
    }
}
