using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace Abstract_wpf
{
    class FuzzyNumber : Pair
    {
        private double value;
        private double uncertainty;

        public FuzzyNumber(double value, double uncertainty)
        {
            this.value = value;
            this.uncertainty = uncertainty;
        }
        /*Додавання нечітких чисел (Fuzzy numbers) вимагає використання певного методу, 
         * оскільки вони не мають конкретного числового значення, а представляють собою 
         * діапазон можливих значень. Одним з таких методів є метод мінімаксу, який можна 
         * застосувати для додавання двох нечітких чисел.
        Основна ідея полягає у знаходженні мінімального і максимального можливих значень для суми двох нечітких чисел.*/
        public override Pair Add(Pair other)
        {
            if (other is FuzzyNumber)
            {
                //приводимо число до типу Fuzzy number
                FuzzyNumber fn = (FuzzyNumber)other;
                return new FuzzyNumber(value + fn.value, uncertainty + fn.uncertainty);
            }
            throw new ArgumentException("Cannot add different types of Pair.");
        }

        public override Pair Subtract(Pair other)
        {
            if (other is FuzzyNumber)
            {
                FuzzyNumber fn = (FuzzyNumber)other;
                return new FuzzyNumber(value - fn.value, uncertainty + fn.uncertainty);
            }
            throw new ArgumentException("Cannot subtract different types of Pair.");
        }

        public override Pair Multiply(Pair other)
        {
            if (other is FuzzyNumber)
            {
                FuzzyNumber fn = (FuzzyNumber)other;
                double newValue = value * fn.value;
                double newUncertainty = newValue * Math.Sqrt(Math.Pow(uncertainty / value, 2) + Math.Pow(fn.uncertainty / fn.value, 2));
                return new FuzzyNumber(newValue, newUncertainty);
            }
            throw new ArgumentException("Cannot multiply different types of Pair.");
        }

        public override Pair Divide(Pair other)
        {
            if (other is FuzzyNumber)
            {
                FuzzyNumber fn = (FuzzyNumber)other;
                double newValue = value / fn.value;
                double newUncertainty = newValue * Math.Sqrt(Math.Pow(uncertainty / value, 2) + Math.Pow(fn.uncertainty / fn.value, 2));
                return new FuzzyNumber(newValue, newUncertainty);
            }
            throw new ArgumentException("Cannot divide different types of Pair.");
        }

        public override string ToString()
        {
            return $"({value}, {uncertainty})";
        }
    }
}
