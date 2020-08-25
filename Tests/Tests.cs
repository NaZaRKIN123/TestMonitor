using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            TestContext.Out.WriteLine("Hello world 1");
            Assert.Fail();
        }
    }
}
