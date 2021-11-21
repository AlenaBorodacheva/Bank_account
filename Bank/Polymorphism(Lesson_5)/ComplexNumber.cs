namespace Polymorphism_Lesson_5_
{
    public class ComplexNumber
    {
        private float _real;
        private float _image;

        public float Numerator
        {
            get { return _real; }
        }

        public float Denominator
        {
            get { return _image; }
        }


        public ComplexNumber(float real = 0, float image = 0)
        {
            _real = real;
            _image = image;            
        }

        public override string ToString()
        {
            string real;
            string image;

            if (_real == 0)
                real = "";
            else
                real = _real.ToString();

            if (_image == 0)
                image = "";
            else if (_image < 0)
                image = $"- {-_image}i";
            else
                image = $"+ {_image}i";

            return $"{real} {image}";
        }

        public static bool operator ==(ComplexNumber num1, ComplexNumber num2)
        {
            return num1._real == num2._real && num1._image == num2._image;                
        }

        public static bool operator !=(ComplexNumber num1, ComplexNumber num2)
        {
            return num1._real != num2._real || num1._image != num2._image;
        }

        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1._real + num2._real, num1._image + num2._image);
        }

        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1._real - num2._real, num1._image - num2._image);
        }

        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            float newReal = num1._real * num2._real - num1._image * num2._image;
            float newImage = num1._real * num2._image + num1._image * num2._real;
            return new ComplexNumber(newReal, newImage);
        }

        public static ComplexNumber operator *(ComplexNumber complexNumber, int num)
        {
            return complexNumber * new ComplexNumber(num);
        }

        public static ComplexNumber operator *(int num, ComplexNumber complexNumber)
        {
            return complexNumber * num;
        }
    }
}
