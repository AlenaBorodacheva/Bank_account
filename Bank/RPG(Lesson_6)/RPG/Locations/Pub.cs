using RPG_Lesson_6_.RPG.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Locations
{
    class Pub : Location
    {
        private string music = "Tom Waits";

        public Pub()
        {
            characters = new List<Person>();

            for(int i = 0; i < 10; i++ )
            {
                characters.Add(new NPC());
            }

            for (int i = 0; i < 3; i++)
            {
                characters.Add(new Dude());
            }

            for (int i = 0; i < 2; i++)
            {
                characters.Add(new Troll());
            }
        }
    }
}
