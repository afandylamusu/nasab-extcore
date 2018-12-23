using Moonlay.Domain;
using Newtonsoft.Json;

namespace Nasab.Domain.ValueObjects
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class PeopleId : SingleValueObject<string>
    {
        public PeopleId(string value) : base(value)
        {
        }
    }
}
