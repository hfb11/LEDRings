using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RingTest
{
    [TestClass]
    public class UnitTest1
    {

        private bool[] _leds;

        [TestMethod]
        public void BeiLevel0IstKeineLEDAn()
        {
            GivenXLEDs(2);

            WhenSliderMovesTo(0);

            ThanLEDStateIs(false, false);
        }

        [TestMethod]
        public void BeiLevel1IstDieErsteLEDAn()
        {
            GivenXLEDs(2);

            WhenSliderMovesTo(1);

            ThanLEDStateIs(true, false);
        }

        [TestMethod]
        public void BeiLevel51SindBeideLEDsAn()
        {
            GivenXLEDs(2);

            WhenSliderMovesTo(51);

            ThanLEDStateIs(true, true);
        }

        [TestMethod]
        public void BeiLevel26SindZweiVonVierLEDsAn()
        {
            GivenXLEDs(4);

            WhenSliderMovesTo(26);

            ThanLEDStateIs(true, true, false, false);
        }

        private void ThanLEDStateIs(params bool[] values)
        {
            CollectionAssert.AreEqual(values, _leds);
        }

        private void WhenSliderMovesTo(int value)
        {
            int count = _leds.Count();

            for (int i = 0; i < count; i++)
            {
                _leds[i] = value > 100 / count * i;
            }
        }

        private void GivenXLEDs(int x)
        {
            _leds = Enumerable.Repeat(true, x).ToArray();
        }
    }
}
