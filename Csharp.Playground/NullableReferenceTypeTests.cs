using System;
using Playground.NetCore;
using Xunit;

namespace Csharp.Playground
{
    public class NullableReferenceType
    {
        [Fact]
        public void NameLengthTest()
        {
            IPerson person = new Person("Lucas", "Medeiros");

            Assert.Equal(13, person.GetNameLength());
        }

        [Fact]
        public void NameLengthThrowsException()
        {
            IPerson person = new Person("Lucas", null);

            Assert.Throws<ArgumentNullException>(() => person.GetNameLength());
        }
    }
}
