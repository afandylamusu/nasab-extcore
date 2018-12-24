using FluentValidation;
using Infrastructure.Domain.Commands;
using System;
using System.Linq;

namespace Nasab.Domain.Commands
{
    public class AddNasabCommand : ICommand<PeopleNasab>
    {
        public AddNasabCommand()
        {
            PersonId = Guid.NewGuid();
        }

        public Guid PersonId { get; }

        private string[] _PersonNames;

        public string[] PersonNames { get => _PersonNames; set => _PersonNames = value.Select(o => o.Trim()).ToArray(); }

        public Guid FatherId { get; set; }

        public Guid KabilahId { get; set; }
    }

    public class AddNasabCommandValidator : AbstractValidator<AddNasabCommand>
    {
    }
}