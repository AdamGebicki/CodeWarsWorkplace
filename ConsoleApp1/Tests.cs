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
            Assert.AreEqual("############5616", new Kata().CardMask("4556364607935616"));
            Assert.AreEqual("1", new Kata().CardMask("1"));
            Assert.AreEqual("#1111", new Kata().CardMask("11111"));
        }
    }
}
