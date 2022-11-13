using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static string getNums()
        {
            Console.Write("Enter numbers: ");
            var line = Console.ReadLine();
            if (isCorrectLine(line))
                return line;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid numbers");
                Console.ForegroundColor = ConsoleColor.White;
                return getNums();
            }
        }
        static bool isCorrectLine(string line)
        {
            if (string.IsNullOrEmpty(line)) return false;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLetter(line[i])) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            var line = getNums();
            string[] numsText = line.Split(' ');
            int[] nums = new int[numsText.Length];
            int temp;
            int n;

            for (int i = 0; i < numsText.Length; i++)
            {
                int.TryParse(numsText[i], out n);
                nums[i] = n;
            }
            Console.WriteLine();
            Console.Write("Ascending = ");
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Descending = ");
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(nums[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
