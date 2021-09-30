using System;

namespace demointerface
{
    public class Rectangle : IDrawable // Rectangle implements IDrawable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {
            Width = 5;
            Height = 2;
        }
        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
            }
        }
    }
}