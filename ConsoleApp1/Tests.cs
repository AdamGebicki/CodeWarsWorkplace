using NUnit.Framework;

namespace ConsoleApp1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, new Kata().Devided(10));
        }
    }
}
