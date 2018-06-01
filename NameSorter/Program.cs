using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Provide a file name as parameter.");
                return;
            }

            var fileName = args[0];
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File does not exists.");
                return;
            }

            string[] names = File.ReadAllLines(fileName);
            var sortedNames = Sorter.Sort(names);

            OutputToScreen(sortedNames);
            OutputToFile(sortedNames);
        }

        static void OutputToScreen(IEnumerable<Name> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name.ToString());
            }
        }

        static void OutputToFile(IEnumerable<Name> names)
        {
            var fileName = "sorted-names-list.txt";
            File.WriteAllLines(fileName, names.Select(x => x.ToString()));
        }
    }
}
