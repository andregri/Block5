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

        public static Tribool True { get { return new Tribool(1); } }
        public static Tribool False { get { return new Tribool(-1); } }
        public static Tribool Indeterminate { get { return new Tribool(0); } }
        enum TriboolState { Indeterminate, True, False }

        private int value;
        private TriboolState state;

        private TriboolState State
        {
            get { return state; }
            set
            {
                if (value > 0)
                    state = TriboolState.True;
                else if (state == 0)
                    state = TriboolState.Indeterminate;
                else
                    state = TriboolState.False;
            }
        }

        private int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Tribool(int value)
        {
            State = state;
            Value = value;
        }

        // true/false operator
        // true
        public static bool operator true(Tribool firstNumber)
        {
            return firstNumber.state == TriboolState.True;
        }
        // false 
        public static bool operator false(Tribool firstNumber)
        {
            return firstNumber.state == TriboolState.False;
        }

        // logical operator
        // And
        public static Tribool operator &(Tribool firstNumber, Tribool secondNumber)
        {
            if (firstNumber.state == TriboolState.False && secondNumber.state == TriboolState.False)
                return False;
            if (firstNumber.state == TriboolState.Indeterminate && secondNumber.state == TriboolState.Indeterminate)
                return Indeterminate;
            else
                return True;
        }
        // Or
        public static Tribool operator |(Tribool firstNumber, Tribool secondNumber)
        {
            if (firstNumber.state == TriboolState.True && secondNumber.state == TriboolState.True)
                return True;
            if (firstNumber.state == TriboolState.Indeterminate && secondNumber.state == TriboolState.Indeterminate)
                return Indeterminate;
            else
                return False;
        }

        // comparison operator
        // equal 
        public static Tribool operator ==(Tribool firstNumber, Tribool secondNumber)
        {
            if (firstNumber.state == 0 || secondNumber.state == 0)
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
            if (firstNumber.state == TriboolState.Indeterminate)
                return Indeterminate;
            else if (firstNumber.state == TriboolState.False)
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
            return state.GetHashCode();
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
            switch (value.state)
            {
                case TriboolState.True: return true;
                case TriboolState.False: return false;
                default: throw new InvalidCastException("Cast is not possible with indeterminate value");
            }
        }
    }
}
