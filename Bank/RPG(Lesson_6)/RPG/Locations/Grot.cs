using RPG_Lesson_6_.RPG.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Locations
{
    class Grot : Location
    {
        private string music = "Edvard Grieg";

        public Grot()
        {
            characters = new List<Person>();

            for (int i = 0; i < 3; i++)
            {
                characters.Add(new NPC());
            }

            for (int i = 0; i < 5; i++)
            {
                characters.Add(new Dude());
            }

            for (int i = 0; i < 50; i++)
            {
                characters.Add(new Troll());
            }
        }
    }
}
