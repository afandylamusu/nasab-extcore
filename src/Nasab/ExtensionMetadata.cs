using Infrastructure;
using System.Collections.Generic;

namespace Nasab
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
                    new MenuItem("/nasab", "Nasab", 100, "ni-planet")
                };
            }
        }
    }
}
