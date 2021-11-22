using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Characters
{
    class Troll : Person
    {
        public Troll()
        {
            _health = 50;
            name = "Troll";
        }

        public void KickPlayer(Player player)
        {
            player.Health -= 10;
        }
    }
}
