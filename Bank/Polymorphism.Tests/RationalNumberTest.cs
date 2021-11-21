using Polymorphism_Lesson_5_;
using System;
using Xunit;

namespace Polymorphism.Tests
{
    public class RationalNumberTest
    {
        RationalNumber number1 = new RationalNumber(1, 5);
        RationalNumber number2 = new RationalNumber(1, 5);
        RationalNumber number3 = new RationalNumber(1, 3);

        [Fact]
        public void EqualsTest()
        {
            Assert.True(number1.Equals(number2));
        }

        [Fact]
        public void CompareTest()
        {
            Assert.True(number1 < number3);
            Assert.True(number1 <= number2);
            Assert.True(number3 > number1);
        }

        [Fact]
        public void SumTest()
        {
            var newNumber = number1 + number2;
            Assert.True(newNumber == new RationalNumber(2, 5));
        }

        [Fact]
        public void IncrementTest()
        {
            Assert.True(number1++ == new RationalNumber(6, 5));
        }
    }
}
