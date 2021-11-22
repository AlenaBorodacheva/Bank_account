using RPG_Lesson_6_.RPG.Transports;
using RPG_Lesson_6_.RPG.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Characters
{
    class Player : Person
    {
        public int _id { get; private set; }

        public int Level { get; private set; }

        public List<Weapon> weapons { get; private set; }

        public Player(string nickName, int id)
        {
            _health = 100;
            name = nickName;
            _id = id;
            Level = 1;

            weapons = new List<Weapon>();
            weapons.Add(new Gun());
            weapons.Add(new Fist());
            weapons.Add(new Magic());
        }

        public void ImproveLevel()
        {
            Level++;
        }

        public void ChangeSkin(Skin skin)
        {
            Skin = skin;
        }
    }
}
