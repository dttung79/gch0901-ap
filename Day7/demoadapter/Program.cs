using System;

namespace demoadapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Line l = new Line();
            // l.Draw();

            // Text t = new Text("Design Pattern");
            // t.Print();

            // Triangle ta = new Triangle();
            // ta.Draw();

            // Rectangle r = new Rectangle();
            // r.Draw();

            // TextShape ts = new TextShape();
            // ts.Draw();

            // ts = new TextShape("Sap het gio!");
            // ts.Draw();

            Board b = new Board();

            b.Add(new Line(10));
            b.Add(new TextShape("ABCD"));
            b.Add(new Triangle(5));
            b.Add(new Rectangle(6, 3));

            b.RePaint();
        }
    }
}
