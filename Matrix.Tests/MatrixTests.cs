using NUnit.Framework;

namespace Matrix.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PassTest()
        {
            Assert.Pass();
        }

        public void FailedTest()
        {
            Assert.Fail();
        }
    }
}