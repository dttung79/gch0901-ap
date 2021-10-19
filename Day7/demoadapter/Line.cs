using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public class Line : Shape
    {
        public int Length { get; set; }
        public Line()
        {
            Length = 5;
        }

        public Line(int length)
        {
            Length = length;
        }

        public override void Draw()
        {
            System.Console.Write("+");
            for (int i = 0; i < Length; i++) System.Console.Write("--");
            System.Console.WriteLine("+");
        }

        public override Shape Clone()
        {
            Line copyLine = new Line(Length);
            return copyLine;
        }
    }
}