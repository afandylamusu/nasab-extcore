using System.Collections.Generic;
using Infrastructure.Domain.Commands;
using Nasab.Domain.Entities;

namespace Nasab.Domain.Commands
{
    public class AddWeddingCommand : ICommand<Wedding>
    {
        public AddWeddingCommand()
        {
            Chidren = new List<string>();
        }

        public string KabilahId { get; set; }
        public string FatherId { get; set; }
        public string MotherId { get; set; }
        public List<string> Chidren { get; set; }
    }
}
