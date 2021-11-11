using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Lesson_5_
{
    class RationalNumber
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get { return _numerator; }
        }

        public int Denominator
        {
            get { return _denominator; }
        }


        public RationalNumber(int numerator, int denominator)
        {
            if(denominator > 0)
            {
                _numerator = numerator;
                _denominator = denominator;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static bool operator ==(RationalNumber num1, RationalNumber num2)
        {
            return (num1.Numerator == num1.Numerator && num1.Denominator == num2.Denominator);
        }

        public static bool operator !=(RationalNumber num1, RationalNumber num2)
        {
            return (num1.Numerator != num1.Numerator || num1.Denominator != num2.Denominator);
        }

        public bool Equals(RationalNumber num)
        {
            return (_numerator == num.Numerator && _denominator == num.Denominator);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as RationalNumber);
        }

        public override int GetHashCode()
        {
            return _numerator.GetHashCode() + _denominator.GetHashCode();
        }

        public static bool operator <(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator1 = num1.Numerator * num2.Denominator;
            int newNumerator2 = num2.Numerator * num1.Denominator;
            return newNumerator1 < newNumerator2; 
        }

        public static bool operator >(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator1 = num1.Numerator * num2.Denominator;
            int newNumerator2 = num2.Numerator * num1.Denominator;
            return newNumerator1 > newNumerator2;
        }

        public static bool operator <=(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator1 = num1.Numerator * num2.Denominator;
            int newNumerator2 = num2.Numerator * num1.Denominator;
            return newNumerator1 <= newNumerator2;
        }

        public static bool operator >=(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator1 = num1.Numerator * num2.Denominator;
            int newNumerator2 = num2.Numerator * num1.Denominator;
            return newNumerator1 >= newNumerator2;
        }

        public static RationalNumber operator +(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator1 = num1.Numerator * num2.Denominator;
            int newNumerator2 = num2.Numerator * num1.Denominator;
            int newNumerator = newNumerator1 + newNumerator2;
            int newDenominator = num1.Denominator * num2.Denominator;

            return Simplification(new RationalNumber(newNumerator, newDenominator));
        }

        public static RationalNumber operator -(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator1 = num1.Numerator * num2.Denominator;
            int newNumerator2 = num2.Numerator * num1.Denominator;
            int newNumerator = newNumerator1 - newNumerator2;
            int newDenominator = num1.Denominator * num2.Denominator;

            return Simplification(new RationalNumber(newNumerator, newDenominator));
        }

        public static RationalNumber operator ++(RationalNumber num)
        {
            return num + new RationalNumber(1, 1);
        }

        public static RationalNumber operator --(RationalNumber num)
        {
            return num - new RationalNumber(1, 1);
        }

        public static RationalNumber operator *(RationalNumber rationalNum, int num)
        {
            int newNumerator = rationalNum.Numerator * num;
            int newDenominator = rationalNum.Denominator;
            return Simplification(new RationalNumber(newNumerator, newDenominator));
        }

        public static RationalNumber operator *(int num, RationalNumber rationalNum)
        {
            return rationalNum * num;
        }

        public static RationalNumber operator *(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator = num1.Numerator * num2.Numerator;
            int newDenominator = num1.Denominator * num2.Denominator;
            return Simplification(new RationalNumber(newNumerator, newDenominator));
        }

        public static RationalNumber operator /(RationalNumber rationalNum, int num)
        {
            if(num != 0)
            {
                var rationalNum2 = new RationalNumber(1, num);
                return rationalNum * rationalNum2;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static RationalNumber operator /(int num, RationalNumber rationalNum)
        {
            return rationalNum / num;
        }

        public static float operator %(RationalNumber rationalNum, int num)
        {
            var newRationalNum = rationalNum / num;
            var intRationalNum = (int)newRationalNum;
            return rationalNum - (intRationalNum * num);
        }

        public static float operator %(int num, RationalNumber rationalNum)
        {
            return rationalNum % num;
        }

        private static RationalNumber Simplification(RationalNumber num)
        {
            int newNumerator = num.Numerator;
            int newDenominator = num.Denominator;

            if (newNumerator == newDenominator)
                return new RationalNumber(1, 1);

            int minNum;
            if (newNumerator < newDenominator)
                minNum = newNumerator;
            else
                minNum = newDenominator;


            for (int i = 2; i <= minNum; i++)
            {
                if (newNumerator % i == 0 && newDenominator % i == 0)
                {
                    newNumerator /= i;
                    newDenominator /= i;
                    minNum /= i;
                }
            }

            return new RationalNumber(newNumerator, newDenominator);
        }

        public override string ToString()
        {
            return $"{Numerator} / {Denominator}";
        }

        public static implicit operator float (RationalNumber num)
        {
            return num.Numerator / num.Denominator;
        }

        public static explicit operator int(RationalNumber num)
        {
            return num.Numerator / num.Denominator;
        }
    }
}
