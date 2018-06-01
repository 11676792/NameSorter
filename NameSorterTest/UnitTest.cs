using NameSorter;
using System.Linq;
using Xunit;

namespace NameSorterTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData("Janet Parsons", "Janet", "Parsons")]
        [InlineData("Adonis Julius Archer", "Adonis Julius", "Archer")]
        [InlineData("Hunter Uriah Mathew Clarke", "Hunter Uriah Mathew", "Clarke")]
        [InlineData("Extra  Space", "Extra", "Space")]
        public void ParserTest(string fullName, string firstName, string lastName)
        {
            var name = Parser.ParseName(fullName);
            Assert.Equal(firstName, name.FirstName);
            Assert.Equal(lastName, name.LastName);
        }

        [Fact]
        public void SorterTest()
        {
            var names = new string[]
            {
                "Janet Parsons",
                "Adonis Julius Archer",
                "Hunter Uriah Mathew Clarke",
                "Hunter Uriah Andy Clarke"
            };
            var sortedNames = Sorter.Sort(names).ToList();
            Assert.Equal(4, sortedNames.Count);
            Assert.Equal("Adonis Julius Archer", sortedNames[0].ToString());
            Assert.Equal("Hunter Uriah Andy Clarke", sortedNames[1].ToString());
            Assert.Equal("Hunter Uriah Mathew Clarke", sortedNames[2].ToString());
            Assert.Equal("Janet Parsons", sortedNames[3].ToString());
        }
    }
}
