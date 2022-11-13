using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Triangle
    {
        public virtual void Draw(int height)
        {
            Console.WriteLine("\t\tTriangles");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Triangle2: Triangle
    {
        public override void Draw(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    class Square: Triangle
    {
        public override void Draw(int height)
        {
            Console.WriteLine("\t\tSquare");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Rhomb: Triangle
    {
        public override void Draw(int height)
        {
            Console.WriteLine("\t\tRhomb");
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= height - 1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = height - 1; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    class Figures
    {
        protected int num;
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public void Draw(Triangle triangle)
        {
            triangle.Draw(num);
        }
    }
}
