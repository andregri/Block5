using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_2
{
    public class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public string HidingPlaceName
        {
            get;
            private set;
        }

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot)
        {
            HidingPlaceName = hidingPlaceName;
        }
    }
}
