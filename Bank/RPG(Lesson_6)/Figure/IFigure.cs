using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.Figure
{
    interface IFigure
    {
        void SetParameters(Colour colour, bool visible);
        void Move(int dX, int dY);
        void ChangeColour(Colour newColour);
        bool IsVisible();
        void Watch();
    }
}
