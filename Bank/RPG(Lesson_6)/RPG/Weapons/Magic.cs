using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Weapons
{
    class Magic : Weapon
    {
        public Magic()
        {
            Damage = 30;
            Shots = 3;
        }

        public override void Shot()
        {
            base.Shot();
            Console.WriteLine("Avada kedavra!");
        }
    }
}
