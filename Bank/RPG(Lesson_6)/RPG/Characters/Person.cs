using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Characters
{
    class Person
    {
        protected int _health;

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public Skin Skin { get; protected set; }

        public string name { get; protected set; }


        public void Die()
        {
            Console.WriteLine($"{name} is died.");
        }

        public void Move(bool turningLeft)
        {
            if (turningLeft)
                Console.WriteLine("Turning left");
            else
                Console.WriteLine("Tirning right");
        }
    }
}
