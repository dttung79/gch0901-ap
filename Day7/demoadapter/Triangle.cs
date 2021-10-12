using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public class Triangle : Shape
    {
        public int Height { get; set; } 
        public Triangle()
        { 
            Height = 3;
        }

        public Triangle(int height)
        {
            Height = height;
        }

        public override void Draw()
        {
            for (int i = 1; i <= Height; i++)
            {
                for (int j = 0; j < i; j++)
                    System.Console.Write("* ");
                System.Console.WriteLine();
            }
        }
    }
}