using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public static implicit operator ComplexNumber(double number)
        {
            ComplexNumber complex = new ComplexNumber();
            complex.Real = number;
            return complex;
        }

        public override string ToString()
        {
            return $"{Real} * {Imaginary}i";
        }
    }
}
