using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Weapons
{
    class Gun : Weapon
    {
        public Gun()
        {
            Damage = 10;
            Shots = 10;
        }

        public override void Shot()
        {
            base.Shot();
            Console.WriteLine("Bang!");
        }
    }
}
