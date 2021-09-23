using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Circle : Eclipse
    {
        public double radius;

        public double Radius
        {
            get {return Vradius;}
            set 
            {
                Hradius = Vradius = value;
            }
        }
        public Circle()
        {
            Radius = 1.0;
            type = "Circle";
        }

        public Circle(string name, double radius) : base(name, radius, radius)
        {
            type = "Circle";
        }

        public void Show()
        {
            System.Console.WriteLine(Type + ":" + Name);
            System.Console.WriteLine("Radius: " + Radius);
        }

    }
}