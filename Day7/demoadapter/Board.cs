using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public class Board
    {
        private List<Shape> shapes;
        public Board()
        {
            shapes = new List<Shape>();
        }

        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        public void RePaint()
        {
            foreach (Shape s in shapes)
            {
                s.Draw();
            }
        }
    }
}