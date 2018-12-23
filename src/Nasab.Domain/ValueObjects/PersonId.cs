using Moonlay.Domain;
using Newtonsoft.Json;

namespace Nasab.Domain.ValueObjects
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class PersonId : SingleValueObject<string>
    {
        public PersonId(string value) : base(value)
        {
        }
    }
}
