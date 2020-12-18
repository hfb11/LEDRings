using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LEDRingTest
{
    [TestClass]
    public class UnitTest1
    {

        bool _led1;
        bool _led2;

        [TestMethod]
        public void BeiLevel0IstKeineLEDAn()
        {
            GivenTwoLEDs();

            WhenSliderMovesTo(0);

            ThanBothLEDsAreOff();
        }

        [TestMethod]
        public void BeiLevel1IstDieErsteLEDAn()
        {
            GivenTwoLEDs();

            WhenSliderMovesTo(1);

            ThanFirstLEDIsOnAndSecondIsOff();
        }

        private void ThanFirstLEDIsOnAndSecondIsOff()
        {
            Assert.IsTrue(_led1);
            Assert.IsFalse(_led2);
        }

        private void ThanBothLEDsAreOff()
        {
            Assert.IsFalse(_led1);
            Assert.IsFalse(_led2);
        }

        private void WhenSliderMovesTo(int value)
        {
            _led1 = value >= 1;
            _led2 = false;
        }

        private void GivenTwoLEDs()
        {
            _led1 = true;
            _led2 = true;
        }
    }
}
