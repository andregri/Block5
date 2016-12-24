using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class Complex
    {
        private double realPart;
        private double imaginaryPart;

        public double RealPart
        {
            get {return realPart; }
            set {realPart = value; }
        }

        public double ImaginaryPart
        {
            get {return imaginaryPart; }
            set {imaginaryPart = value; }
        }

        public Complex(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        // operators overloading 
        // standard arithmetic operations 

        // Sum
        public static Complex operator +(Complex firstNumber, Complex secondNumber)
        {
            Complex result = new Complex(0,0);
            result.realPart = firstNumber.realPart + secondNumber.realPart;
            result.imaginaryPart = firstNumber.imaginaryPart + secondNumber.imaginaryPart;
            
            return result;
        }

        // Difference 
        public static Complex operator -(Complex firstNumber, Complex secondNumber)
        {
            Complex result = new Complex(0,0);
            result.realPart = firstNumber.realPart - secondNumber.realPart;
            result.imaginaryPart = firstNumber.imaginaryPart - secondNumber.imaginaryPart;

            return result;
        }

        // Multiplication
        public static Complex operator *(Complex firstNumber, Complex secondNumber)
        {
            Complex result = new Complex(0, 0);
            result.realPart = (firstNumber.realPart * secondNumber.realPart) - (firstNumber.imaginaryPart * secondNumber.imaginaryPart);
            result.imaginaryPart = (firstNumber.realPart * secondNumber.imaginaryPart) + (firstNumber.imaginaryPart * secondNumber.realPart);

            return result;
        }

        // Division
        public static Complex operator /(Complex firstNumber, Complex secondNumber)
        {            
            Complex result = new Complex(0, 0);
            result.realPart = ((firstNumber.realPart * secondNumber.realPart) - (firstNumber.imaginaryPart * secondNumber.imaginaryPart)) / (Math.Pow(secondNumber.realPart,2) + Math.Pow(secondNumber.imaginaryPart, 2)) ;
            result.imaginaryPart = ((firstNumber.realPart * secondNumber.imaginaryPart) + (firstNumber.imaginaryPart * secondNumber.realPart)) / (Math.Pow(secondNumber.realPart, 2) + Math.Pow(secondNumber.imaginaryPart, 2)) ;

            return result;
        }

        // Coniugate
        public static Complex operator ~(Complex firstNumber)
        {
            Complex result = new Complex(0, 0);
            result.realPart = firstNumber.realPart;
            result.imaginaryPart = -(firstNumber.imaginaryPart);

            return result;
        }

    }
}
