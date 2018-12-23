using Infrastructure;
using System.Collections.Generic;

namespace Contacts
{
    public class ExtensionMetadata : IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[] { };

        public IEnumerable<Script> Scripts => new Script[] { };

        public IEnumerable<MenuItem> MenuItems
        {
            get
            {
                return new MenuItem[]
                {
                    new MenuItem("/contacts", "Contacts", 100, "ni-planet")
                };
            }
        }
    }
}
