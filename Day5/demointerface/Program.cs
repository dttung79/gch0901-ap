using System;

namespace demointerface
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 4);
            Square s = new Square(5);
            Text t = new Text();
            t.Message = "Hello C#";

            IDrawable[] objects = new IDrawable[3];
            objects[0] = r;
            objects[1] = s;
            objects[2] = t;

            foreach (IDrawable obj in objects)
            {
                obj.Draw();
            }
        }
    }
}
