using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise03;

namespace ClassTest
{
    [TestClass]
    public class UnitTest03
    {
        private void Update(ref int counter)
        {
            counter++;
        }

        [TestMethod]
        public void TestDoubleSixes()
        {
            int doubleSixesCounter = 0;

            Die die = new Die();
            die.twoSixesInARow += new Notifier(Update);

            for (int i = 0; i < 1000; i++)
            {
                die.Toss(ref doubleSixesCounter);
            }

            Assert.IsTrue(doubleSixesCounter > 2);
            Console.WriteLine(doubleSixesCounter);
        }
    }
}
