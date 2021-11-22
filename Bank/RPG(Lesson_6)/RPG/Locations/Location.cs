using RPG_Lesson_6_.RPG.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Locations
{
    class Location
    {
        // Area
        protected int Xmax = 5000;
        protected int Ymax = 5000;

        public List<Person> characters { get; protected set; }
    }
}
