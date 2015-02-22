﻿using InitialTrainingLibrary.syf.proofsofconcept.dispose;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.warrior
{
    [TestClass]
    public class WarriorTest
    {
        [TestMethod]
        public void TestExhaustRam()
        {
            var ramExhauster = new RamExhauster();

            ramExhauster.ExhaustRam();

            ramExhauster.Wait();
        }
    }
}
