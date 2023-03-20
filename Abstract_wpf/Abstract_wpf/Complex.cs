using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_wpf
{
    class Complex : Pair
    {
        private double Real;
        private double Imaginary;

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public override Pair Add(Pair p)
        {
            Complex c = (Complex)p;
            double real = this.Real + c.Real;
            double imaginary = this.Imaginary + c.Imaginary;
            return new Complex(real, imaginary);
        }

        public override Pair Subtract(Pair p)
        {
            Complex c = (Complex)p;
            double real = this.Real - c.Real;
            double imaginary = this.Imaginary - c.Imaginary;
            return new Complex(real, imaginary);
        }

        public override Pair Multiply(Pair p)
        {
            Complex c = (Complex)p;
            double real = this.Real * c.Real - this.Imaginary * c.Imaginary;
            double imaginary = this.Real * c.Imaginary + this.Imaginary * c.Real;
            return new Complex(real, imaginary);
        }

        public override Pair Divide(Pair p)
        {
            Complex c = (Complex)p;
            double denominator = c.Real * c.Real + c.Imaginary * c.Imaginary;
            double real = (this.Real * c.Real + this.Imaginary * c.Imaginary) / denominator;
            double imaginary = (this.Imaginary * c.Real - this.Real * c.Imaginary) / denominator;
            return new Complex(real, imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}

