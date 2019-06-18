using Playground.NetCore;
using Xunit;

namespace Playground.Tests
{
    public class SwitchDeconstructTests
    {
        static int GetRank(Person person) => person switch
        {
            { FirstName: "Lucas" } => 1,
            { FirstName: "Jon" } => 2,
            { FirstName: "Mads", LastName: "Torgersen" } => 3,
            Architect p when p.Title == "Mrs" => 4,
            Architect _ => 5,
        };

        [Fact]
        public void Test()
        {
            Assert.Equal(1, GetRank(new Person("Lucas", "Medeiros")));
            Assert.Equal(2, GetRank(new Person("Jon", "Skeet")));
            Assert.Equal(3, GetRank(new Architect("Mr", "Mads", "Torgersen")));
            Assert.Equal(4, GetRank(new Architect("Mrs", "Leah", "Culver")));
            Assert.Equal(5, GetRank(new Architect("Mr", "_", "_")));
        }
    }

    public sealed class Architect : Person
    {
        public Architect(string title, string firstName, string lastName) :
            base(firstName, lastName)
        {
            Title = title;
        }

        public string Title { get; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            (firstName, lastName) = (FirstName, LastName);
        }
    }
}
