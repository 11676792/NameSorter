using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    /// <summary>
    /// NameSorter class
    /// Contains all methods for sorting names
    /// </summary>
    public class Sorter
    {
        // Sort parsed names
        public static IEnumerable<Name> Sort(IEnumerable<Name> names)
        {
            var sortedNames = names.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);
            return sortedNames;
        }

        // Sort unparsed names
        public static IEnumerable<Name> Sort(IEnumerable<string> names)
        {
            var parsedNames = names.Select(x => Parser.ParseName(x));
            return Sort(parsedNames);
        }
    }
}
