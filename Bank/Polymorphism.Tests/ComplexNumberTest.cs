using Polymorphism_Lesson_5_;
using Xunit;

namespace Polymorphism.Tests
{
    public class ComplexNumberTest
    {
        ComplexNumber number1 = new ComplexNumber(3, 5);
        ComplexNumber number2 = new ComplexNumber(3, 5);
        ComplexNumber number3 = new ComplexNumber(5, 5);

        [Fact]
        public void EqualsTest()
        {
            Assert.True(number1 == number2);
        }

        [Fact]
        public void SumTest()
        {
            var newNumber = number1 + number3;
            Assert.True(newNumber == new ComplexNumber(8, 10));
        }
    }
}
