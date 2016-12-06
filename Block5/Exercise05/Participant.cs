using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    public class Participant
    {
        private int age;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    throw new ArgumentOutOfRangeException("Age must be positive number");
            }
        }

        public Participant(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
