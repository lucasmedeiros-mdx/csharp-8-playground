using Xunit;

namespace Playground.Tests
{
    internal class Developer : IFullStackDev { }

    public class DiamondOfDeathTests
    {
        [Fact]
        public void MultipleInheritanceTests()
        {
            IBackendDev developer = new Developer();

            Assert.Equal("C#", developer.LearnNewLanguage("C#"));
        }
    }
}
