using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
            Figures figure = new Figures();

            Console.Write("Enter height: ");           
            figure.Num = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            
            figure.Draw(new Triangle());

            Console.ForegroundColor = ConsoleColor.Cyan;

            figure.Draw(new Triangle2());

            Console.ForegroundColor = ConsoleColor.Magenta;

            figure.Draw(new Square());

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            figure.Draw(new Rhomb());

            Console.ReadLine();
        }
    }
}
