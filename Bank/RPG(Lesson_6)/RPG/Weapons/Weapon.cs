using RPG_Lesson_6_.RPG.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Weapons
{
    class Weapon
    {
        public int Damage { get; protected set; }
        public int Shots { get; protected set; }


        public virtual void Shot()
        {
            if (Shots != 0)
            {
                Shots -= 1;
            }                
        }

        public void Hit(Person person)
        {
            person.Health -= Damage;

            if (person.Health <= 0)
                person.Die();                        
        }
    }
}
