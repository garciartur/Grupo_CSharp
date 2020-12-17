using Exercicios_Modelagem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Exercicios_1
{
    [TestClass]
    public class UnitTest_HouseholdObjects
    {
        [TestMethod]
        public void TestTurnOn()
        {
            HouseholdObjects test = new HouseholdObjects();
            test.turnOn();
            Assert.IsTrue(test.active);
        }

        [TestMethod]
        public void TestTurnOff()
        {
            HouseholdObjects test = new HouseholdObjects();
            test.turnOff();
            Assert.IsFalse(test.active);
        }
    }
}
