using RPG_Lesson_6_.Figure;
using RPG_Lesson_6_.RPG.Characters;
using RPG_Lesson_6_.RPG.Locations;
using RPG_Lesson_6_.RPG.Weapons;
using System;

namespace RPG_Lesson_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(3, 3);
            p.SetParameters(Colour.Blue, true);
            p.Move(1, -1);

            Rectangle rectangle = new Rectangle(5, 2);
            rectangle.SetParameters(Colour.Green, true);
            rectangle.ChangeColour(Colour.Lily);
            rectangle.Move(4, 4);

            //---------------------------------//

            // создание игрока
            Player player = new Player("Warrior", 111111);
            Weapon gunPlayer = player.weapons[0];
            Weapon fistPlayer = player.weapons[1];
            Weapon magicPlayer = player.weapons[2];
            player.Move(true);

            // создание тролля
            Location location = new Grot();
            Person person = location.characters[50];
            var troll = (Troll)person;
            troll.Move(false);

            // сражение
            troll.KickPlayer(player);
            
            for(int i = 0; i< 5; i++)
                gunPlayer.Shot();
            gunPlayer.Hit(troll);
            gunPlayer.Hit(troll);

            magicPlayer.Shot();
            magicPlayer.Hit(troll);

        }
    }
}
