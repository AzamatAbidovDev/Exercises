using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string line = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Length = " + line.Length);

            string backline = "";
            for (int i = line.Length-1; i >= 0; i--)
            {
                backline += line[i];
            }

            Console.WriteLine("Reverse text: " + backline);
            Console.WriteLine();
            
            int count = 0;
            int count1 = 0;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLetter(line[i]) && vowels.Contains(line[i]))
                    count++;
                if(char.IsLetter(line[i]) && !vowels.Contains(line[i]))
                    count1++;
            }

            int D = count + count1;
            Console.WriteLine("---Amount of letters = " + D);
            Console.WriteLine("---Amount of vowels = " + count);
            Console.WriteLine("---Amount of consonants = " + count1);
            Console.WriteLine();
            
            Dictionary<char, int> letter = new Dictionary<char, int>();
            foreach (char c in line)
            {
                if (letter.ContainsKey(c))
                    letter[c]++;
                else
                    letter[c] = 1;
            }

            foreach (var pair in letter)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
            Console.WriteLine();
            
            for (int i = 0; i < line.Length; i++)
            {
                if (vowels.Contains(line[i]))
                    line = line.Replace(line[i].ToString(), "");
            }
            Console.WriteLine("Text without vowels: " + line);
            Console.ReadLine();
        }
    }
}
