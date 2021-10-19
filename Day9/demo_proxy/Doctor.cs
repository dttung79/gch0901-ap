using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_proxy
{
    public class Doctor : Examinor
    {
        public string Name { get; set; }
        public Doctor()
        {
            Name = "John Doe";
        }

        public Doctor(string name) 
        {
            Name = name;
        }

        public override void Examine(Patient patient)
        {
            System.Console.WriteLine("Patient: " + patient.Name);
            System.Console.Write("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Where is your pain: ");
            string pain = Console.ReadLine();
            System.Console.WriteLine("You need to drink drug");
        }
    }
}