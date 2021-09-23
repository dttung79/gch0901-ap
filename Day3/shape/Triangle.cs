using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Triangle : Shape
    {
        private double side1;
        public double Side1
        {
            get { return side1; }
            set
            {
                if(value < 0)
                {
                    side1 = 1.0;
                }
                else
                {
                    side1 = value;
                }
            }
        }

        private double side2;
        public double Side2
        {
           get { return side2; }
            set
            {
                if(value < 0)
                {
                    side2 = 1.0;
                }
                else
                {
                    side2 = value;
                }
            } 
        }

        private double side3;
        public double Side3
        {
            get { return side3;}
            set
            {
                if(value < 0)
                {
                    side3 = 1.0;
                }
                else
                {
                    side3 = value;
                }
            }
        }
        public Triangle()
        {
            side1 = 2.0;
            side2 = 4.0;
            side3 = 3.0;
            type = "Triangle";
        }
        public Triangle(string name, double side1, double side2, double side3) : base(name)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            type = "Triangle";
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine("Side 1: " + side1);
            Console.WriteLine("Side 2: " + side2);
            Console.WriteLine("Side 3: " + side3);
        }
        public override double Area()
        {
            double p = (side1 + side2 + side3)/2.0;
            
            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }
    }
}