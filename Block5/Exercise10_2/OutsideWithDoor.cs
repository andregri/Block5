using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_2
{
    public class OutsideWithDoor : OutsideWithHidingPlace, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription
        {
            get;
            set;
        }

        public Location DoorLocation
        {
            get;
            set;
        }
    }
}
