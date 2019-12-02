using BasicosCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBasicosCSharp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactorialCero()
        {
            int esperado = 1;
            int real = Program.factorialFor(0);

            Assert.AreEqual(real, esperado);

        }

        [TestMethod]
        public void TestFactorialSeis()
        {
            int esperado = 720;
            int real = Program.factorialFor(6);

            Assert.AreEqual(real, esperado);

        }

        [TestMethod]
        public void TestFactorialSeisErroneo()
        {
            int esperado = 999;
            int real = Program.factorialFor(6);

            Assert.AreNotEqual(real, esperado);

        }
    }
}
