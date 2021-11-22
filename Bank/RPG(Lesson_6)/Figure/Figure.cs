using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.Figure
{
    public class Figure
    {
        private Colour _colour;
        private bool _visible;
        protected List<Point> pList;
        protected Point pointAsFigure;

        protected Figure()
        {

        }

        public Figure(Colour colour, bool visible)
        {
            _colour = colour;
            _visible = visible;
        }

        public void SetParameters(Colour colour, bool visible)
        {
            _colour = colour;
            _visible = visible;
        }

        public void Move(int dX, int dY)
        {
            if (pList == null)
            {
                pList = new List<Point>();
                pList.Add(pointAsFigure);
            }                

            foreach (var p in pList)
            {
                p.X += dX;
                p.Y += dY;
            }
        }

        public void ChangeColour(Colour newColour)
        {
            _colour = newColour;
        }

        public bool IsVisible()
        {
            return _visible;
        }

        public void Watch()
        {
            Console.WriteLine($"Colour: {_colour} \n Visible: {_visible}");
        }
    }
}
