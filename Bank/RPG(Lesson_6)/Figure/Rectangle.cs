using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.Figure
{
    public class Rectangle : Point
    {
        private int _widht;

        public int Widht
        {
            get { return _widht; }
            set { _widht = value; }
        }

        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Rectangle(int widht, int height)
        {
            _widht = widht;
            _height = height;

            pList = new List<Point>();
            for (int i = X; i <= X + widht; i++)
            {
                Point point = new Point(i, Y);
                pList.Add(point);
            }

            for (int i = Y; i <= Y + height; i++)
            {
                Point point = new Point(X, i);
                pList.Add(point);
            }
        }

        public int Square()
        {
            return _height * _widht;
        }
    }
}
