using System;

namespace ShapeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();
            Shape s = new Circle("C1", 3.5);
            System.Console.WriteLine("Shape area: " + s.Area());
            s.Show();
        }
    }
}
