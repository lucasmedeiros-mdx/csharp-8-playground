using System;
using Xunit;

namespace Playground.Tests
{
    public class IndicesAndRangesTest
    {
        [Fact]
        public void IndiceTest()
        {
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };

            Range phrase = 1..4;
            var text = words[phrase];
            Assert.Equal("quick brown fox jumped", string.Join(' ', text));

            var firstPhrase = words[..4]; // contains "The" through "fox"
            Assert.Equal("The quick brown fox", string.Join(' ', firstPhrase));

            var lastPhrase = words[6..]; // contains "the, "lazy" and "dog"
            Assert.Equal("the lazy dog", string.Join(' ', lastPhrase));

            var lastIndexes = words[^5..];
            Assert.Equal("jumped over the lazy dog", string.Join(' ', lastIndexes));
        }
    }
}
