using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public abstract class Shape
    {
        public abstract void Draw();
        public abstract Shape Clone();
    }
}