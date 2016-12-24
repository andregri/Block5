using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;

namespace ClassTest
{
    [TestClass]
    public class UnitTest01
    {
        [TestMethod]
        public void TestITaxableItems()
        {
            decimal totalAmount = 0;
            List<ITaxable> taxable = new List<ITaxable>();

            TaxHouse centerHouse = new TaxHouse("center", true, 200, 150m);
            TaxHouse luxuryHouse = new TaxHouse("luxury", false, 350, 500m);
            TaxBus schoolBus = new TaxBus(25, 46, 1.50m);
            TaxBus oneBus = new TaxBus(50, 1, 1.50m);

            taxable.Add(centerHouse);
            taxable.Add(luxuryHouse);
            taxable.Add(schoolBus);
            taxable.Add(oneBus);

            foreach (ITaxable item in taxable)
            {
                totalAmount += item.TaxValue();
            }

            Assert.AreEqual(1796812.5m, totalAmount);
        }
    }
}
