using Moonlay.Domain;
using Newtonsoft.Json;
using System;

namespace Nasab.Domain.ValueObjects
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class PeopleId : SingleValueObject<Guid>
    {
        public PeopleId(Guid value) : base(value)
        {
        }
    }
}
