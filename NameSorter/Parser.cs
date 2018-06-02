using System;
using System.Linq;

namespace NameSorter
{
    /// <summary>
    /// NameParser class
    /// Contains all methods for parsing names
    /// </summary>
    public class Parser
    {
        // ParseName does not handle invalid input currently as the requirement doesn't say how
        public static Name ParseName(string fullName)
        {
            string[] parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var firstName = string.Join(" ", parts.Take(parts.Length - 1));
            var lastName = parts.Last();
            return new Name(firstName, lastName);
        }
    }
}
