using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3b
{
    class Fraction
    {
        private int numerator; //täljare
        private int denominator; //nämnare
        

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;

            if (this.denominator == 0)
            {
                throw new Exception("Nämnaren är 0.");
            }
        }

        public int getNumerator
        {
            get
            {
                return numerator;
            }
        }

        public int getDenominator
        {
            get
            {
                return denominator;
            }
        }

        public bool isNegative()
        {
            if (numerator < 0)
            {
                if (denominator > 0)
                {
                    return true;
                }
            }
            else
            {
                if (denominator < 0)
                {
                    return true;
                }
            }
            return false;
        }

        public string Add(int secondNumerator, int secondDenominator)
        {
            int newFractionNumerator;
            int newFractionDenominator;

            newFractionNumerator = (numerator * secondDenominator) + (secondNumerator * denominator);
            newFractionDenominator = denominator * secondDenominator;

            if (denominator == 0 || secondDenominator == 0)
            {
                return "0";
            }

            return String.Format("{0}/{1}", newFractionNumerator, newFractionDenominator);
        }

        public string Multiply(int secondNumerator, int secondDenominator)
        {
            int newFractionNumerator;
            int newFractionDenominator;

            newFractionNumerator = numerator * secondNumerator;
            newFractionDenominator = denominator * secondDenominator;

            if (denominator == 0 || secondDenominator == 0)
            {
                return "0";
            }

            return String.Format("{0}/{1}", newFractionNumerator, newFractionDenominator);
        }

        public bool IsEqualTo(Fraction secondObject)
        {
            double dDenominator = denominator;
            double dSecDenominator = secondObject.denominator;
            
            if ((dDenominator / dSecDenominator) * secondObject.numerator == numerator)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return String.Format("Ditt bråktal är: {0}/{1}", numerator, denominator);
        }
    }
}
