using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.Figure
{
    public class Point : Figure
    {
        private int _x;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        protected Point()
        {
            // начальные координаты, от которых строится фигура, наследуемая от точки
            _x = 10;
            _y = 10;
        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
            pointAsFigure = this;
        }
    }
}
