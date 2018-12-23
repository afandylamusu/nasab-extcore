using System;
using FluentValidation;
using Infrastructure.Domain.Commands;
using Nasab.Domain.ValueObjects;

namespace Nasab.Domain.Commands
{
    public class AddNasabByAdminCommand : ICommand<PeopleNasab>
    {
        public string PersonId { get; set; }
        public string[] PersonNames { get; set; }
        public string FatherId { get; set; }
        public string KabilahId { get; set; }
    }

    public class AddNasabByAdminCommandValidator : AbstractValidator<AddNasabByAdminCommand>
    {

    }
}
