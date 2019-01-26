using NUnit.Framework;
using StrykerExample;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Program p = new Program();

            Assert.AreEqual(9, p.Process());
        }
    }
}