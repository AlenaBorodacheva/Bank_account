using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.Figure
{
    public class Figure : IFigure
    {
        // Если бы классы Circle и Rectangle не наследовались от Point, то можно было бы создать абстрактный класс,
        // в котором бы был абстрактный метод Square(), и наследоваться от него, а также от интерфейса IFigure. 
        // И класс Figure был бы не нужен. Но, я считаю, что абстрактный класс здесь лишний. 

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

        public void SetParameters(bool visible, Colour colour)
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

        public virtual void Watch()
        {
            Console.WriteLine($"Colour: {_colour} \n Visible: {_visible}");
        }
    }
}
