using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    public class Event : IEnumerable<Participant>
    {
        List<Participant> guests;

        public Event()
        {
            guests = new List<Participant>();
        }

        public void AddGuest(Participant guest)
        {
            guests.Add(guest);
        }
        public IEnumerator<Participant> GetEnumerator()
        {
            foreach (Participant guest in guests)
            {
                yield return guest;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
