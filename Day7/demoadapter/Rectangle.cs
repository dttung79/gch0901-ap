using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public class Rectangle : Shape
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

        public override void Draw()
        {
            Line side = new Line(Width);
            side.Draw();

            for (int i = 0; i < Height; i++)
            {
                System.Console.Write("|");
                for (int j = 0; j < Width; j++)
                    System.Console.Write("  ");
                System.Console.WriteLine("|");
            }

            side.Draw();
        }

        public override Shape Clone()
        {
            Rectangle copyRect = new Rectangle(Width, Height);
            return copyRect;
        }
    }
}