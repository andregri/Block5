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

        public Die()
        {
            number = NewToss();
            previousToss = 0;
            twoSixesInARow += Dummy; // add an empty method to avoid triggering a null event
        }

        public void Toss(ref int doubleSixesCounter)
        {
            previousToss = number;
            number = NewToss();

            if (number == 6 && previousToss == 6)
            {
                twoSixesInARow(ref doubleSixesCounter);
                previousToss = 0; // initialize previous var to avoid trigger event when die tosses a third six 
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

        public event Notifier twoSixesInARow;

        private static void Dummy(ref int c)
        {
        }

        private int previousToss;
    }

}
