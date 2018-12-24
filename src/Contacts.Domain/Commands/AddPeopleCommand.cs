using Infrastructure.Domain.Commands;
using System;

namespace Contacts.Domain.Commands
{
    public class AddPeopleCommand : ICommand<Contact>
    {
        public Guid ContactId { get; set; }
        public string[] Names { get; set; }
    }
}