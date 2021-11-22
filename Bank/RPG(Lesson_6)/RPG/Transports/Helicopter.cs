using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Transports
{
    class Helicopter : Vehicle
    {
        public Helicopter()
        {
            _maxSpeed = 500;
        }

        public override void Sound()
        {  
            Console.WriteLine("Ph-Ph-Ph");
        }

        public void MoveUp(bool Up)
        {
            if (Up)
                Console.WriteLine("Move up");
            else
                Console.WriteLine("Move down");                        
        }
    }
}
