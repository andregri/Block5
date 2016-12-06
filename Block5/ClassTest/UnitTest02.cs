using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise02;

namespace ClassTest
{
    [TestClass]
    public class UnitTest02
    {
        private bool IsRandom(Die[] dice)
        {
            for (int i = 1; i < dice.Length; i++)
            {
                if (dice[i - 1].CompareTo(dice[i]) > 0)
                {
                    return true;
                }
            }

            return false;
        }

        [TestMethod]
        public void TestIComparable()
        {
            Die[] dice = new Die[]
            {
                new Die(), new Die(), new Die(), new Die(),
                new Die(), new Die(), new Die(), new Die(),
                new Die(), new Die(), new Die(), new Die(),
                new Die(), new Die(), new Die(), new Die()
            };

            Assert.IsTrue(IsRandom(dice));
            Array.Sort(dice);
            Assert.IsFalse(IsRandom(dice));
        }
    }
}
