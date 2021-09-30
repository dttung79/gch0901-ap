using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demointerface
{
    public class Square : Rectangle
    {
        public int Side
        {
            get { return Height; }
            set { Width = Height = value; }
        }

        public Square() : base(4, 4)
        {}
        public Square(int side) : base(side, side)
        {}
    }
}