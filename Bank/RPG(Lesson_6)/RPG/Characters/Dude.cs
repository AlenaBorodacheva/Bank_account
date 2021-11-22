using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Characters
{
    class Dude : Person
    {
        public Dude()
        {
            _health = 500;
            name = "Dude";
        }

        public void KickPlayer(Player player)
        {
            player.Health -= 50;
        }
    }
}
