using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_proxy
{
    public class SpecialPatient : Patient
    {
        public SpecialPatient() {}

        public SpecialPatient(string name) : base(name) {}
    }
}