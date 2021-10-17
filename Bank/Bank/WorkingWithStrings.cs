using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class WorkingWithStrings
    {
        public string TurnOver(string str)
        {
            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr += str[i];
            }
            return newStr;
        }

        public Result CreateEmailFile(string filePath)
        {
            //try
            //{
                string[] lines = File.ReadAllLines(filePath);
                string newFilePath = Path.GetDirectoryName(filePath) + "\\Email.txt";
               // File.Create(newFilePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    RecordingEmail(ref lines[i]);
                }
                File.WriteAllLines(newFilePath, lines);
                return Result.Success;
            //}
            //catch
            //{
            //    return Result.Unsuccess;
            //}
        }

        private void RecordingEmail(ref string s)
        {
            string[] line = s.Split('&');
            s = line[1];
            s = s.Trim(' ');
        }
    }
}
