using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Eclipse : Shape
    {
        private double vradius;

        public double Vradius
        {
            get {return vradius;}
            set 
            {
                if(value <= 0)
                {
                    vradius = 1.0;
                }
                else
                {
                    vradius = value;
                }
            }
        }

        private double hradius;

        public double Hradius
        {
            get {return hradius;}
            set 
            {
                if(value <= 0)
                {
                    hradius = 1.0;
                }
                else
                {
                    hradius = value;
                }
            }
        }

        public Eclipse()     // automatic called default contructor of Shape
        {
            vradius = 1.0;
            hradius = 1.0;
            type =  "Eclipse";
        }

        public Eclipse(string name, double vradius, double hradius) : base(name)
        {
            Vradius = vradius;
            Hradius = hradius;
            type = "Eclipse";
        }

        public double Area()
        {           
            return 3.14*hradius*vradius;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine("Radiuses: (" + vradius + ", " + hradius + ")");            
        }
    }
}