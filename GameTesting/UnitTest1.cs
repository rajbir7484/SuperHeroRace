using System;
using SuperHeroRace.RaceModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactory() 
        {
            Punter punter = Factory.GetPunter("George");
            bool result = punter is George;
            Assert.AreEqual(result, true);
        }
    }
}
