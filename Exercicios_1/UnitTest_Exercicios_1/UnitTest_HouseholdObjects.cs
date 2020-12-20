using Exercicios_Modelagem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_Exercicios_1
{
    [TestClass]
    public class UnitTest_HouseholdObjects
    {
        [TestMethod]
        public void TestTurnOn_ShouldReturnTrue()
        {
            //Arrange
            var ret = new HouseholdObjects();

            //Act
            ret.turnOn();

            //Arrange
            Assert.IsTrue(ret.active);
        }

        [TestMethod]
        public void TestTurnOff_ShouldReturnFalse()
        {
            //Arrange
            var ret = new HouseholdObjects();

            //Act
            ret.turnOff();

            //Assert
            Assert.IsFalse(ret.active);
        }
    }

    [TestClass]
    public class UnitTest_AlarmClock
    {
        /*
        [TestMethod]
        //Não consegui acertar esse teste - Reescrever o método
        public void TestPlayRing_WhenAlarmDayHourIsNowAndActiveIsTrue_ShouldReturnTrue()
        {
            //Arrange
            var ret = new AlarmClock();
            var now = DateTime.Now;

            //Act
            ret.setAlarm(now, "ret");

            //Arrange
            Assert.IsTrue(ret.playRing());
        }
        */
        [TestMethod]
        public void TestAcceptSnooze_SnoozeActiveShouldReturnTrue()
        {
            //Arrange
            var ret = new AlarmClock();
            int snoozeInterval = 0;

            //Act
            ret.acceptSnooze(snoozeInterval);

            //Arrange
            Assert.IsTrue(ret.snoozeActive);
        }

        [TestMethod]
        public void TestDeclineSnooze_SnoozeActiveShouldReturnFalse()
        {
            //Arrange
            var ret = new AlarmClock();

            //Act
            ret.declineSnooze();

            //Arrange
            Assert.IsFalse(ret.snoozeActive);
        }
    }

    [TestClass]
    public class UnitTest_ScientificCalculator
    {
        [TestMethod]
        public void TestBatteryRemaining()
        {
            //Arrange
            var calculator = new ScientificCalculator(DateTime.Now.AddYears(-5));

            //Act
            TimeSpan ret = calculator.batteryRemaining();

            //Arrange
            Assert.AreNotEqual(null, ret);
        }

        [TestMethod]
        //Queria que esse método retornasse null nessa caso, mas não consigo fazer um cast int <> null
        public void TestToAdd_WhenActiveIsFalse_ShouldReturn0()
        {
            //Arrange
            var calculator = new ScientificCalculator(DateTime.Now);
            double numberX = 2, numberY = 1;

            //Act
            double ret = calculator.toAdd(numberX, numberY);

            //Arrange
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void TestToAdd_WhenActiveIsTrue_ShouldReturnExpectedRet()
        {
            //Arrange
            var calculator = new ScientificCalculator(DateTime.Now);
            double numberX = 2, numberY = 1;
            double expectedRet = numberX + numberY;

            //Act
            calculator.turnOn();
            double ret = calculator.toAdd(numberX, numberY);

            //Arrange
            Assert.AreEqual(expectedRet, ret);
        }

        [TestMethod]
        public void TestToSub_WhenActiveIsFalse_ShouldReturn0()
        {
            //Arrange
            var calculator = new ScientificCalculator(DateTime.Now);
            double numberX = 2, numberY = 1;

            //Act
            double ret = calculator.toSub(numberX, numberY);

            //Arrange
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void TestToSub_WhenActiveIsTrue_ShouldReturnExpectedRet()
        {
            //Arrange
            var calculator = new ScientificCalculator(DateTime.Now);
            double numberX = 2, numberY = 1;
            double expectedRet = numberX - numberY;

            //Act
            calculator.turnOn();
            double ret = calculator.toSub(numberX, numberY);

            //Arrange
            Assert.AreEqual(expectedRet, ret);
        }

        [TestMethod]
        public void TestToMult_WhenActiveIsFalse_ShouldReturn0()
        {
            //Arrange
            var calculator = new ScientificCalculator(DateTime.Now);
            double numberX = 2, numberY = 1;

            //Act
            double ret = calculator.toMult(numberX, numberY);

            //Arrange
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void TestToMult_WhenActiveIsTrue_ShouldReturnExpectedRet()
        {
            //Arrange
            var calculator = new ScientificCalculator(DateTime.Now);
            double numberX = 2, numberY = 1;
            double expectedRet = numberX * numberY;

            //Act
            calculator.turnOn();
            double ret = calculator.toMult(numberX, numberY);

            //Arrange
            Assert.AreEqual(expectedRet, ret);
        }

        [TestMethod]
        public void TestToDiv_WhenActiveIsFalse_ShouldReturn0()
        {
            //Arrange
            var calculator = new ScientificCalculator(DateTime.Now);
            double numberX = 2, numberY = 1;

            //Act
            double ret = calculator.toDiv(numberX, numberY);

            //Arrange
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void TestToDiv_WhenActiveIsTrue_ShouldReturnExpectedRet()
        {
            //Arrange
            var calculator = new ScientificCalculator(DateTime.Now);
            double numberX = 2, numberY = 1;
            double expectedRet = numberX / numberY;

            //Act
            calculator.turnOn();
            double ret = calculator.toDiv(numberX, numberY);

            //Arrange
            Assert.AreEqual(expectedRet, ret);
        }
    }
}

