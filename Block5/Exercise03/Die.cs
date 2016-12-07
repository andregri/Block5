using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public delegate void Notifier(ref int counter);

    public class Die : IComparable<Die>
    {
        private int number;
        static private Random randomNumberSupplier = new Random((int)DateTime.Now.Ticks);
        private const int maxNumberOfEyes = 6;

        public event Notifier twoSixesInARow;
        private int[] previousToss;

        public Die()
        {
            number = NewToss();
            previousToss = new int[] { 0, 0 };
            twoSixesInARow += Dummy; // add an empty method to avoid triggering a null event
        }

        public void Toss(ref int doubleSixesCounter)
        {
            previousToss[0] = previousToss[1];
            number = NewToss();
            previousToss[1] = number;

            if (previousToss[0] == 6 && previousToss[1] == 6)
            {
                twoSixesInARow(ref doubleSixesCounter);
                // initialize previous var to avoid trigger event when die tosses a third six 
                previousToss[0] = 0;
                previousToss[1] = 0;
            }
        }

        private int NewToss()
        {
            return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
        }

        public int Number()
        {
            return number;
        }

        public override String ToString()
        {
            return String.Format("[{0}]", number);
        }

        public int CompareTo(Die other)
        {
            return this.Number().CompareTo(other.Number());
        }

        private static void Dummy(ref int c)
        {
        }
    }

}
