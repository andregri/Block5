using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class TaxHouse : House, ITaxable
    {
        public TaxHouse(string location, bool inCity, double area,
             decimal value) :
            base(location, inCity, area, value)
        { }


        public decimal TaxValue()
        {
            switch (location)
            {
                case "center":
                    return (decimal)(area * 2330);
                case "hinterland":
                    return (decimal)(area * 1707);
                case "ghetto":
                    return (decimal)(area * 1135);
                case "luxury":
                    return (decimal)(area * 3802);
                default:
                    return (decimal)(area * 1500);
            }
        }
    }
}
