using System;

namespace demo_proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinic dakhoa = new Clinic();
            Patient minh = new Patient("Minh");
            dakhoa.Examine(minh);
            SpecialPatient hung = new SpecialPatient("Hung");
            dakhoa.Examine(hung);
        }
    }
}
