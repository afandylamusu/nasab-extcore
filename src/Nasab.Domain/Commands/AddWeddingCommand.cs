using System;
using System.Collections.Generic;
using Infrastructure.Domain.Commands;
using Nasab.Domain.Entities;

namespace Nasab.Domain.Commands
{
    public class AddWeddingCommand : ICommand<Wedding>
    {
        public AddWeddingCommand()
        {
            Chidren = new List<Guid>();
        }

        public Guid KabilahId { get; set; }

        public Guid FatherId { get; set; }

        public Guid MotherId { get; set; }

        public List<Guid> Chidren { get; set; }
    }
}
