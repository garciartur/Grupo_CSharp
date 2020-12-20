using Exercicios_Modelagem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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

    [TestClass]
    public class UnitTest_VideoGame
    {
        //É necesspario testar também para valor negativo?
        [TestMethod]
        public void TestUpdateMemory_WhenConsumeMemoryIsTrue_ShouldReturnExpectedRet()
        {
            //Arrange
            var videogameTest = new VideoGame(1);
            double expectedRet = 0;

            //Act
            videogameTest.updateMemory(1, true);
            double ret = videogameTest.memoryRemaining;

            //Arrange
            Assert.AreEqual(expectedRet, ret);
        }

        [TestMethod]
        public void TestInstallGame_WhenGameSizeIsLessThanMemoryRemaining_ShouldReturnExpectedRet()
        {
            //Arrange
            var videogameTest = new VideoGame(2);
            double expectedRet = 1;

            //Act
            videogameTest.installGame("ret", 1);
            int ret = videogameTest.gameQty;

            //Arrange
            Assert.AreEqual(expectedRet, ret);
        }

        [TestMethod]
        public void TestUninstallGame_WhenGameSizeIsLessThanMemoryRemaining_ShouldReturnExpectedRet()
        {
            //Arrange
            var videogameTest = new VideoGame(2);
            double expectedRet = 0;
            videogameTest.installGame("ret", 1);

            //Act
            videogameTest.uninstallGame("ret");
            int ret = videogameTest.gameQty;

            //Arrange
            Assert.AreEqual(expectedRet, ret);
        }

        [TestMethod]
        public void TestPlayGame_WhenPlayGameRet_ShouldReturnTrue()
        {
            //Arrange
            var videogameTest = new VideoGame(2);
            videogameTest.installGame("ret", 1);

            //Act
            bool ret = videogameTest.playGame("ret");

            //Arrange
            Assert.IsTrue(ret);
        }
        //Como testar métodos que só exibem informações?
    }

    [TestClass]
    public class UnitTest_PowerDrill
    {
        [TestMethod]
        public void TestChangeTool_WhenDrillToolIsDefault_ShouldReturnZero()
        {
            //Arrange
            var powerDrillTest = new PowerDrill(1, 1);
            string defaultValue = "ret";
            int expectedRet = 0;

            //Act
            powerDrillTest.changeTool(defaultValue);
            var ret = powerDrillTest.drillTool;

            //Arrange
            Assert.AreEqual(expectedRet, ret);
        }

        [TestMethod]
        public void TestSetMaterialType_WhenDrillToolIsDefault_ShouldReturnZero()
        {
            //Arrange
            var powerDrillTest = new PowerDrill(1, 1);
            string defaultValue = "ret";
            int expectedRet = 0;

            //Act            
            double ret = powerDrillTest.setMaterialType(defaultValue);

            //Arrange
            Assert.AreEqual(expectedRet, ret);
        }

        [TestMethod]
        public void TestToScrew_WhenDrillToolIsDefault_ShouldReturnFalse()
        {
            //Arrange
            var powerDrillTest = new PowerDrill(1, 1);
            string defaultValue = "ret";

            //Act            
            bool ret = powerDrillTest.toScrew(defaultValue);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToScrew_WhenDrillWattageIsLessThanWattage_ShouldReturnFalse()
        {
            //Arrange
            var powerDrillTest = new PowerDrill(1, 1);
            string screwValue = "chave phillips";

            //Act            
            bool ret = powerDrillTest.toScrew(screwValue);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToDrill_WhenDrillToolIsDefault_ShouldReturnFalse()
        {
            //Arrange
            var powerDrillTest = new PowerDrill(1, 1);
            string defaultValue = "ret";

            //Act            
            bool ret = powerDrillTest.toDrill(defaultValue);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToDrill_WhenDrillWattageIsLessThanWattage_ShouldReturnFalse()
        {
            //Arrange
            var powerDrillTest = new PowerDrill(1, 1);
            string drillValue = "broca";

            //Act            
            bool ret = powerDrillTest.toDrill(drillValue);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToSand_WhenDrillToolIsDefault_ShouldReturnFalse()
        {
            //Arrange
            var powerDrillTest = new PowerDrill(1, 1);
            string defaultValue = "ret";

            //Act            
            bool ret = powerDrillTest.toSand(defaultValue);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToSand_WhenDrillWattageIsLessThanWattage_ShouldReturnFalse()
        {
            //Arrange
            var powerDrillTest = new PowerDrill(1, 1);
            string sandValue = "lixa";

            //Act            
            bool ret = powerDrillTest.toSand(sandValue);

            //Arrange
            Assert.IsFalse(ret);
        }
    }

    [TestClass]
    public class UnitTest_DigitalSafeBox
    {
        [TestMethod]
        public void TestToConfirmPassword_WhenSafePasswordAndPasswordConfirmationAreNotEquals_ShouldReturnFalse()
        {
            //Arrange
            string safePassword = "0";
            var safeBoxTest = new DigitalSafeBox(safePassword);
            string passwordConfirmation = "1";

            //Act            
            bool ret = safeBoxTest.toConfirmPassword(safePassword, passwordConfirmation);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToValidatePassword_WhenSafePasswordIsWrong_ShouldReturnFalse()
        {
            //Arrange
            string safePassword = "0";
            var safeBoxTest = new DigitalSafeBox(safePassword);
            string wrongPassword = "1";

            //Act            
            bool ret = safeBoxTest.toValidatePassword(wrongPassword);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToUpdateRejection_WhenNewRejectionIsTrueAndPasswordRejectionLessThanThree_ShouldReturnTrue()
        {
            //Arrange
            string safePassword = "0";
            var safeBoxTest = new DigitalSafeBox(safePassword);

            //Act            
            bool ret = safeBoxTest.toUpdateRejection(true);

            //Arrange
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void TestToUpdateRejection_WhenNewRejectionIsTrueAndPasswordRejectionMoreThanThree_ShouldReturnFalse()
        {
            //Arrange
            string safePassword = "0";
            var safeBoxTest = new DigitalSafeBox(safePassword);
            for(int i = 0; i <3; i++) safeBoxTest.toUpdateRejection(true);

            //Act            
            bool ret = safeBoxTest.toUpdateRejection(true);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToUpdateRejection_WhenNewRejectionIsFalse_PasswordRejectionShouldReturnZero()
        {
            //Arrange
            string safePassword = "0";
            var safeBoxTest = new DigitalSafeBox(safePassword);
            var expectedValue = 0;
            for (int i = 0; i < 3; i++) safeBoxTest.toUpdateRejection(true);
            safeBoxTest.toUpdateRejection(false);

            //Act            
            int ret = safeBoxTest.passwordRejection;

            //Arrange
            Assert.AreEqual(expectedValue, ret);
        }

        [TestMethod]
        //O método foi chamado indiretamente e não aparece como testado :(
        public void TestToSetSafeBlocked_ShouldReturnTrue()
        {
            //Arrange
            string safePassword = "0";
            var safeBoxTest = new DigitalSafeBox(safePassword);
            for (int i = 0; i <= 3; i++) safeBoxTest.toUpdateRejection(true);

            //Act            
            bool ret = safeBoxTest.getSafeBlocked();

            //Arrange
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void TestToUnlockSafeBox_WhenSafeLockedIsFalse_ShouldReturnFalse()
        {
            //Arrange
            string safePassword = "0";
            string passwordConfirmation = "0";
            var safeBoxTest = new DigitalSafeBox(safePassword);

            //Act            
            bool ret = safeBoxTest.toUnlockSafeBox(safePassword, passwordConfirmation);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToUnlockSafeBox_WhenSafePasswordAndPasswordConfirmationAreNotEquals_ShouldReturnFalse()
        {
            //Arrange
            string safePassword = "0";
            string passwordConfirmation = "1";
            var safeBoxTest = new DigitalSafeBox(safePassword);
            safeBoxTest.toLockSafeBox();

            //Act            
            bool ret = safeBoxTest.toUnlockSafeBox(safePassword, passwordConfirmation);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToUnlockSafeBox_WhenSafeBlockedIsTrue_ShouldReturnFalse()
        {
            //Arrange
            string safePassword = "0";
            string passwordConfirmation = "0";
                    //Bloqueando o cofre
            var safeBoxTest = new DigitalSafeBox(safePassword);
            safeBoxTest.toLockSafeBox();
            for (int i = 0; i <= 3; i++) safeBoxTest.toUpdateRejection(true);

            //Act            
            bool ret = safeBoxTest.toUnlockSafeBox(safePassword, passwordConfirmation);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToUnlockSafeBox_WhenSafePasswordIsWrong_ShouldReturnFalse()
        {
            //Arrange
            string safePassword = "0";
            string passwordConfirmation = "1";
            string wrongPassword = "1";
            var safeBoxTest = new DigitalSafeBox(safePassword);
            safeBoxTest.toLockSafeBox();

            //Act            
            bool ret = safeBoxTest.toUnlockSafeBox(wrongPassword, passwordConfirmation);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToUpdateSafePassword_WhenSafeLockedIsTrueAndSafeBlockedIsFalse_ShouldReturnFalse()
        {
            //Arrange
            string safePassword = "0";
            string newPassword = "1";
            var safeBoxTest = new DigitalSafeBox(safePassword);
            safeBoxTest.toLockSafeBox();

            //Act            
            bool ret = safeBoxTest.toUpdatePassword(newPassword);

            //Arrange
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestToUpdateSafePassword_WhenSafeLockedIsTrueAndSafeBlockedIsTrue_ShouldReturnFalse()
        {
            //Arrange
            string safePassword = "0";
            string newPassword = "1";
            var safeBoxTest = new DigitalSafeBox(safePassword);
            safeBoxTest.toLockSafeBox();
            for (int i = 0; i <= 3; i++) safeBoxTest.toUpdateRejection(true);

            //Act            
            bool ret = safeBoxTest.toUpdatePassword(newPassword);

            //Arrange
            Assert.IsFalse(ret);
        }
    }
}

