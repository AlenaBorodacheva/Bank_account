using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.Figure
{
    public class Circle : Point
    {
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }


        public Circle(int radius)
        {
            _radius = radius;

            pList = new List<Point>();
            for (double i = 0; i <= 2 * 3.14; i+=0.5)
            {
                Point point = new Point(radius * (int)Math.Cos(i) , radius * (int)Math.Sin(i));
                pList.Add(point);
            }
        }

        public double Square()
        {
            return 3.14 * _radius * _radius;
        }

        public override void Watch()
        {
            Console.WriteLine("This is Circle.");
            base.Watch();
            Console.WriteLine("Square: " + Square());
        }
    }
}
