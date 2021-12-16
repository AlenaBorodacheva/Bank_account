using System;

namespace Abstracts_Lesson_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            ACoder aCoder = new ACoder();
            string text1 = "Катя Ира";
            Console.WriteLine(text1);
            Console.WriteLine(aCoder.Decode(text1));
            Console.WriteLine(aCoder.Encode(aCoder.Decode(text1)));

            Console.WriteLine("--------------");

            BCoder bCoder = new BCoder();
            string text2 = "В лесу родилась ёлочка";
            Console.WriteLine(text2);
            Console.WriteLine(bCoder.Decode(text2));
            Console.Out.WriteLine(bCoder.Encode(bCoder.Decode(text2)));
        }
    }
}
