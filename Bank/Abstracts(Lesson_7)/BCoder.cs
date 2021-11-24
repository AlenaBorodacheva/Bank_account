using System;
using System.Linq;
using static Abstracts_Lesson_7_.Alphabet;

namespace Abstracts_Lesson_7_
{
    class BCoder : ICoder<string>
    {
        public string Decode(string item)
        {
            item = item.ToUpper();

            string newItem = "";

            foreach (var letter in item.ToCharArray())
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (letter == alphabet[i])
                    {
                        newItem += alphabet[alphabet.Length - 1 - i];
                    }
                    else if (!alphabet.Any(str => str == letter))
                    {
                        newItem += letter;
                        break;
                    }
                }                        
            }

            return newItem;
        }

        public string Encode(string item)
        {
            return Decode(item);
        }
    }
}
