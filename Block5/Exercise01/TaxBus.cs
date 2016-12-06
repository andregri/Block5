using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class TaxBus : Bus, ITaxable
    {
        public TaxBus(int numberOfSeats, int regNumber, decimal value) :
            base(numberOfSeats, regNumber, value)
        { }

        public decimal TaxValue()
        {
            return (numberOfSeats * 1.50m);
        }

    }
}
