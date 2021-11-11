using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Lesson_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber rationalNumber1 = new RationalNumber(2, 5);
            RationalNumber rationalNumber2 = new RationalNumber(5, 8);

            RationalNumber rationalNumber3 = rationalNumber1 * rationalNumber2;
            Console.WriteLine(rationalNumber3.ToString());

            rationalNumber3 = rationalNumber1 + rationalNumber2;
            Console.WriteLine(rationalNumber3.ToString());

            rationalNumber1++;
            Console.WriteLine(rationalNumber1.ToString());

            int intRationalNumber = (int)rationalNumber2;
            Console.WriteLine(intRationalNumber.ToString());

            float tail = new RationalNumber(8, 4) % 2;
            Console.WriteLine(tail);

            Console.WriteLine("---------");

            ComplexNumber complexNumber1 = new ComplexNumber(2, 5);
            ComplexNumber complexNumber2 = new ComplexNumber(5, 8);

            ComplexNumber complexNumber3 = complexNumber1 + complexNumber2;
            Console.WriteLine(complexNumber3.ToString());

            complexNumber3 = complexNumber1 * complexNumber2;
            Console.WriteLine(complexNumber3.ToString());

            Console.ReadLine();
        }
    }
}
