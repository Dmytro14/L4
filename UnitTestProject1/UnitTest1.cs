using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = new int[] { 0, 1, 0, 3, 0, 5, 0, 9, 7, 8 };
            int result = l4.Program.Nulls(a);
            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] a = new int[] { 0, 1, 0, 3, 0, 5, 0, 9, 7, 8 };
            int result = l4.Program.Dob(a);
            Assert.AreEqual(result, 56);
        }

    }
}
