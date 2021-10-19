using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_proxy
{
    public class Patient
    {
        public string Name {get; set;}
        public Patient() 
        {
            Name = "Jonh Doe";
        }
        public Patient(string name)
        {
            Name = name;
        }
    }

}