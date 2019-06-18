using System;
using Playground.NetCore;
using Xunit;

namespace Playground.Tests
{
    public class MultipleInterfaceImplementationTests
    {
        [Fact]
        public void DefaultOverrideTest()
        {
            IInterface person = new Person("Lucas", "Medeiros");
            IPerson person2 = new Person("Lucas", "Medeiros");

            Assert.Equal(13, person.GetNameLength());
            Assert.Equal(13, person2.GetNameLength());

            //Assert.Throws<NotImplementedException>(() => person.GetNameLength());
            //Assert.Equal(0, person2.GetNameLength());
        }
    }
}
