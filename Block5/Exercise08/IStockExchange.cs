using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    public interface IStockExchange
    {
        string Id
        {
            get;
        }

        double MaxGrowth
        {
            get;
        }

        decimal MaxValueMln
        {
            get;
        }
    }
}
