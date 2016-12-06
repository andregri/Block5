using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public delegate void Notifier(int counter);

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

        public void Toss()
        {
            previousToss = number;
            number = NewToss();

            if (number == 6 && previousToss == 6)
            {
                twoSixesInARow(0);
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

        private static void Dummy(int c)
        {
        }

        private int previousToss;
    }

}
