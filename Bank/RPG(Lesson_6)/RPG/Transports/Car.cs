using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Transports
{
    class Car : Vehicle
    {
        public Car()
        {
            _maxSpeed = 300;
        }

        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Beep!");
        }
    }
}
