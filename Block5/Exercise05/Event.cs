using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Event : IEnumerable<Participant>
    {
        List<Participant> guests;
        Participant guest;

        public Event()
        {
            guests = new List<Participant>();
        }

        public void AddGuest()
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
