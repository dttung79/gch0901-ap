using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Shape
    {
        private string name;

        public string Name
        {
            get {return name;}
            set {name = value;}
        }

        protected string type;
        public string Type
        {
            get{return type;}
        }
        

        public Shape()
        {
            Name = "No name";
            type = "Shape";
        }

        public Shape(string name)
        {
            Name = name;
            type = "Shape";
        }

        public void Show()
        {
            Console.WriteLine(Type + ":" + Name);
        }

        private double area;
        public double Area()
        {
            return 0.0;
        }
    }
}