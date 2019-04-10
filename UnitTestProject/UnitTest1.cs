using System;
using NUnit;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            int a = 5;
            
            Assert.AreEqual( 5,a);
        }
    }
}
