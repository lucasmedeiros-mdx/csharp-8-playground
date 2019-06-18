using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playground.Core;

namespace Playground.NetFramework.Tests
{
    [TestClass]
    public class NullableReferenceTypeTests
    {
        [TestMethod]
        public void NameLengthThrowsArgumentNullException()
        {
            var person = new Person("Lucas", null);

            Assert.ThrowsException<ArgumentNullException>(() => person.GetNameLength());
        }
    }
}
