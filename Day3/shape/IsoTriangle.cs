using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class IsoTriangle : Triangle
    {
        public double Side
        {
            get{return Side1; }
            set
            {
                Side1 = Side2 = value;
            }
        }
        public double Bottom
        {
            get{return Side3; }
            set
            {
               Side3 = value;
            }
        }
        public IsoTriangle()
        {
            Side = 2;
            Bottom = 1;
            type = "Isosceles triangle";
        }

        public IsoTriangle(string name, double side, double bottom) : base(name, side, side, bottom)
        {
            type = "Isosceles triangle";
        }

        public override void Show()
        {
            Console.WriteLine(Type + ":" + Name);
            Console.WriteLine("Sides : " + Side);
            Console.WriteLine("Side bottom: " + Bottom);           
        }
    }
}