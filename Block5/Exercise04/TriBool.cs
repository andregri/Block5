using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    // implement interface IEquatable: 
    // this interface indicates whether the current object is equal to another object of the same type
    public class Tribool : IEquatable<Tribool>
    {
        public static Tribool True = new Tribool(1);
        public static Tribool False = new Tribool(-1);
        public static Tribool Indeterminate = new Tribool(0);

        private int value;

        private int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Tribool(int value)
        {
            Value = value;
        }

        // true/false operator
        // true
        public static bool operator true(Tribool firstNumber)
        {
            return firstNumber.value > 0;
        }
        // false 
        public static bool operator false(Tribool firstNumber)
        {
            return firstNumber.value < 0;
        }

        // logical operator
        // And
        public static Tribool operator &(Tribool firstNumber, Tribool secondNumber)
        {
            if (firstNumber.value < 0 && secondNumber.value < 0)
                return False;
            if (firstNumber.value == 0 && secondNumber.value == 0)
                return Indeterminate;
            else
                return True;
        }
        // Or
        public static Tribool operator |(Tribool firstNumber, Tribool secondNumber)
        {
            if (firstNumber.value > 0 && secondNumber.value > 0)
                return True;
            if (firstNumber.value == 0 && secondNumber.value == 0)
                return Indeterminate;
            else
                return False;
        }

        // comparison operator
        // equal 
        public static Tribool operator ==(Tribool firstNumber, Tribool secondNumber)
        {
            if (firstNumber.value == 0 || secondNumber.value == 0)
                return Indeterminate;

            return firstNumber.value == secondNumber.value;
        }
        // different
        public static Tribool operator !=(Tribool firstNumber, Tribool secondNumber)
        {
            return firstNumber.value != secondNumber.value;
        }
        // not
        public static Tribool operator !(Tribool firstNumber)
        {
            if (firstNumber.value == 0)
                return Indeterminate;
            else if (firstNumber.value < 0)
                return True;
            else
                return False;
        }

        // Equals
        public override bool Equals(object obj)
        {
            return (obj != null && obj is Tribool) ? Equals((Tribool)obj) : false;
        }        
        public bool Equals(Tribool value)
        {
            return (bool)(value == this);
        }

        // GetHashCode
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
        
        // implicit/explicit operator
        // implicit 
        public static implicit operator Tribool(bool value)
        {
            return value ? True : False;
        }

        // explicit
        public static explicit operator bool(Tribool value)
        {
            switch (value.value)
            {
                case 1:
                    return true;
                case -1:
                    return false;
                default:
                    throw new InvalidCastException("Cast is not possible with indeterminate value");
            }
        }
    }
}
