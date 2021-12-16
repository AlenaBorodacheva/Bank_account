using System.Linq;
using static Abstracts_Lesson_7_.Alphabet;

namespace Abstracts_Lesson_7_
{
    internal class ACoder : ICoder<string>
    {
        public string Decode(string item)
        {
            item = item.ToUpper();

            string newItem = "";

            foreach(var letter in item.ToCharArray())
            {
                for(int i = 0; i < alphabet.Length; i++)
                {
                    if(letter == alphabet[i])
                    {
                        if (letter != alphabet[^1])
                        {
                            newItem += alphabet[i + 1];
                        }
                        else
                        {
                            newItem += alphabet[0];
                        }
                        break;
                    }
                    else if(!alphabet.Any(str => str == letter))
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
            item = item.ToUpper();

            string newItem = "";

            foreach (var letter in item.ToCharArray())
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (letter == alphabet[i])
                    {
                        if (letter != alphabet[0])
                        {
                            newItem += alphabet[i - 1];
                        }
                        else
                        {
                            newItem += alphabet[^1];
                        }
                        break;
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
    }
}
